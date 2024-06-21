using GenericInputIID;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PushGenericMono_GamepadInput : MonoBehaviour
{
    public UnityEvent<int> m_onIntegerValueChanged;
    public int m_startId = 2000000000;
    public GamepadIntegerOnlyTwoAxisNoXR m_input;
    public float m_joystickLeftHorizontal;
    public float m_joystickLeftVertical;
    public float m_joystickRightHorizontal;
    public float m_joystickRightVertical;

    public int m_asIntCurrent;
    public int m_asIntPrevious;

    public float m_deathZone=0.2f;


    public float m_pushFrequence = 0.2f;


    public int m_fireOnAction=4561;
    public int m_fireOffAction=4560;

    IEnumerator Start()
    {
        while (true)
        {
           
            m_onIntegerValueChanged.Invoke(m_asIntCurrent);
            yield return new WaitForSeconds(m_pushFrequence);
            yield return new WaitForEndOfFrame();
        }
    }

    private void OnEnable()
    {
        m_input = new GamepadIntegerOnlyTwoAxisNoXR();
        m_input.Enable();
        m_input.GamepadTwoJoystick.Enable();

    }

    void Update()
    {

        m_input.GamepadTwoJoystick.LeftJoystickHorizontal.performed +=
                  (InputAction.CallbackContext obj) => m_joystickLeftHorizontal = obj.ReadValue<float>();
        m_input.GamepadTwoJoystick.LeftJoystickVertical.performed +=
                  (InputAction.CallbackContext obj) => m_joystickLeftVertical = obj.ReadValue<float>();
        m_input.GamepadTwoJoystick.RightJoystickHorizontal.performed +=
                  (InputAction.CallbackContext obj) => m_joystickRightHorizontal = obj.ReadValue<float>();
        m_input.GamepadTwoJoystick.RightJoystickVertical.performed +=
                  (InputAction.CallbackContext obj) => m_joystickRightVertical = obj.ReadValue<float>();

        m_input.GamepadTwoJoystick.LeftJoystickHorizontal.canceled +=
                 (InputAction.CallbackContext obj) => m_joystickLeftHorizontal = 0;
        m_input.GamepadTwoJoystick.LeftJoystickVertical.canceled +=
                  (InputAction.CallbackContext obj) => m_joystickLeftVertical = 0;
        m_input.GamepadTwoJoystick.RightJoystickHorizontal.canceled +=
                  (InputAction.CallbackContext obj) => m_joystickRightHorizontal = 0;
        m_input.GamepadTwoJoystick.RightJoystickVertical.canceled +=
                  (InputAction.CallbackContext obj) => m_joystickRightVertical = 0;


        if (m_input.GamepadTwoJoystick.FireBullet.WasPressedThisFrame())
            m_onIntegerValueChanged.Invoke(m_fireOnAction);
        if (m_input.GamepadTwoJoystick.FireBullet.WasReleasedThisFrame())
            m_onIntegerValueChanged.Invoke(m_fireOffAction);

        int value = 0;
        value += (int)(TurnPercent11To099(m_joystickRightVertical));
        value += (int)(TurnPercent11To099(m_joystickRightHorizontal)*100);
        value += (int)(TurnPercent11To099(m_joystickLeftVertical) * 10000);
        value += (int)(TurnPercent11To099(m_joystickLeftHorizontal) * 1000000);

        value += Math.Abs(m_startId) * 100000000;

        if (m_startId < 0)
        {
            value *= -1;
        }

        m_asIntCurrent = value;

        if (m_asIntPrevious != m_asIntCurrent) {
            if (m_asIntCurrent == m_startId)
            {
                m_asIntPrevious = m_asIntCurrent;
                m_onIntegerValueChanged.Invoke(m_asIntCurrent);
            }
            if (m_asIntPrevious == m_startId)
            {
                m_asIntPrevious = m_asIntCurrent;

                m_onIntegerValueChanged.Invoke(m_asIntCurrent);
            }

        }
        
    }

    private int TurnPercent11To099(float percent)
    {
        if (percent == 0)
            return 0;
        if (Math.Abs(percent) < m_deathZone)
            return 0;
        return Mathf.Clamp((int)Math.Round(1f + (((percent + 1f) * 0.5f) * 98f), 0), 0, 99);
    }
}
