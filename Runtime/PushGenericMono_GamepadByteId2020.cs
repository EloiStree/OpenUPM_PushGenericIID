using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_GamepadByteId2020 : MonoBehaviour
{

    [Range(-20,20)]
    public short m_elementId;
    [Range(-1f,1f)]
    public float m_leftRightRotationPercent;
    [Range(-1f, 1f)]
    public float m_downUpPercent;
    [Range(-1f, 1f)]
    public float m_leftRightPercent;
    [Range(-1f, 1f)]
    public float m_backwardForwardPercent;


    public UnityEvent<int> m_onGamepadChanged;
    public int m_sendByteInteger;
    int m_previousSendByteInteger;



    public void SetElementId(byte id) { 
        m_elementId =(byte) Mathf.Clamp(id,-20,20);
    }

    public void SetLeftRightRotation(float percent) { 
        m_leftRightRotationPercent = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetDownUp(float percent) { 
        m_downUpPercent = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetLeftRight(float percent) { 
        m_leftRightPercent = Mathf.Clamp(percent, -1f, 1f);
    }
    public void SetBackwardForward(float percent) { 
        m_backwardForwardPercent = Mathf.Clamp(percent, -1f, 1f);
    }

    public void SetLeftJoystick(Vector2 joystick)
    {
        SetGamepadValues(joystick.x, joystick.y , m_leftRightPercent, m_backwardForwardPercent);
    }
    public void SetRightJoystick(Vector2 joystick)
    {
        SetGamepadValues(m_leftRightRotationPercent, m_downUpPercent, joystick.x, joystick.y);
    }

    public void SetGamepadValues(float leftRightRotationPercent, float downUpPercent, float leftRightPercent, float backwardForwardPercent)
    {

        m_leftRightRotationPercent = Mathf.Clamp(leftRightRotationPercent, -1f, 1f);
        m_downUpPercent = Mathf.Clamp(downUpPercent, -1f, 1f);
        m_leftRightPercent = Mathf.Clamp(leftRightPercent, -1f, 1f);
        m_backwardForwardPercent = Mathf.Clamp(backwardForwardPercent, -1f, 1f);

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
        v += ParsePercent11To099(m_backwardForwardPercent);
        v += ParsePercent11To099(m_leftRightPercent) * 100;
        v += ParsePercent11To099(m_downUpPercent) * 10000;
        v += ParsePercent11To099(m_leftRightRotationPercent) * 1000000;

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
