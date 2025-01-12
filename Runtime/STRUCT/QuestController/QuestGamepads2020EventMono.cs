using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestGamepads2020EventMono : MonoBehaviour
{
    public QuestGamepads2020Mono m_gamepad;

    [System.Serializable]
    public class Vector2Event  { 
        public Vector2 m_value;
        public bool m_isInUse;
        public UnityEvent<Vector2> m_onJoystickUpdated;
        public UnityEvent<float> m_onHorizontalUpdated;
        public UnityEvent<float> m_onVerticalUpdated;


        public float m_thresholdDeathZone = 0.1f;
        public UnityEvent<bool> m_onIsInUse;

        public void PushIn(float x, float y) {
            PushIn(new Vector2(x, y));
        }

        public void PushIn(Vector2 value) {
            if (m_value != value) {
                m_value = value;
                m_onJoystickUpdated.Invoke(value);
                m_onHorizontalUpdated.Invoke(value.x);
                m_onVerticalUpdated.Invoke(value.y);
            }
            bool previous = m_isInUse;
            m_isInUse = value.magnitude > m_thresholdDeathZone;
            if (previous != m_isInUse) {
                m_onIsInUse.Invoke(m_isInUse);
            }
        }
    }

    [System.Serializable]
    public class FloatEvent  { 
        public float m_value;
        public bool m_isInUse;
        public UnityEvent<float> m_onValueUpdated;
        
        public float m_thresholdDeathZone=0.08f;
        public UnityEvent<bool> m_onIsInUse;

        public void PushIn(float value) {
            if (m_value != value) {
                m_value = value;
                m_onValueUpdated.Invoke(value);
            }
            bool previous = m_isInUse;
            m_isInUse= Mathf.Abs(value) > m_thresholdDeathZone;
            
            if (previous != m_isInUse) {
                m_onIsInUse.Invoke(m_isInUse);
            }
        }   
    }
    [System.Serializable]
    public class BoolEvent{ 
        public bool value;
        public UnityEvent<bool> m_onChanged;
        public UnityEvent m_onSwitchToTrue;
        public UnityEvent m_onSwitchToFalse;

        public void PushIn(bool value) {
            if (this.value != value) {
                this.value = value;
                m_onChanged.Invoke(value);
                if (value) {
                    m_onSwitchToTrue.Invoke();
                } else {
                    m_onSwitchToFalse.Invoke();
                }
            }
        }
    }

    public GamepadEvent m_leftController;
    public GamepadEvent m_rightController;

    [System.Serializable]
    public class GamepadEvent {
        public Vector2Event m_onJoystick;
        public FloatEvent m_onTrigger;
        public FloatEvent m_onGrip;

        public BoolEvent m_buttonUp;
        public BoolEvent m_buttonDown;
        public BoolEvent m_buttonJoystick;
        public BoolEvent m_buttonThumbRest;
        public BoolEvent m_buttonMenu;


        public BoolEvent m_buttonUpTouched;
        public BoolEvent m_buttonDownTouched;
        public BoolEvent m_buttonJoystickTouched;
        public BoolEvent m_buttonTriggerTouched;


        public BoolEvent m_isTracked;
    }

    public void UpdateValue() { 
    
        m_leftController.m_onJoystick.PushIn(m_gamepad.GetLeftHorizontal(), m_gamepad.GetLeftVertical());
        m_leftController.m_onTrigger.PushIn(m_gamepad.GetTriggerLeft());
        m_leftController.m_onGrip.PushIn(m_gamepad.GetGripLeft());

        m_leftController.m_buttonUp.PushIn(m_gamepad.GetTopLeft());
        m_leftController.m_buttonDown.PushIn(m_gamepad.GetDownLeft());
        m_leftController.m_buttonJoystick.PushIn(m_gamepad.GetJoystickLeft());
        m_leftController.m_buttonThumbRest.PushIn(m_gamepad.GetThumbRestLeft());
        m_leftController.m_buttonMenu.PushIn(m_gamepad.GetMenuLeft());

        m_leftController.m_buttonUpTouched.PushIn(m_gamepad.GetTopLeftTouch());
        m_leftController.m_buttonDownTouched.PushIn(m_gamepad.GetDownLeftTouch());
        m_leftController.m_buttonJoystickTouched.PushIn(m_gamepad.GetJoystickLeftTouch());
        m_leftController.m_buttonTriggerTouched.PushIn(m_gamepad.GetTriggerLeftTouch());

        m_leftController.m_isTracked.PushIn(m_gamepad.GetIsLeftTracked());


        m_rightController.m_onJoystick.PushIn(m_gamepad.GetRightHorizontal(), m_gamepad.GetRightVertical());
        m_rightController.m_onTrigger.PushIn(m_gamepad.GetTriggerRight());
        m_rightController.m_onGrip.PushIn(m_gamepad.GetGripRight());

        m_rightController.m_buttonUp.PushIn(m_gamepad.GetTopRight());
        m_rightController.m_buttonDown.PushIn(m_gamepad.GetDownRight());
        m_rightController.m_buttonJoystick.PushIn(m_gamepad.GetJoystickRight());
        m_rightController.m_buttonThumbRest.PushIn(m_gamepad.GetThumbRestRight());
        m_rightController.m_buttonMenu.PushIn(m_gamepad.GetMenuRight());

        m_rightController.m_buttonUpTouched.PushIn(m_gamepad.GetTopRightTouch());
        m_rightController.m_buttonDownTouched.PushIn(m_gamepad.GetDownRightTouch());
        m_rightController.m_buttonJoystickTouched.PushIn(m_gamepad.GetJoystickRightTouch());
        m_rightController.m_buttonTriggerTouched.PushIn(m_gamepad.GetTriggerRightTouch());

        m_rightController.m_isTracked.PushIn(m_gamepad.GetIsRightTracked());
    }
}
