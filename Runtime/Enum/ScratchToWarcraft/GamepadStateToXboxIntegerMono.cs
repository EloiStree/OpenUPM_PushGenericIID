using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GamepadStateToXboxIntegerMono : MonoBehaviour
{

    public UnityEvent<int> m_onIntegerPushed;
    public int m_lastPushedInteger;
    public string m_lastPushedDate;


    public float m_triggerThreshold = 0.5f;
    public float m_stickThreshold = 0.1f;

    public bool m_setupAtStart = true;

    public void Push(int integer)
    {
        m_onIntegerPushed.Invoke(integer);
        m_lastPushedInteger = integer;
        m_lastPushedDate = DateTime.Now.ToString();
    }

    public void Start()
    {
        if (m_setupAtStart)
        {
            Setup();
        }
        
    }
    public void Setup() { 
    
        m_pressA.SetActionInteger(Push);
        m_pressX.SetActionInteger(Push);
        m_pressB.SetActionInteger(Push);
        m_pressY.SetActionInteger(Push);
        m_pressArrowLeft.SetActionInteger(Push);
        m_pressArrowRight.SetActionInteger(Push);
        m_pressArrowUp.SetActionInteger(Push);
        m_pressArrowDown.SetActionInteger(Push);
        m_pressButtonLeftStick.SetActionInteger(Push);
        m_pressButtonRightStick.SetActionInteger(Push);
        m_pressLeftSideButton.SetActionInteger(Push);
        m_pressRightSideButton.SetActionInteger(Push);
        m_pressMenuLeft.SetActionInteger(Push);
        m_pressMenuRight.SetActionInteger(Push);
        m_pressMenuCenter.SetActionInteger(Push);
        m_pressLeftTrigger1D.SetActionInteger(Push);
        m_pressRightTrigger1D.SetActionInteger(Push);
        m_leftStick.SetActionInteger(Push);
        m_rightStick.SetActionInteger(Push);


    }

    public void OnEnable()
    {
        m_pressA.StartListening();
        m_pressX.StartListening();
        m_pressB.StartListening();
        m_pressY.StartListening();
        m_pressArrowLeft.StartListening();
        m_pressArrowRight.StartListening();
        m_pressArrowUp.StartListening();
        m_pressArrowDown.StartListening();
        m_pressArrowLeft.StartListening();
        m_pressArrowRight.StartListening();
        m_pressButtonLeftStick.StartListening();
        m_pressButtonRightStick.StartListening();
        m_pressLeftSideButton.StartListening();
        m_pressRightSideButton.StartListening();
        m_pressMenuLeft.StartListening();
        m_pressMenuRight.StartListening();
        m_pressMenuCenter.StartListening();
        m_pressLeftTrigger1D.StartListening();
        m_pressRightTrigger1D.StartListening();
        m_leftStick.StartListening();
        m_rightStick.StartListening();
    }

    public void OnDisable()
    {
        m_pressA.StopListening();
        m_pressX.StopListening();
        m_pressB.StopListening();
        m_pressY.StopListening();
        m_pressArrowLeft.StopListening();
        m_pressArrowRight.StopListening();
        m_pressArrowUp.StopListening();
        m_pressArrowDown.StopListening();
        m_pressArrowLeft.StopListening();
        m_pressArrowRight.StopListening();
        m_pressButtonLeftStick.StopListening();
        m_pressButtonRightStick.StopListening();
        m_pressLeftSideButton.StopListening();
        m_pressRightSideButton.StopListening();
        m_pressMenuLeft.StopListening();
        m_pressMenuRight.StopListening();
        m_pressMenuCenter.StopListening();
        m_pressLeftTrigger1D.StopListening();
        m_pressRightTrigger1D.StopListening();
        m_leftStick.StopListening();
        m_rightStick.StopListening();

    }

    public ListenToAxisInput m_pressA = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressA, null, null, 0.5f);
    public ListenToAxisInput m_pressX= new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressX, null, null, 0.5f);
    public ListenToAxisInput m_pressB = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressB, null, null, 0.5f);
    public ListenToAxisInput m_pressY= new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressY, null, null, 0.5f);

    public ListenToAxisInput m_pressArrowLeft = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressArrowWest, null, null, 0.5f);
    public ListenToAxisInput m_pressArrowRight = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressArrowEast, null, null, 0.5f);

    public ListenToAxisInput m_pressArrowUp= new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressArrowNorth, null, null, 0.5f);
    public ListenToAxisInput m_pressArrowDown = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressArrowSouth, null, null, 0.5f);

    public ListenToAxisInput m_pressButtonLeftStick = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressLeftSideButton, null, null, 0.5f);
    public ListenToAxisInput m_pressButtonRightStick = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressRightSideButton, null, null, 0.5f);

    public ListenToAxisInput m_pressLeftSideButton = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressLeftSideButton, null, null, 0.5f);
    public ListenToAxisInput m_pressRightSideButton = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressRightSideButton, null, null, 0.5f);

    public ListenToAxisInput m_pressMenuLeft = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressMenuLeft, null, null, 0.5f);
    public ListenToAxisInput m_pressMenuRight = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressMenuRight, null, null, 0.5f);
    public ListenToAxisInput m_pressMenuCenter = new ListenToAxisInput(EnumScratchToWarcraftGamepad.PressXboxHomeButton, null, null, 0.5f);

    public ListenToAxisInput m_pressLeftTrigger1D = new ListenToAxisInput(EnumScratchToWarcraftGamepad.SetLeftTriggerTo100, null, null, 0.1f);
    public ListenToAxisInput m_pressRightTrigger1D = new ListenToAxisInput(EnumScratchToWarcraftGamepad.SetRightTriggerTo100, null, null, 0.1f);

    public ListenToJoystickInput m_leftStick = new ListenToJoystickInput(ListenToJoystickInput.JoystickType.LeftStick, null, null, 0.45f);
    public ListenToJoystickInput m_rightStick = new ListenToJoystickInput(ListenToJoystickInput.JoystickType.RightStick, null, null, 0.45f);



    [System.Serializable]
    public class ListenToAxisInput
    {
        public string m_enumName;
        public InputActionReference m_observed;
        public EnumScratchToWarcraftGamepad m_enumValue;
        public int m_inputIndexEnumXomi;
        public float m_currentValue;
        public float m_previousValue;
        public bool m_currentPressed;
        public bool m_previousPressed;
        public float m_threshold=0.5f;

        public Action<int> m_onIntegerPushed;

        public ListenToAxisInput(EnumScratchToWarcraftGamepad enumValue, InputActionReference input, Action<int> onIntegerPushed, float threshold=0.5f)
        {
            m_enumName = enumValue.ToString();
            m_enumValue = enumValue;
            m_inputIndexEnumXomi = (int)enumValue;
            m_onIntegerPushed = onIntegerPushed;
            m_threshold = threshold;
            m_observed = input;

        }
        public void SetActionInteger(Action<int> onIntegerPushed)
        {
            m_onIntegerPushed = onIntegerPushed;

        }

        public void SetInputActionReference(InputActionReference input)
        {
            m_observed = input;
        }

        public void StartListening()
        {
            if (m_observed == null)
                return;
            StopListening();
            m_observed.action.Enable();
            m_observed.action.performed += OnChanged;
            m_observed.action.canceled += OnChanged;
        }
        public void StopListening()
        {
            if (m_observed == null)
                return;
            m_observed.action.performed -= OnChanged;
            m_observed.action.canceled -= OnChanged;
        }

        private void OnChanged(InputAction.CallbackContext context)
        {
            m_previousValue = m_currentValue;
            m_currentValue = context.ReadValue<float>();
            m_previousPressed = m_currentPressed;
            m_currentPressed = m_currentValue > m_threshold;

            if (m_currentPressed != m_previousPressed) { 
                if (m_currentPressed)
                {
                    m_onIntegerPushed.Invoke(m_inputIndexEnumXomi);
                }
                if (!m_currentPressed) {
                    m_onIntegerPushed.Invoke( m_inputIndexEnumXomi+1000);
                }
            }
        }
    }



    [System.Serializable]
    public class ListenToJoystickInput
    {
        public string m_enumName;
        public InputActionReference m_observed;
        public enum JoystickType { LeftStick, RightStick }
        public JoystickType m_joystickType;
        public Vector2 m_currentValue;
        public Vector2 m_previousValue;
        public bool m_directional=true;

        [Range(-1, 1)]  public float m_previousValueHorizontal;
        [Range(-1, 1)] public float m_previousValueVertical;
        [Range(-1, 1)] public float m_currentValueHorizontal;
        [Range(-1, 1)] public float m_currentValueVertical;

        public float m_threshold = 0.45f;

        public Action<int> m_onIntegerPushed;

        public ListenToJoystickInput(JoystickType joystickType, InputActionReference input, Action<int> onIntegerPushed, float threshold = 0.5f)
        {
            m_enumName = joystickType.ToString();
            m_joystickType = joystickType;
            m_onIntegerPushed = onIntegerPushed;
            m_threshold = threshold;
            m_observed = input;
            StartListening();

        }



        public void StartListening()
        {
            if (m_observed == null)
                return;
            StopListening();
            m_observed.action.Enable();
            m_observed.action.performed += OnChanged;
            m_observed.action.canceled += OnChanged;
        }
        public void StopListening()
        {
            if (m_observed == null)
                return;
            m_observed.action.performed -= OnChanged;
            m_observed.action.canceled -= OnChanged;
        }
        
        public JoystickState m_previousDirection;
        public JoystickState m_currentDirection;

        public enum JoystickState { Neutral, N, NE, E, SE, S, SW, W ,NW }
        private void OnChanged(InputAction.CallbackContext context)
        {
            m_previousValue = m_currentValue;
            m_currentValue = context.ReadValue<Vector2>();


            m_currentDirection = JoystickState.Neutral;

            if (m_directional) { 
            float x = m_currentValue.x;
            float y = m_currentValue.y;
            if (y>m_threshold)
            {
                m_currentDirection = JoystickState.N;
                if (x > m_threshold)
                {
                    m_currentDirection = JoystickState.NE;
                }
                if (x < -m_threshold)
                {
                    m_currentDirection = JoystickState.NW;
                }
            }
            else if (y < -m_threshold)
            {
                m_currentDirection = JoystickState.S;
                if (x > m_threshold)
                {
                    m_currentDirection = JoystickState.SE;
                }
                if (x < -m_threshold)
                {
                    m_currentDirection = JoystickState.SW;
                }
            }
            else if (x > m_threshold)
            {
                m_currentDirection = JoystickState.E;
            }
            else if (x < -m_threshold)
            {
                m_currentDirection = JoystickState.W;
            }
            else
            {
                 m_currentDirection = JoystickState.Neutral;
            }


            if (m_currentDirection != m_previousDirection) { 
                m_previousDirection= m_currentDirection;

                int intToPush = 0;
                switch (m_currentDirection)
                {
                    case JoystickState.Neutral:
                        intToPush =(int)( m_joystickType== JoystickType.LeftStick?
                            EnumScratchToWarcraftGamepad.SetToLeftStickToNeutralClockwise:
                            EnumScratchToWarcraftGamepad.SetToRightStickToNeutralClockwise);
                        break;
                        case JoystickState.N:
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickUp:
                            EnumScratchToWarcraftGamepad.SetToRightStickUp);
                        break;

                        case JoystickState.NE:
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickUpRight :
                            EnumScratchToWarcraftGamepad.SetToRightStickUpRight);
                        break;

                        case JoystickState.E:
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickRight :
                            EnumScratchToWarcraftGamepad.SetToRightStickRight);
                        break;

                        case JoystickState.SE:
                            
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickDownRight :
                            EnumScratchToWarcraftGamepad.SetToRightStickDownRight);

                        break;

                        case JoystickState.S:
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickDown :
                            EnumScratchToWarcraftGamepad.SetToRightStickDown);

                        break;

                        case JoystickState.SW:

                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickDownLeft :
                            EnumScratchToWarcraftGamepad.SetToRightStickDownLeft);

                        break;

                        case JoystickState.W:

                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickLeft :
                            EnumScratchToWarcraftGamepad.SetToRightStickLeft);
                        break;

                        case JoystickState.NW:
                        intToPush = (int)(m_joystickType == JoystickType.LeftStick ?
                            EnumScratchToWarcraftGamepad.SetToLeftStickUpLeft :
                            EnumScratchToWarcraftGamepad.SetToRightStickUpLeft);
                        break;
                }
                m_onIntegerPushed.Invoke(intToPush);
            }
            }
        }

        internal void SetActionInteger(Action<int> invoke)
        {
            m_onIntegerPushed = invoke;
        }
    }
}

