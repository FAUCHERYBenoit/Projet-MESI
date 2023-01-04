//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scenes/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMouvement"",
            ""id"": ""c65a77c5-c2e2-464b-8171-34e8df8ee6fc"",
            ""actions"": [
                {
                    ""name"": ""Mouvement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""724fa12b-9f72-43a0-a668-cd70e66ec9d9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d4285834-b353-43fa-81d1-6a850e64ce39"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouvement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84945a8b-df3c-4976-8646-3ac3e09cbc10"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed7837d5-16f9-4788-964b-65aead71550b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8588a230-2649-4bfe-92ed-61e4e951eb82"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""66482586-b8e7-4874-89be-cb289c24affd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MouseActions"",
            ""id"": ""57defe5a-cd60-4dfc-bc0e-d3bae3805713"",
            ""actions"": [
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Value"",
                    ""id"": ""2bc0befd-9b8b-4d6c-ab2f-f3b1956270e1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""5c074d59-070d-46fe-8fd5-2a2d53bcdcad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""327795fe-d6fa-485c-9dd1-9976e716b328"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b417bcb-0292-4831-8316-f9b94522088b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fb74755-8355-468e-bc0b-5f74d2eff6b4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""461ff72b-ea74-4166-917e-3b625023e195"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardActions"",
            ""id"": ""f24fd615-1230-4f06-b021-f00ce678e9a1"",
            ""actions"": [
                {
                    ""name"": ""InteractionAction"",
                    ""type"": ""Button"",
                    ""id"": ""262b0760-231d-4719-917f-ea963e303528"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RelaodAction"",
                    ""type"": ""Button"",
                    ""id"": ""e3d48dc9-3e4c-4517-bfe8-69c70397f60c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InventoryAction"",
                    ""type"": ""Button"",
                    ""id"": ""b7e22006-7c2f-4082-8ee0-ac88067c34c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SkillTreeAction"",
                    ""type"": ""Button"",
                    ""id"": ""5fa677a9-6ff8-4be0-8ed6-947166278548"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MapAction"",
                    ""type"": ""Button"",
                    ""id"": ""fd3c0e1c-b566-4702-bb1e-5d187be2aecd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItemAction"",
                    ""type"": ""Button"",
                    ""id"": ""757ca6a5-c082-4214-9629-edcb597cc22c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DashAction"",
                    ""type"": ""Button"",
                    ""id"": ""9c88ec5a-f07c-4b05-982e-57f0259966af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""69ec5bf9-fbd5-4c75-8983-469627f3566c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteractionAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68278f86-10f6-4d0c-b45f-61aa40ffad6f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RelaodAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d94a9f96-f867-470c-8925-6cfa0bc6dca3"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe160f9e-e01b-4444-b1e0-51fb891ab1d8"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb87a99f-8b67-4046-8390-6f9442e79baa"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkillTreeAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18752465-15c5-45b1-9329-c811c22e3116"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItemAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30b16162-293b-4ea3-b4f5-e204dfd79039"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMouvement
        m_PlayerMouvement = asset.FindActionMap("PlayerMouvement", throwIfNotFound: true);
        m_PlayerMouvement_Mouvement = m_PlayerMouvement.FindAction("Mouvement", throwIfNotFound: true);
        // MouseActions
        m_MouseActions = asset.FindActionMap("MouseActions", throwIfNotFound: true);
        m_MouseActions_PrimaryButton = m_MouseActions.FindAction("PrimaryButton", throwIfNotFound: true);
        m_MouseActions_SecondaryButton = m_MouseActions.FindAction("SecondaryButton", throwIfNotFound: true);
        m_MouseActions_MouseWheel = m_MouseActions.FindAction("MouseWheel", throwIfNotFound: true);
        // KeyboardActions
        m_KeyboardActions = asset.FindActionMap("KeyboardActions", throwIfNotFound: true);
        m_KeyboardActions_InteractionAction = m_KeyboardActions.FindAction("InteractionAction", throwIfNotFound: true);
        m_KeyboardActions_RelaodAction = m_KeyboardActions.FindAction("RelaodAction", throwIfNotFound: true);
        m_KeyboardActions_InventoryAction = m_KeyboardActions.FindAction("InventoryAction", throwIfNotFound: true);
        m_KeyboardActions_SkillTreeAction = m_KeyboardActions.FindAction("SkillTreeAction", throwIfNotFound: true);
        m_KeyboardActions_MapAction = m_KeyboardActions.FindAction("MapAction", throwIfNotFound: true);
        m_KeyboardActions_UseItemAction = m_KeyboardActions.FindAction("UseItemAction", throwIfNotFound: true);
        m_KeyboardActions_DashAction = m_KeyboardActions.FindAction("DashAction", throwIfNotFound: true);
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

    // PlayerMouvement
    private readonly InputActionMap m_PlayerMouvement;
    private IPlayerMouvementActions m_PlayerMouvementActionsCallbackInterface;
    private readonly InputAction m_PlayerMouvement_Mouvement;
    public struct PlayerMouvementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMouvementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouvement => m_Wrapper.m_PlayerMouvement_Mouvement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMouvement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMouvementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMouvementActions instance)
        {
            if (m_Wrapper.m_PlayerMouvementActionsCallbackInterface != null)
            {
                @Mouvement.started -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMouvement;
                @Mouvement.performed -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMouvement;
                @Mouvement.canceled -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMouvement;
            }
            m_Wrapper.m_PlayerMouvementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouvement.started += instance.OnMouvement;
                @Mouvement.performed += instance.OnMouvement;
                @Mouvement.canceled += instance.OnMouvement;
            }
        }
    }
    public PlayerMouvementActions @PlayerMouvement => new PlayerMouvementActions(this);

    // MouseActions
    private readonly InputActionMap m_MouseActions;
    private IMouseActionsActions m_MouseActionsActionsCallbackInterface;
    private readonly InputAction m_MouseActions_PrimaryButton;
    private readonly InputAction m_MouseActions_SecondaryButton;
    private readonly InputAction m_MouseActions_MouseWheel;
    public struct MouseActionsActions
    {
        private @PlayerControls m_Wrapper;
        public MouseActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryButton => m_Wrapper.m_MouseActions_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_MouseActions_SecondaryButton;
        public InputAction @MouseWheel => m_Wrapper.m_MouseActions_MouseWheel;
        public InputActionMap Get() { return m_Wrapper.m_MouseActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActionsActions instance)
        {
            if (m_Wrapper.m_MouseActionsActionsCallbackInterface != null)
            {
                @PrimaryButton.started -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.performed -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.canceled -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnPrimaryButton;
                @SecondaryButton.started -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.performed -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.canceled -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnSecondaryButton;
                @MouseWheel.started -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.performed -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouseWheel;
                @MouseWheel.canceled -= m_Wrapper.m_MouseActionsActionsCallbackInterface.OnMouseWheel;
            }
            m_Wrapper.m_MouseActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryButton.started += instance.OnPrimaryButton;
                @PrimaryButton.performed += instance.OnPrimaryButton;
                @PrimaryButton.canceled += instance.OnPrimaryButton;
                @SecondaryButton.started += instance.OnSecondaryButton;
                @SecondaryButton.performed += instance.OnSecondaryButton;
                @SecondaryButton.canceled += instance.OnSecondaryButton;
                @MouseWheel.started += instance.OnMouseWheel;
                @MouseWheel.performed += instance.OnMouseWheel;
                @MouseWheel.canceled += instance.OnMouseWheel;
            }
        }
    }
    public MouseActionsActions @MouseActions => new MouseActionsActions(this);

    // KeyboardActions
    private readonly InputActionMap m_KeyboardActions;
    private IKeyboardActionsActions m_KeyboardActionsActionsCallbackInterface;
    private readonly InputAction m_KeyboardActions_InteractionAction;
    private readonly InputAction m_KeyboardActions_RelaodAction;
    private readonly InputAction m_KeyboardActions_InventoryAction;
    private readonly InputAction m_KeyboardActions_SkillTreeAction;
    private readonly InputAction m_KeyboardActions_MapAction;
    private readonly InputAction m_KeyboardActions_UseItemAction;
    private readonly InputAction m_KeyboardActions_DashAction;
    public struct KeyboardActionsActions
    {
        private @PlayerControls m_Wrapper;
        public KeyboardActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @InteractionAction => m_Wrapper.m_KeyboardActions_InteractionAction;
        public InputAction @RelaodAction => m_Wrapper.m_KeyboardActions_RelaodAction;
        public InputAction @InventoryAction => m_Wrapper.m_KeyboardActions_InventoryAction;
        public InputAction @SkillTreeAction => m_Wrapper.m_KeyboardActions_SkillTreeAction;
        public InputAction @MapAction => m_Wrapper.m_KeyboardActions_MapAction;
        public InputAction @UseItemAction => m_Wrapper.m_KeyboardActions_UseItemAction;
        public InputAction @DashAction => m_Wrapper.m_KeyboardActions_DashAction;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActionsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActionsActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsActionsCallbackInterface != null)
            {
                @InteractionAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInteractionAction;
                @InteractionAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInteractionAction;
                @InteractionAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInteractionAction;
                @RelaodAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnRelaodAction;
                @RelaodAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnRelaodAction;
                @RelaodAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnRelaodAction;
                @InventoryAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInventoryAction;
                @InventoryAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInventoryAction;
                @InventoryAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnInventoryAction;
                @SkillTreeAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnSkillTreeAction;
                @SkillTreeAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnSkillTreeAction;
                @SkillTreeAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnSkillTreeAction;
                @MapAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnMapAction;
                @MapAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnMapAction;
                @MapAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnMapAction;
                @UseItemAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnUseItemAction;
                @UseItemAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnUseItemAction;
                @UseItemAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnUseItemAction;
                @DashAction.started -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnDashAction;
                @DashAction.performed -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnDashAction;
                @DashAction.canceled -= m_Wrapper.m_KeyboardActionsActionsCallbackInterface.OnDashAction;
            }
            m_Wrapper.m_KeyboardActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InteractionAction.started += instance.OnInteractionAction;
                @InteractionAction.performed += instance.OnInteractionAction;
                @InteractionAction.canceled += instance.OnInteractionAction;
                @RelaodAction.started += instance.OnRelaodAction;
                @RelaodAction.performed += instance.OnRelaodAction;
                @RelaodAction.canceled += instance.OnRelaodAction;
                @InventoryAction.started += instance.OnInventoryAction;
                @InventoryAction.performed += instance.OnInventoryAction;
                @InventoryAction.canceled += instance.OnInventoryAction;
                @SkillTreeAction.started += instance.OnSkillTreeAction;
                @SkillTreeAction.performed += instance.OnSkillTreeAction;
                @SkillTreeAction.canceled += instance.OnSkillTreeAction;
                @MapAction.started += instance.OnMapAction;
                @MapAction.performed += instance.OnMapAction;
                @MapAction.canceled += instance.OnMapAction;
                @UseItemAction.started += instance.OnUseItemAction;
                @UseItemAction.performed += instance.OnUseItemAction;
                @UseItemAction.canceled += instance.OnUseItemAction;
                @DashAction.started += instance.OnDashAction;
                @DashAction.performed += instance.OnDashAction;
                @DashAction.canceled += instance.OnDashAction;
            }
        }
    }
    public KeyboardActionsActions @KeyboardActions => new KeyboardActionsActions(this);
    public interface IPlayerMouvementActions
    {
        void OnMouvement(InputAction.CallbackContext context);
    }
    public interface IMouseActionsActions
    {
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnMouseWheel(InputAction.CallbackContext context);
    }
    public interface IKeyboardActionsActions
    {
        void OnInteractionAction(InputAction.CallbackContext context);
        void OnRelaodAction(InputAction.CallbackContext context);
        void OnInventoryAction(InputAction.CallbackContext context);
        void OnSkillTreeAction(InputAction.CallbackContext context);
        void OnMapAction(InputAction.CallbackContext context);
        void OnUseItemAction(InputAction.CallbackContext context);
        void OnDashAction(InputAction.CallbackContext context);
    }
}
