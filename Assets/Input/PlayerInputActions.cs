// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player1Actions"",
            ""id"": ""a996ed18-03c2-4e71-a03b-fec79b906a39"",
            ""actions"": [
                {
                    ""name"": ""Pulse"",
                    ""type"": ""Button"",
                    ""id"": ""64810467-3d89-44eb-81f2-3f06bd268147"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PowerUp"",
                    ""type"": ""Button"",
                    ""id"": ""5f9e4b4f-43af-4a34-8782-81f44e0f7422"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89bc0b2c-476b-4105-81fd-af156adf04a4"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d6c1f1b-597f-4c97-8317-092ce34cd009"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c14b656-e0ed-4948-9708-20f6d8c9215d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e93df67-af71-44ba-aa10-481bf9b054da"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2Actions"",
            ""id"": ""52b64490-5294-4b67-baa7-dbaf458d1b7b"",
            ""actions"": [
                {
                    ""name"": ""Pulse"",
                    ""type"": ""Button"",
                    ""id"": ""73ab53c9-8e73-4d28-ab35-5d4554dc4d11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PowerUp"",
                    ""type"": ""Button"",
                    ""id"": ""39d2095c-2c9f-4468-8fbd-09bdca1ab9a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91804bfb-6287-4a28-93c6-37aa33ce8fdd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""813959e6-f710-4f90-a86f-f69d285ac1db"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94b1ce85-1037-45b6-89c2-2e31eed57f0e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e0c0d79-9c54-4214-927b-8d7ad0239499"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""63971834-6b45-424b-a827-59b93cc05c2e"",
            ""actions"": [
                {
                    ""name"": ""Player1Move"",
                    ""type"": ""Value"",
                    ""id"": ""89866045-f4a3-4b81-91a2-a469b86f1ccd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player2Move"",
                    ""type"": ""Value"",
                    ""id"": ""8a340070-6910-4bcf-b823-5ca343501625"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c828a10-2b7e-4696-a9ee-6338b38c4cbb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a621b74-9b7c-447f-a5b9-446103fbc895"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72b3430a-7f8d-4269-a144-437a09afac51"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06ae0f1c-3011-4798-a82a-039c457945f3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0705c6a-f6a2-4bb6-86d5-a911b7860d1f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9fe97d70-9a6a-4490-8c37-e9e6901fb51e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""e37c4ba5-e1dd-4fc9-a572-0e87d8f11776"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14dfeaf7-493f-4316-943e-9d89c00bcccd"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""db858273-df0d-468a-b152-479d4d674d89"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d9ff697-766e-473c-974c-c2c4a152cd36"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fc8c8c42-9221-4e99-8e39-6d68efbbbf6b"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8d378c7-256a-42d2-abd5-2538652c2d84"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d02b7bc7-3f5e-4cc6-b9b8-dcb952711d81"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Actions
        m_Player1Actions = asset.FindActionMap("Player1Actions", throwIfNotFound: true);
        m_Player1Actions_Pulse = m_Player1Actions.FindAction("Pulse", throwIfNotFound: true);
        m_Player1Actions_PowerUp = m_Player1Actions.FindAction("PowerUp", throwIfNotFound: true);
        // Player2Actions
        m_Player2Actions = asset.FindActionMap("Player2Actions", throwIfNotFound: true);
        m_Player2Actions_Pulse = m_Player2Actions.FindAction("Pulse", throwIfNotFound: true);
        m_Player2Actions_PowerUp = m_Player2Actions.FindAction("PowerUp", throwIfNotFound: true);
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Player1Move = m_PlayerMovement.FindAction("Player1Move", throwIfNotFound: true);
        m_PlayerMovement_Player2Move = m_PlayerMovement.FindAction("Player2Move", throwIfNotFound: true);
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

    // Player1Actions
    private readonly InputActionMap m_Player1Actions;
    private IPlayer1ActionsActions m_Player1ActionsActionsCallbackInterface;
    private readonly InputAction m_Player1Actions_Pulse;
    private readonly InputAction m_Player1Actions_PowerUp;
    public struct Player1ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public Player1ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pulse => m_Wrapper.m_Player1Actions_Pulse;
        public InputAction @PowerUp => m_Wrapper.m_Player1Actions_PowerUp;
        public InputActionMap Get() { return m_Wrapper.m_Player1Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1ActionsActions instance)
        {
            if (m_Wrapper.m_Player1ActionsActionsCallbackInterface != null)
            {
                @Pulse.started -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @Pulse.performed -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @Pulse.canceled -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @PowerUp.started -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.performed -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.canceled -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
            }
            m_Wrapper.m_Player1ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pulse.started += instance.OnPulse;
                @Pulse.performed += instance.OnPulse;
                @Pulse.canceled += instance.OnPulse;
                @PowerUp.started += instance.OnPowerUp;
                @PowerUp.performed += instance.OnPowerUp;
                @PowerUp.canceled += instance.OnPowerUp;
            }
        }
    }
    public Player1ActionsActions @Player1Actions => new Player1ActionsActions(this);

    // Player2Actions
    private readonly InputActionMap m_Player2Actions;
    private IPlayer2ActionsActions m_Player2ActionsActionsCallbackInterface;
    private readonly InputAction m_Player2Actions_Pulse;
    private readonly InputAction m_Player2Actions_PowerUp;
    public struct Player2ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public Player2ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pulse => m_Wrapper.m_Player2Actions_Pulse;
        public InputAction @PowerUp => m_Wrapper.m_Player2Actions_PowerUp;
        public InputActionMap Get() { return m_Wrapper.m_Player2Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2ActionsActions instance)
        {
            if (m_Wrapper.m_Player2ActionsActionsCallbackInterface != null)
            {
                @Pulse.started -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @Pulse.performed -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @Pulse.canceled -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @PowerUp.started -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.performed -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.canceled -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
            }
            m_Wrapper.m_Player2ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pulse.started += instance.OnPulse;
                @Pulse.performed += instance.OnPulse;
                @Pulse.canceled += instance.OnPulse;
                @PowerUp.started += instance.OnPowerUp;
                @PowerUp.performed += instance.OnPowerUp;
                @PowerUp.canceled += instance.OnPowerUp;
            }
        }
    }
    public Player2ActionsActions @Player2Actions => new Player2ActionsActions(this);

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Player1Move;
    private readonly InputAction m_PlayerMovement_Player2Move;
    public struct PlayerMovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerMovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1Move => m_Wrapper.m_PlayerMovement_Player1Move;
        public InputAction @Player2Move => m_Wrapper.m_PlayerMovement_Player2Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Player1Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player2Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1Move.started += instance.OnPlayer1Move;
                @Player1Move.performed += instance.OnPlayer1Move;
                @Player1Move.canceled += instance.OnPlayer1Move;
                @Player2Move.started += instance.OnPlayer2Move;
                @Player2Move.performed += instance.OnPlayer2Move;
                @Player2Move.canceled += instance.OnPlayer2Move;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    public interface IPlayer1ActionsActions
    {
        void OnPulse(InputAction.CallbackContext context);
        void OnPowerUp(InputAction.CallbackContext context);
    }
    public interface IPlayer2ActionsActions
    {
        void OnPulse(InputAction.CallbackContext context);
        void OnPowerUp(InputAction.CallbackContext context);
    }
    public interface IPlayerMovementActions
    {
        void OnPlayer1Move(InputAction.CallbackContext context);
        void OnPlayer2Move(InputAction.CallbackContext context);
    }
}
