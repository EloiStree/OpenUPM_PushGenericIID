using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SplitMono_Gamepad2020ToDoubleVector2 : MonoBehaviour
{

    public Vector2 m_leftReceived;
    public Vector2 m_rightReceived;
    public UnityEvent<Vector2> m_onJoystickLeft;
    public UnityEvent<Vector2> m_onJoystickRight;
    public UnityEvent<Vector2,Vector2> m_onBothJoystick;


    public void PushInGamepad(STRUCT_GamepadByteId2020Percent11 gamepad) {
        Vector2 left = new Vector2(gamepad.m_joystickLeftHorizontal, gamepad.m_joystickLeftVertical);
        Vector2 right = new Vector2(gamepad.m_joystickRightHorizontal, gamepad.m_joystickRightVertical);
        m_leftReceived = left;
        m_rightReceived = right;
        m_onJoystickLeft.Invoke(left);
        m_onJoystickLeft.Invoke(right);
        m_onBothJoystick.Invoke(left, right);
    }
}
