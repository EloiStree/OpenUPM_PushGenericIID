using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_GamepadByteId2020 : MonoBehaviour
{

    [Range(-20,20)]
    public short m_elementId;
    [Range(-1f,1f)]
    public float m_joystickLeftHorizontal;
    [Range(-1f, 1f)]
    public float m_joystickLeftVertical;
    [Range(-1f, 1f)]
    public float m_joystickRightHorizontal;
    [Range(-1f, 1f)]
    public float m_joystickRightVertical;


    public UnityEvent<int> m_onGamepadChanged;
    public int m_sendByteInteger;
    int m_previousSendByteInteger;


    public void NextElementId() { NextElementId(1); }
    public void PreviousElementId() { PreviousElementId(1); }

    public void NextElementId(short value) { SetElementId((short)(m_elementId + value)); }
    public void PreviousElementId(short value) { SetElementId((short)(m_elementId - value)); }


    public void SetElementId(short id) { 
        m_elementId =(short) Mathf.Clamp(id,-20,20);
    }

    public void SetLeftRightRotation(float percent) { 
        m_joystickLeftHorizontal = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetDownUp(float percent) { 
        m_joystickLeftVertical = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetLeftRight(float percent) { 
        m_joystickRightHorizontal = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetBackwardForward(float percent) { 
        m_joystickRightVertical = Mathf.Clamp(percent, -1f, 1f);
    }

    public void SetLeftJoystick(Vector2 joystick)
    {
        SetGamepadValues(joystick.x, joystick.y , m_joystickRightHorizontal, m_joystickRightVertical);
    }
    public void SetRightJoystick(Vector2 joystick)
    {
        SetGamepadValues(m_joystickLeftHorizontal, m_joystickLeftVertical, joystick.x, joystick.y);
    }

    public void SetGamepadValues(float leftRightRotationPercent, float downUpPercent, float leftRightPercent, float backwardForwardPercent)
    {

        m_joystickLeftHorizontal = Mathf.Clamp(leftRightRotationPercent, -1f, 1f);
        m_joystickLeftVertical = Mathf.Clamp(downUpPercent, -1f, 1f);
        m_joystickRightHorizontal = Mathf.Clamp(leftRightPercent, -1f, 1f);
        m_joystickRightVertical = Mathf.Clamp(backwardForwardPercent, -1f, 1f);

     }

    void Update()
    {
        RefreshAndPushIfChanged();
    }

    private void OnValidate()
    {
        RefreshAndPushIfChanged();
    }

    private void RefreshAndPushIfChanged()
    {
        int v = 0;
        v += ParsePercent11To099(m_joystickRightVertical);
        v += ParsePercent11To099(m_joystickRightHorizontal) * 100;
        v += ParsePercent11To099(m_joystickLeftVertical) * 10000;
        v += ParsePercent11To099(m_joystickLeftHorizontal) * 1000000;

        if (m_elementId > 0) { 
            v += m_elementId * 100000000;
        }
        else { 
            v += Mathf.Abs(m_elementId) * 100000000;
            v *= -1;
        }
        m_sendByteInteger = v;


        if (m_sendByteInteger != m_previousSendByteInteger)
        {
            m_previousSendByteInteger = m_sendByteInteger;
            m_onGamepadChanged.Invoke(m_sendByteInteger);
        }
    }

    public int ParsePercent11To099(float percent) { 
    
        if(percent==0)
            return 0;
        return (int)(Mathf.Round(((((percent +1f) / 2f) )*98f) +1f));
    }
}
