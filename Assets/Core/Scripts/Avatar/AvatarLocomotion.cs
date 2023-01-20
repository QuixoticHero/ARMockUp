using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class AvatarLocomotion : MonoBehaviour, IDisableLocomotion
{
    private CharacterController m_charCtrl;
    private IEnergySource m_energySource;
    private IAnimationTime m_animTime;

    private ITarget target;

    private Vector3 moveInput;
    private float moveRate = 1;

    private Vector3 currentMovement;
    private Vector3 desiredMovement;
    [SerializeField] private float movementAdjustRate = 3;

    [SerializeField] private float walkRate = 1f;
    [SerializeField] private float runRate = 2f;
    [SerializeField] private float runningCost = 4f;
    [SerializeField] private AnimationCurve runningCurve 
        = new AnimationCurve(new Keyframe(0, 0), new Keyframe(0.35f, 0.6f), 
                             new Keyframe(0.75f, 1), new Keyframe(1, 1));

    [SerializeField] private float rotationRate = 3;

    public event Func<bool> onDisableLocomotion;

    public void CharacterAvatar()
    {
        moveInput = Vector3.zero;
        moveRate = walkRate;
    }

    public void CharacterMovement(Vector2 move)
    {
        moveInput = new Vector3(move.x, 0, move.y);
    }

    public void CharacterRun(bool isRunning)
    {
        moveRate = (!isRunning) ? walkRate : runRate;
    }

    public void CharacterTarget(ITarget t)
    {
        target = t;
    }

    public void CharacterActionMovement()
    {
        if (DisableLocomotion()) return;

        Vector3 lastInput = (moveInput.magnitude > 0.1f)
            ? moveInput.normalized
            : -transform.forward;

        StartCoroutine(AnimateLocomotion(lastInput));
    }

    public void CharacterActionForward()
    {
        if (DisableLocomotion()) return;

        StartCoroutine(AnimateLocomotion(transform.forward));
    }

    private void Awake()
    {
        m_charCtrl = GetComponent<CharacterController>();
        m_energySource = GetComponent<IEnergySource>();
        m_animTime = GetComponent<IAnimationTime>();

        moveRate = walkRate;
    }

    private void FixedUpdate()
    {
        m_charCtrl.Move(currentMovement * Time.fixedDeltaTime);

        if (DisableLocomotion()) return;

        UseRunEnergy();

        AdjustDesiredMoevement();
        RotateCharacter();
    }

    private void UseRunEnergy()
    {
        if (moveRate <= walkRate) return;

        m_energySource.ModifyEnergy(runningCost * Time.fixedDeltaTime);
        float adjustedRate = runningCurve.Evaluate(m_energySource.EnergyRatio) * runRate;

        moveRate = Mathf.Clamp(adjustedRate, walkRate, runRate);
    }

    private void AdjustDesiredMoevement()
    {
        desiredMovement = moveRate * moveInput;
        currentMovement = Vector3.Lerp(currentMovement, desiredMovement,
            Time.deltaTime * movementAdjustRate);
    }

    private void RotateCharacter()
    {
        Vector3 desiredLookat = (target != null)
            ? target.Position
            : transform.position + currentMovement;
        Vector3 direction = desiredLookat - transform.position;

        if (direction == Vector3.zero) return;

        float rotationSpeed = moveRate * Time.fixedDeltaTime
            * (rotationRate - (Vector3.Dot(transform.forward, direction.normalized) + 1));

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, rotationSpeed, 0.0f);

        transform.rotation 
            = Quaternion.LookRotation(newDirection);
    }

    private bool DisableLocomotion()
    {
        if(onDisableLocomotion == null) return false;

        Delegate[] methods = onDisableLocomotion.GetInvocationList();
        foreach (Delegate method in methods)
        {
            if (method == null) continue;
            
            bool result = method.DynamicInvoke().ConvertTo<bool>();
            if (result) return true;
        }

        return false;
    }

    IEnumerator AnimateLocomotion(Vector3 directionInput)
    {
        yield return new WaitWhile(() => { return DisableLocomotion(); });

        float duration = m_animTime.CurrentAnimationTime();
        AnimationCurve curve = m_animTime.AnimationCurve;
        float t = 0;

        while (t < 0.95f)
        {
            t += Time.deltaTime / duration;
            float rate = curve.Evaluate(t);

            currentMovement = rate * directionInput;

            yield return null;
        }

        desiredMovement = moveRate * moveInput;
    }
}
