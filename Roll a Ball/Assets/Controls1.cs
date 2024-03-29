//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Controls.inputactions
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

public partial class @Controls1 : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1871d306-6824-4dd5-a151-5a43491e2921"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""1cc5461d-d388-4c8c-ad6c-a432f998c270"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pan Left"",
                    ""type"": ""Button"",
                    ""id"": ""8835585b-be37-46af-9f52-96fc648ff113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pan Right"",
                    ""type"": ""Button"",
                    ""id"": ""45304b5a-2d4f-4efe-b7df-be05f0b2ee28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d8a92747-18e3-4a3a-b888-4c56e6069e6a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d960f7-b3f3-4859-93fe-2125fa9cd759"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06ea7ac7-ad80-470c-a421-2d57b3cbcb5d"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47b5a894-05e1-4ac7-aa9e-88a93a806d3b"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5a66df8-dc70-4833-887e-0e46bdd5e523"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c4106b9-ebdd-42e4-98d2-e55779661ec1"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pan Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_PanLeft = m_Player.FindAction("Pan Left", throwIfNotFound: true);
        m_Player_PanRight = m_Player.FindAction("Pan Right", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_PanLeft;
    private readonly InputAction m_Player_PanRight;
    public struct PlayerActions
    {
        private @Controls1 m_Wrapper;
        public PlayerActions(@Controls1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @PanLeft => m_Wrapper.m_Player_PanLeft;
        public InputAction @PanRight => m_Wrapper.m_Player_PanRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @PanLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanLeft;
                @PanLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanLeft;
                @PanLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanLeft;
                @PanRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanRight;
                @PanRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanRight;
                @PanRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPanRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @PanLeft.started += instance.OnPanLeft;
                @PanLeft.performed += instance.OnPanLeft;
                @PanLeft.canceled += instance.OnPanLeft;
                @PanRight.started += instance.OnPanRight;
                @PanRight.performed += instance.OnPanRight;
                @PanRight.canceled += instance.OnPanRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMenu(InputAction.CallbackContext context);
        void OnPanLeft(InputAction.CallbackContext context);
        void OnPanRight(InputAction.CallbackContext context);
    }
}
