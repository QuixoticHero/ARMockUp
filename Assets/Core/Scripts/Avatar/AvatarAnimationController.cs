using System;
using UnityEngine;

public class AvatarAnimationController : MonoBehaviour, IAnimationTime
{
    private Animator m_anim;

    private Vector3 lastPosition;

    private float forwardRate;
    private float leftRate;

    private int targetAnimation;
    private AnimationCurve targetCurve;

    private int m_idForward = Animator.StringToHash("ForwardRate");
    private int m_idLeft = Animator.StringToHash("LeftRate");

    public int AnimationStateHash { set => targetAnimation = value; }
    public AnimationCurve AnimationCurve { get => targetCurve; set => targetCurve = value; }

    public float CurrentAnimationTime()
    {
        if(m_anim.GetNextAnimatorStateInfo(0).fullPathHash == targetAnimation)
        {
            return m_anim.GetNextAnimatorStateInfo(0).length;
        }

        return m_anim.GetCurrentAnimatorStateInfo(0).length;
    }

    void Awake()
    {
        m_anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Vector3 horizontalVelocity = (transform.position - lastPosition) / Time.fixedDeltaTime;
        float verticalSpeed = horizontalVelocity.y;

        horizontalVelocity.y = 0f;
        float horizontalSpeed = horizontalVelocity.magnitude;

        forwardRate = Vector3.Dot(transform.forward, horizontalVelocity) * horizontalSpeed;
        leftRate = Vector3.Dot(-transform.right, horizontalVelocity) * horizontalSpeed;

        lastPosition = transform.position;
    }

    private void LateUpdate()
    {
        m_anim.SetFloat(m_idForward, forwardRate);
        m_anim.SetFloat(m_idLeft, leftRate);
    }
}
