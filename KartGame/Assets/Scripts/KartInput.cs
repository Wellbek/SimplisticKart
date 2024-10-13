// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/KartInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KartInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KartInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KartInput"",
    ""maps"": [
        {
            ""name"": ""Kart"",
            ""id"": ""81cf0e09-e57f-4774-80cc-24d5bd813299"",
            ""actions"": [
                {
                    ""name"": ""Accel"",
                    ""type"": ""Value"",
                    ""id"": ""4737edf9-b2b6-43d4-9877-35651d174e73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Value"",
                    ""id"": ""ea2dcc9f-3040-4841-a052-73ec77fd3f30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DriftDown"",
                    ""type"": ""Button"",
                    ""id"": ""474e3d13-0c43-42c4-974d-fb3e7503d307"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DriftUp"",
                    ""type"": ""Button"",
                    ""id"": ""aabdc860-a32c-4b0f-b4e2-74aaf0aeebb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""8dd0e0f0-25a7-4c67-955b-254e4d5550d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""driftControl_Left"",
                    ""type"": ""Value"",
                    ""id"": ""61578b18-d54d-49a7-8edc-1fb04dbb201f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""driftControl_Right"",
                    ""type"": ""Value"",
                    ""id"": ""db4aeefe-a820-4b3f-aad6-3e37f6f5512f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""powerControl_Left"",
                    ""type"": ""Value"",
                    ""id"": ""8aa3d0ea-79ff-4c6a-ae5d-51edfae16892"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""powerControl_Right"",
                    ""type"": ""Value"",
                    ""id"": ""dc435319-80c2-4eb5-ab34-18d355f4f0c7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookBack"",
                    ""type"": ""Value"",
                    ""id"": ""a9ee125b-fe27-426d-a8a7-d8580cbbba94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""8197e6b8-776a-4da5-9ced-50bf2a980d6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""0d209319-5110-4f25-a27f-d1c0ad445cc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""DPad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dd93f376-b8dd-40a6-afb9-641394b94f13"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""7a002cd4-01eb-4d7a-a99c-eafa5db0698b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b9a4f64-28a6-4324-8f8c-bbe2c08433b2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abe4b818-d610-4ee4-ae9c-980ba3ca0086"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1edd205c-2468-40ea-a208-7aea65758896"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f6fb9943-e423-4a11-b9df-79c8a598326a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9446e029-2623-4941-b4e5-f9662a332047"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cfaab220-ca0a-46ee-a972-5aceaa0ee5c4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a9435c81-1ffc-4e3c-ad71-2c9a0320deda"",
                    ""path"": ""1DAxis(minValue=1,maxValue=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9444ca86-eefb-4cbc-bda9-6130d51f549e"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cbcc490c-5468-46d1-be35-08ff73e1e648"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7c4a8417-08c1-449f-ac8e-49503ab6f7fd"",
                    ""path"": ""1DAxis(minValue=1,maxValue=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""97f8f1ad-a00b-488f-a2b2-3b71dfbb29f8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9fa60d0c-10aa-4907-9649-705e0fd7f19b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""powerControl_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dd642cb3-a739-43a5-8714-baafe56b59d7"",
                    ""path"": ""1DAxis(minValue=1,maxValue=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3c7f6ec4-5ec8-435d-8a81-4cfe9ff44b14"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7bcc6953-13d1-4836-95f5-f283b5c74249"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""caa3e3a4-4e70-49cc-976a-1745d3bfd9e1"",
                    ""path"": ""1DAxis(minValue=1,maxValue=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""7b412414-1bd7-4df7-98af-db28776a48c8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""39823390-23c7-4812-a4a9-5e10380664dd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""driftControl_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b11ad056-0859-45c1-97ac-8ca19073328b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72541a5b-da24-4467-aa69-552fc0846158"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e32d9e8-6848-464d-ad5d-9259ee76fef1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c98aa5a-fdc5-4ed9-9738-6b618f39ca99"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f32e0e01-8dd2-4474-a37f-1ca5cffb9929"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3846813b-c7bd-4cf4-ae38-d99d955395a2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Kart
        m_Kart = asset.FindActionMap("Kart", throwIfNotFound: true);
        m_Kart_Accel = m_Kart.FindAction("Accel", throwIfNotFound: true);
        m_Kart_Reverse = m_Kart.FindAction("Reverse", throwIfNotFound: true);
        m_Kart_DriftDown = m_Kart.FindAction("DriftDown", throwIfNotFound: true);
        m_Kart_DriftUp = m_Kart.FindAction("DriftUp", throwIfNotFound: true);
        m_Kart_Horizontal = m_Kart.FindAction("Horizontal", throwIfNotFound: true);
        m_Kart_driftControl_Left = m_Kart.FindAction("driftControl_Left", throwIfNotFound: true);
        m_Kart_driftControl_Right = m_Kart.FindAction("driftControl_Right", throwIfNotFound: true);
        m_Kart_powerControl_Left = m_Kart.FindAction("powerControl_Left", throwIfNotFound: true);
        m_Kart_powerControl_Right = m_Kart.FindAction("powerControl_Right", throwIfNotFound: true);
        m_Kart_LookBack = m_Kart.FindAction("LookBack", throwIfNotFound: true);
        m_Kart_PauseGame = m_Kart.FindAction("PauseGame", throwIfNotFound: true);
        m_Kart_Select = m_Kart.FindAction("Select", throwIfNotFound: true);
        m_Kart_DPad = m_Kart.FindAction("DPad", throwIfNotFound: true);
        m_Kart_UseItem = m_Kart.FindAction("UseItem", throwIfNotFound: true);
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

    // Kart
    private readonly InputActionMap m_Kart;
    private IKartActions m_KartActionsCallbackInterface;
    private readonly InputAction m_Kart_Accel;
    private readonly InputAction m_Kart_Reverse;
    private readonly InputAction m_Kart_DriftDown;
    private readonly InputAction m_Kart_DriftUp;
    private readonly InputAction m_Kart_Horizontal;
    private readonly InputAction m_Kart_driftControl_Left;
    private readonly InputAction m_Kart_driftControl_Right;
    private readonly InputAction m_Kart_powerControl_Left;
    private readonly InputAction m_Kart_powerControl_Right;
    private readonly InputAction m_Kart_LookBack;
    private readonly InputAction m_Kart_PauseGame;
    private readonly InputAction m_Kart_Select;
    private readonly InputAction m_Kart_DPad;
    private readonly InputAction m_Kart_UseItem;
    public struct KartActions
    {
        private @KartInput m_Wrapper;
        public KartActions(@KartInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accel => m_Wrapper.m_Kart_Accel;
        public InputAction @Reverse => m_Wrapper.m_Kart_Reverse;
        public InputAction @DriftDown => m_Wrapper.m_Kart_DriftDown;
        public InputAction @DriftUp => m_Wrapper.m_Kart_DriftUp;
        public InputAction @Horizontal => m_Wrapper.m_Kart_Horizontal;
        public InputAction @driftControl_Left => m_Wrapper.m_Kart_driftControl_Left;
        public InputAction @driftControl_Right => m_Wrapper.m_Kart_driftControl_Right;
        public InputAction @powerControl_Left => m_Wrapper.m_Kart_powerControl_Left;
        public InputAction @powerControl_Right => m_Wrapper.m_Kart_powerControl_Right;
        public InputAction @LookBack => m_Wrapper.m_Kart_LookBack;
        public InputAction @PauseGame => m_Wrapper.m_Kart_PauseGame;
        public InputAction @Select => m_Wrapper.m_Kart_Select;
        public InputAction @DPad => m_Wrapper.m_Kart_DPad;
        public InputAction @UseItem => m_Wrapper.m_Kart_UseItem;
        public InputActionMap Get() { return m_Wrapper.m_Kart; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KartActions set) { return set.Get(); }
        public void SetCallbacks(IKartActions instance)
        {
            if (m_Wrapper.m_KartActionsCallbackInterface != null)
            {
                @Accel.started -= m_Wrapper.m_KartActionsCallbackInterface.OnAccel;
                @Accel.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnAccel;
                @Accel.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnAccel;
                @Reverse.started -= m_Wrapper.m_KartActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnReverse;
                @DriftDown.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftDown;
                @DriftDown.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftDown;
                @DriftDown.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftDown;
                @DriftUp.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftUp;
                @DriftUp.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftUp;
                @DriftUp.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftUp;
                @Horizontal.started -= m_Wrapper.m_KartActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnHorizontal;
                @driftControl_Left.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Left;
                @driftControl_Left.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Left;
                @driftControl_Left.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Left;
                @driftControl_Right.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Right;
                @driftControl_Right.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Right;
                @driftControl_Right.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDriftControl_Right;
                @powerControl_Left.started -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Left;
                @powerControl_Left.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Left;
                @powerControl_Left.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Left;
                @powerControl_Right.started -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Right;
                @powerControl_Right.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Right;
                @powerControl_Right.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnPowerControl_Right;
                @LookBack.started -= m_Wrapper.m_KartActionsCallbackInterface.OnLookBack;
                @LookBack.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnLookBack;
                @LookBack.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnLookBack;
                @PauseGame.started -= m_Wrapper.m_KartActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnPauseGame;
                @Select.started -= m_Wrapper.m_KartActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnSelect;
                @DPad.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDPad;
                @DPad.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDPad;
                @DPad.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDPad;
                @UseItem.started -= m_Wrapper.m_KartActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnUseItem;
            }
            m_Wrapper.m_KartActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accel.started += instance.OnAccel;
                @Accel.performed += instance.OnAccel;
                @Accel.canceled += instance.OnAccel;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @DriftDown.started += instance.OnDriftDown;
                @DriftDown.performed += instance.OnDriftDown;
                @DriftDown.canceled += instance.OnDriftDown;
                @DriftUp.started += instance.OnDriftUp;
                @DriftUp.performed += instance.OnDriftUp;
                @DriftUp.canceled += instance.OnDriftUp;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @driftControl_Left.started += instance.OnDriftControl_Left;
                @driftControl_Left.performed += instance.OnDriftControl_Left;
                @driftControl_Left.canceled += instance.OnDriftControl_Left;
                @driftControl_Right.started += instance.OnDriftControl_Right;
                @driftControl_Right.performed += instance.OnDriftControl_Right;
                @driftControl_Right.canceled += instance.OnDriftControl_Right;
                @powerControl_Left.started += instance.OnPowerControl_Left;
                @powerControl_Left.performed += instance.OnPowerControl_Left;
                @powerControl_Left.canceled += instance.OnPowerControl_Left;
                @powerControl_Right.started += instance.OnPowerControl_Right;
                @powerControl_Right.performed += instance.OnPowerControl_Right;
                @powerControl_Right.canceled += instance.OnPowerControl_Right;
                @LookBack.started += instance.OnLookBack;
                @LookBack.performed += instance.OnLookBack;
                @LookBack.canceled += instance.OnLookBack;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @DPad.started += instance.OnDPad;
                @DPad.performed += instance.OnDPad;
                @DPad.canceled += instance.OnDPad;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
            }
        }
    }
    public KartActions @Kart => new KartActions(this);
    public interface IKartActions
    {
        void OnAccel(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnDriftDown(InputAction.CallbackContext context);
        void OnDriftUp(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnDriftControl_Left(InputAction.CallbackContext context);
        void OnDriftControl_Right(InputAction.CallbackContext context);
        void OnPowerControl_Left(InputAction.CallbackContext context);
        void OnPowerControl_Right(InputAction.CallbackContext context);
        void OnLookBack(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnDPad(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
    }
}
