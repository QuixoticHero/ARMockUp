//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Core/Settings/PlayerUISystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerUISystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerUISystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerUISystem"",
    ""maps"": [
        {
            ""name"": ""CharacterControls"",
            ""id"": ""93f483bb-ba12-406e-a7ef-43a1d5d8b75a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f6d9efdb-0bdb-4042-8c26-c7d9b449697b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""261ebba8-c91b-4d48-9a30-27781527fd76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9960c392-92b2-40cf-9eab-c380c0cb5380"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Evade"",
                    ""type"": ""Button"",
                    ""id"": ""40970bcd-c91d-491a-aa21-509251f05c69"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackHeavy"",
                    ""type"": ""Button"",
                    ""id"": ""291a0706-107a-4d26-a8f6-84fc9a88467d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AttackLight"",
                    ""type"": ""Button"",
                    ""id"": ""74eb9530-9f1f-4497-8228-27705e9fbc64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleTarget"",
                    ""type"": ""Button"",
                    ""id"": ""10875752-0d0c-4b98-a670-5e58b8df8293"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReleaseTarget"",
                    ""type"": ""Button"",
                    ""id"": ""42c534b2-2290-489e-8ec4-00e09117d258"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SetAvatar"",
                    ""type"": ""Button"",
                    ""id"": ""18a0305d-3d75-4b75-adce-99858ee1988f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DebugNoAvatar"",
                    ""type"": ""Button"",
                    ""id"": ""39eac0cb-2553-476f-ab34-3152fa1c1967"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c60c96e8-49c0-4e26-820c-09654058257c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b33d37fb-de9e-453f-8371-3f56e20a4f19"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""107282ab-5691-47d3-bc7f-e71ae3e34bcc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""810e21d0-6538-4416-8d90-2bf50267a6fa"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd4c41fe-3fc2-46b1-8b74-c3a9d84f28d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Evade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe3f87d0-1a23-4867-bcd3-5cd8695e8b10"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f2ea8c8-1d0c-4975-9ad3-dea14c00b20c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackHeavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97f689a0-35bf-4d21-ba34-a6f279be5485"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""393504e3-5e93-4ec3-8894-8b5f0c48b833"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f19f7348-95c3-42de-a807-2c4d8180b83d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0db5bd2-2f5e-4772-b989-37907db83cde"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6870fd6e-c87f-40af-b223-07722410d3ee"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93b41df7-7e9f-4875-8128-7d0361021730"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetAvatar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f94e6454-905e-42ba-b2be-bc6d801c2f2d"",
                    ""path"": ""<Keyboard>/f12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DebugNoAvatar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterControls
        m_CharacterControls = asset.FindActionMap("CharacterControls", throwIfNotFound: true);
        m_CharacterControls_Movement = m_CharacterControls.FindAction("Movement", throwIfNotFound: true);
        m_CharacterControls_Run = m_CharacterControls.FindAction("Run", throwIfNotFound: true);
        m_CharacterControls_Jump = m_CharacterControls.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControls_Evade = m_CharacterControls.FindAction("Evade", throwIfNotFound: true);
        m_CharacterControls_AttackHeavy = m_CharacterControls.FindAction("AttackHeavy", throwIfNotFound: true);
        m_CharacterControls_AttackLight = m_CharacterControls.FindAction("AttackLight", throwIfNotFound: true);
        m_CharacterControls_ToggleTarget = m_CharacterControls.FindAction("ToggleTarget", throwIfNotFound: true);
        m_CharacterControls_ReleaseTarget = m_CharacterControls.FindAction("ReleaseTarget", throwIfNotFound: true);
        m_CharacterControls_SetAvatar = m_CharacterControls.FindAction("SetAvatar", throwIfNotFound: true);
        m_CharacterControls_DebugNoAvatar = m_CharacterControls.FindAction("DebugNoAvatar", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterControls
    private readonly InputActionMap m_CharacterControls;
    private ICharacterControlsActions m_CharacterControlsActionsCallbackInterface;
    private readonly InputAction m_CharacterControls_Movement;
    private readonly InputAction m_CharacterControls_Run;
    private readonly InputAction m_CharacterControls_Jump;
    private readonly InputAction m_CharacterControls_Evade;
    private readonly InputAction m_CharacterControls_AttackHeavy;
    private readonly InputAction m_CharacterControls_AttackLight;
    private readonly InputAction m_CharacterControls_ToggleTarget;
    private readonly InputAction m_CharacterControls_ReleaseTarget;
    private readonly InputAction m_CharacterControls_SetAvatar;
    private readonly InputAction m_CharacterControls_DebugNoAvatar;
    public struct CharacterControlsActions
    {
        private @PlayerUISystem m_Wrapper;
        public CharacterControlsActions(@PlayerUISystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CharacterControls_Movement;
        public InputAction @Run => m_Wrapper.m_CharacterControls_Run;
        public InputAction @Jump => m_Wrapper.m_CharacterControls_Jump;
        public InputAction @Evade => m_Wrapper.m_CharacterControls_Evade;
        public InputAction @AttackHeavy => m_Wrapper.m_CharacterControls_AttackHeavy;
        public InputAction @AttackLight => m_Wrapper.m_CharacterControls_AttackLight;
        public InputAction @ToggleTarget => m_Wrapper.m_CharacterControls_ToggleTarget;
        public InputAction @ReleaseTarget => m_Wrapper.m_CharacterControls_ReleaseTarget;
        public InputAction @SetAvatar => m_Wrapper.m_CharacterControls_SetAvatar;
        public InputAction @DebugNoAvatar => m_Wrapper.m_CharacterControls_DebugNoAvatar;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlsActions instance)
        {
            if (m_Wrapper.m_CharacterControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnJump;
                @Evade.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnEvade;
                @Evade.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnEvade;
                @Evade.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnEvade;
                @AttackHeavy.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackHeavy;
                @AttackHeavy.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackHeavy;
                @AttackHeavy.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackHeavy;
                @AttackLight.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackLight;
                @AttackLight.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackLight;
                @AttackLight.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttackLight;
                @ToggleTarget.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnToggleTarget;
                @ToggleTarget.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnToggleTarget;
                @ToggleTarget.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnToggleTarget;
                @ReleaseTarget.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnReleaseTarget;
                @ReleaseTarget.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnReleaseTarget;
                @ReleaseTarget.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnReleaseTarget;
                @SetAvatar.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnSetAvatar;
                @SetAvatar.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnSetAvatar;
                @SetAvatar.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnSetAvatar;
                @DebugNoAvatar.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnDebugNoAvatar;
                @DebugNoAvatar.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnDebugNoAvatar;
                @DebugNoAvatar.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnDebugNoAvatar;
            }
            m_Wrapper.m_CharacterControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Evade.started += instance.OnEvade;
                @Evade.performed += instance.OnEvade;
                @Evade.canceled += instance.OnEvade;
                @AttackHeavy.started += instance.OnAttackHeavy;
                @AttackHeavy.performed += instance.OnAttackHeavy;
                @AttackHeavy.canceled += instance.OnAttackHeavy;
                @AttackLight.started += instance.OnAttackLight;
                @AttackLight.performed += instance.OnAttackLight;
                @AttackLight.canceled += instance.OnAttackLight;
                @ToggleTarget.started += instance.OnToggleTarget;
                @ToggleTarget.performed += instance.OnToggleTarget;
                @ToggleTarget.canceled += instance.OnToggleTarget;
                @ReleaseTarget.started += instance.OnReleaseTarget;
                @ReleaseTarget.performed += instance.OnReleaseTarget;
                @ReleaseTarget.canceled += instance.OnReleaseTarget;
                @SetAvatar.started += instance.OnSetAvatar;
                @SetAvatar.performed += instance.OnSetAvatar;
                @SetAvatar.canceled += instance.OnSetAvatar;
                @DebugNoAvatar.started += instance.OnDebugNoAvatar;
                @DebugNoAvatar.performed += instance.OnDebugNoAvatar;
                @DebugNoAvatar.canceled += instance.OnDebugNoAvatar;
            }
        }
    }
    public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);
    public interface ICharacterControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEvade(InputAction.CallbackContext context);
        void OnAttackHeavy(InputAction.CallbackContext context);
        void OnAttackLight(InputAction.CallbackContext context);
        void OnToggleTarget(InputAction.CallbackContext context);
        void OnReleaseTarget(InputAction.CallbackContext context);
        void OnSetAvatar(InputAction.CallbackContext context);
        void OnDebugNoAvatar(InputAction.CallbackContext context);
    }
}
