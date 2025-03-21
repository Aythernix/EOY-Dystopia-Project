//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Game Management/Game Inputs/InputMap.inputactions
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

public partial class @InputMap: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""CCTV Camera"",
            ""id"": ""02f0e4e9-07de-456e-9c81-03d08578df87"",
            ""actions"": [
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""Value"",
                    ""id"": ""44c2fd49-01a8-4629-a51f-cb756813987b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turret Fire"",
                    ""type"": ""Value"",
                    ""id"": ""bb618977-7537-464a-a008-b3052f1187de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turret Aim"",
                    ""type"": ""Value"",
                    ""id"": ""2f98312e-b907-483b-a0ed-49323f117060"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turret Reload"",
                    ""type"": ""Button"",
                    ""id"": ""0c950b41-c04c-490d-8cda-4990233eeb0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7ecb82e2-0fe2-4562-bee8-a02ffdb2472b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6761ae62-88f5-4360-83a0-b153ec89dba3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""816f0625-5bfd-4570-9339-80d9fe2f4838"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""886bac2f-c828-4447-bc85-032ef75ed030"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f2f36be5-c93f-4f90-91da-1e6264f801b3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7dc5956e-9aaa-4f95-b104-44c39fec8460"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73e5a8a6-b9b0-4d79-a5dc-4caa32710fe8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35cbc369-1eea-4e93-9592-759fbf6c7149"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""6122b103-afd8-4c22-8c37-75c093e9e0e7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d15c85a3-2f5c-4ab7-bb75-6ff6ecd0beae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""57741ae8-e782-41b5-b732-d54565ee078a"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9a8d41c5-4759-4c3a-b615-00453a4c19ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b3ad4ab6-1bbd-47ab-9fb8-ad334942d379"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""57a76da2-9954-4a88-aa15-54238a4121c0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""36e7dc04-23e7-4b7a-b682-039a4496069d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""192b979c-6f88-4429-9c2b-5a39e03735c8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""7ebde9d4-1a9e-4a8d-acf0-9f17089bf4ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57b10c23-f0d1-429c-b6d5-85a9cf27ddcf"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default Controls"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c71905d8-736f-4345-ae17-724995307ec4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default Controls"",
            ""bindingGroup"": ""Default Controls"",
            ""devices"": []
        }
    ]
}");
        // CCTV Camera
        m_CCTVCamera = asset.FindActionMap("CCTV Camera", throwIfNotFound: true);
        m_CCTVCamera_CameraMovement = m_CCTVCamera.FindAction("Camera Movement", throwIfNotFound: true);
        m_CCTVCamera_TurretFire = m_CCTVCamera.FindAction("Turret Fire", throwIfNotFound: true);
        m_CCTVCamera_TurretAim = m_CCTVCamera.FindAction("Turret Aim", throwIfNotFound: true);
        m_CCTVCamera_TurretReload = m_CCTVCamera.FindAction("Turret Reload", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
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

    // CCTV Camera
    private readonly InputActionMap m_CCTVCamera;
    private List<ICCTVCameraActions> m_CCTVCameraActionsCallbackInterfaces = new List<ICCTVCameraActions>();
    private readonly InputAction m_CCTVCamera_CameraMovement;
    private readonly InputAction m_CCTVCamera_TurretFire;
    private readonly InputAction m_CCTVCamera_TurretAim;
    private readonly InputAction m_CCTVCamera_TurretReload;
    public struct CCTVCameraActions
    {
        private @InputMap m_Wrapper;
        public CCTVCameraActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraMovement => m_Wrapper.m_CCTVCamera_CameraMovement;
        public InputAction @TurretFire => m_Wrapper.m_CCTVCamera_TurretFire;
        public InputAction @TurretAim => m_Wrapper.m_CCTVCamera_TurretAim;
        public InputAction @TurretReload => m_Wrapper.m_CCTVCamera_TurretReload;
        public InputActionMap Get() { return m_Wrapper.m_CCTVCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CCTVCameraActions set) { return set.Get(); }
        public void AddCallbacks(ICCTVCameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CCTVCameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CCTVCameraActionsCallbackInterfaces.Add(instance);
            @CameraMovement.started += instance.OnCameraMovement;
            @CameraMovement.performed += instance.OnCameraMovement;
            @CameraMovement.canceled += instance.OnCameraMovement;
            @TurretFire.started += instance.OnTurretFire;
            @TurretFire.performed += instance.OnTurretFire;
            @TurretFire.canceled += instance.OnTurretFire;
            @TurretAim.started += instance.OnTurretAim;
            @TurretAim.performed += instance.OnTurretAim;
            @TurretAim.canceled += instance.OnTurretAim;
            @TurretReload.started += instance.OnTurretReload;
            @TurretReload.performed += instance.OnTurretReload;
            @TurretReload.canceled += instance.OnTurretReload;
        }

        private void UnregisterCallbacks(ICCTVCameraActions instance)
        {
            @CameraMovement.started -= instance.OnCameraMovement;
            @CameraMovement.performed -= instance.OnCameraMovement;
            @CameraMovement.canceled -= instance.OnCameraMovement;
            @TurretFire.started -= instance.OnTurretFire;
            @TurretFire.performed -= instance.OnTurretFire;
            @TurretFire.canceled -= instance.OnTurretFire;
            @TurretAim.started -= instance.OnTurretAim;
            @TurretAim.performed -= instance.OnTurretAim;
            @TurretAim.canceled -= instance.OnTurretAim;
            @TurretReload.started -= instance.OnTurretReload;
            @TurretReload.performed -= instance.OnTurretReload;
            @TurretReload.canceled -= instance.OnTurretReload;
        }

        public void RemoveCallbacks(ICCTVCameraActions instance)
        {
            if (m_Wrapper.m_CCTVCameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICCTVCameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CCTVCameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CCTVCameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CCTVCameraActions @CCTVCamera => new CCTVCameraActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Interact;
    public struct PlayerActions
    {
        private @InputMap m_Wrapper;
        public PlayerActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_DefaultControlsSchemeIndex = -1;
    public InputControlScheme DefaultControlsScheme
    {
        get
        {
            if (m_DefaultControlsSchemeIndex == -1) m_DefaultControlsSchemeIndex = asset.FindControlSchemeIndex("Default Controls");
            return asset.controlSchemes[m_DefaultControlsSchemeIndex];
        }
    }
    public interface ICCTVCameraActions
    {
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnTurretFire(InputAction.CallbackContext context);
        void OnTurretAim(InputAction.CallbackContext context);
        void OnTurretReload(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
