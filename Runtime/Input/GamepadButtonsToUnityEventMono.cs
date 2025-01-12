using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GamepadButtonsToUnityEventMono : MonoBehaviour
{

    public List<InputActionRefToUnity> m_buttonsToListen= new List<InputActionRefToUnity>();


    public void OnEnable()
    {
        foreach (var action in m_buttonsToListen)
        {
            action.m_buttonRef.action.Enable();
            action.m_buttonRef.action.performed += ctx => action.SetPressed(true);
            action.m_buttonRef.action.canceled += ctx => action.SetPressed( false);
        }

    }
    public void OnDisable()
    {
        foreach(var action in m_buttonsToListen)
        {
            action.m_buttonRef.action.performed -= ctx => action.SetPressed(true);
            action.m_buttonRef.action.canceled -= ctx => action.SetPressed(false);
        }

    }
    [System.Serializable]
    public class InputActionRefToUnity {

        public void SetPressed(bool isPressed) { 
            bool changed= m_isPressed != isPressed;
            m_isPressed = isPressed; 
            if(changed) {
                m_onPressed.Invoke(m_isPressed);
                if (m_isPressed) m_onPressedTrue.Invoke();
                else m_onPressedFalse.Invoke();
            }
        }
        public string m_description;
        public InputActionReference m_buttonRef;
        public bool m_isPressed;
        public UnityEvent<bool> m_onPressed;
        public UnityEvent m_onPressedTrue;
        public UnityEvent m_onPressedFalse;

    }
}
