using ScriptableObjectArchitecture;
using System.Collections;
using UnityEngine;

using UnityEngine.InputSystem;

public class PlayerUI : MonoBehaviour
{
    private PlayerUISystem input;

    [SerializeField] private Vector2Variable characterMovementVariable;
    [SerializeField] private BoolVariable characterRunVariable;
    [SerializeField] private GameEvent characterEvadeGameEvent;

    [SerializeField] private GameEvent characterAttackHeavyGameEvent;
    [SerializeField] private GameEvent characterAttackLightGameEvent;

    [SerializeField] private ITargetVariable characterTargetVariable;
    [SerializeField] private ITargetVariable possibleTargetVariable;

    [SerializeField] private IAvatarStatsVariable characterAvatarStatsVarable;
    [SerializeField] private IAvatarVariable characterAvatarVariable;
    [SerializeField] private IAvatarVariable possibleAvatarVariable;

    private Coroutine coMovement = null;

    public void CharacterAvatarStats(IAvatar avatar)
    {
        characterAvatarStatsVarable.Value = (avatar != null) ? avatar.AvatarStats : null;
    }

    private void Awake()
    {
        input = new PlayerUISystem();

        input.CharacterControls.Movement.performed
            += cxt => { if (coMovement == null) coMovement = StartCoroutine(CoEnableMovement()); };

        input.CharacterControls.Run.performed
            += cxt => characterRunVariable.Value = cxt.ReadValueAsButton();

        input.CharacterControls.Evade.performed
            += cxt => characterEvadeGameEvent.Raise();

        input.CharacterControls.AttackHeavy.performed
            += cxt => characterAttackHeavyGameEvent.Raise();

        input.CharacterControls.AttackLight.performed
            += cxt => characterAttackLightGameEvent.Raise();

        input.CharacterControls.ToggleTarget.performed
            += cxt => ToggleCharacterTarget();

        input.CharacterControls.ReleaseTarget.performed
            += cxt => characterTargetVariable.Value = null;

        input.CharacterControls.SetAvatar.performed
            += cxt => SetCharacterAvtar();

        input.CharacterControls.DebugNoAvatar.performed
            += cxt => 
            { 
                characterAvatarVariable.Value = null;
                characterAvatarStatsVarable.Value = null;
            };
    }

    private void OnEnable()
    {
        input.CharacterControls.Enable();
    }

    private void OnDisable()
    {
        input.CharacterControls.Disable();
    }

    private IEnumerator CoEnableMovement()
    {
        while (input.CharacterControls.Movement.phase != InputActionPhase.Canceled) 
        {
            characterMovementVariable.Value
                = input.CharacterControls.Movement.ReadValue<Vector2>();
            yield return null;
        }

        characterMovementVariable.Value = Vector2.zero;
        coMovement = null;
    }

    private void ToggleCharacterTarget()
    {
        if (characterTargetVariable.Value != null  && possibleTargetVariable.Value != null 
        && characterTargetVariable.Value != possibleTargetVariable.Value)
        {
            characterTargetVariable.Value = possibleTargetVariable.Value;
        }
        else if (characterTargetVariable.Value != null)
        {
            characterTargetVariable.Value = null;
        }
        else if (possibleTargetVariable.Value != null)
        {
            characterTargetVariable.Value = possibleTargetVariable.Value;
        }
    }

    private void SetCharacterAvtar()
    {
        if (possibleAvatarVariable.Value != null
        && characterAvatarVariable.Value != possibleAvatarVariable.Value)
        {
            characterAvatarVariable.Value = possibleAvatarVariable.Value;
        }
    }
}
