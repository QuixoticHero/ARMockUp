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

    [SerializeField] private ITargetVariable selectedTargetVariable;
    [SerializeField] private ITargetVariable highlightedTargetVariable;

    [SerializeField] private IAvatarStatsVariable selectedAvatarStatsVarable;
    [SerializeField] private IAvatarVariable selectedAvatarVariable;
    [SerializeField] private ITargetVariable selectedTargetAvatarVariable;
    [SerializeField] private ITargetVariable highlightedAvatarVariable;
    [SerializeField] private AvatarDatabase avatarDatabase;

    private Coroutine coMovement = null;

    public void CharacterAvatarStats(IAvatar avatar)
    {
        selectedAvatarStatsVarable.Value = (avatar != null) ? avatar.AvatarStats : null;
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
            += cxt => selectedTargetVariable.Value = null;

        input.CharacterControls.SetAvatar.performed
            += cxt => SetCharacterAvtar();

        input.CharacterControls.DebugNoAvatar.performed
            += cxt => 
            {
                selectedAvatarVariable.Value = null;
                selectedAvatarStatsVarable.Value = null;
                selectedTargetAvatarVariable.Value = null;
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
        if (selectedTargetVariable.Value != null  && highlightedTargetVariable.Value != null 
        && selectedTargetVariable.Value != highlightedTargetVariable.Value)
        {
            selectedTargetVariable.Value = highlightedTargetVariable.Value;
        }
        else if (selectedTargetVariable.Value != null)
        {
            selectedTargetVariable.Value = null;
        }
        else if (highlightedTargetVariable.Value != null)
        {
            selectedTargetVariable.Value = highlightedTargetVariable.Value;
        }
    }

    private void SetCharacterAvtar()
    {
        if (highlightedAvatarVariable.Value != null
        && selectedTargetAvatarVariable.Value != highlightedAvatarVariable.Value)
        {
            selectedTargetAvatarVariable.Value = highlightedAvatarVariable.Value;
            selectedAvatarVariable.Value = avatarDatabase.GetAvatar(selectedTargetAvatarVariable.Value);
        }
    }
}
