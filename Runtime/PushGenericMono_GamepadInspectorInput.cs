using GenericInputIID;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_GamepadInspectorInput : MonoBehaviour
{
    public UnityEvent<int> m_onIntegerValueChanged;
    public int m_startId = 2000000000;
    public GamepadIntegerOnlyTwoAxisNoXR m_input;
    public float m_joystickLeftHorizontal;
    public float m_joystickLeftVertical;
    public float m_joystickRightHorizontal;
    public float m_joystickRightVertical;
    public bool m_isFiring;

    public int m_asIntCurrent;
    public int m_asIntPrevious;

    public float m_deathZone = 0.2f;


    public float m_pushFrequence = 0.2f;


    public int m_fireOnAction = 4561;
    public int m_fireOffAction = 4560;



    public void SetLeftJoystickVertical(float percent1to1)
    {
        m_joystickLeftVertical = percent1to1;
    }
    public void SetLeftJoystickHorizontal(float percent1to1)
    {
        m_joystickLeftHorizontal = percent1to1;
    }
    public void SetRightJoystickVertical(float percent1to1)
    {
        m_joystickRightVertical = percent1to1;
    }
    public void SetRightJoystickHorizontal(float percent1to1)
    {
        m_joystickRightHorizontal = percent1to1;
    }


    public void SetFireState(bool setOn) {
        m_isFiring = setOn;
    }

    IEnumerator Start()
    {
        while (true)
        {

            m_onIntegerValueChanged.Invoke(m_asIntCurrent);
            yield return new WaitForSeconds(m_pushFrequence);
            yield return new WaitForEndOfFrame();
        }
    }


    private bool m_wasFiring;

    void Update()
    {
        int value = 0;
        value += (int)(TurnPercent11To099(m_joystickRightVertical));
        value += (int)(TurnPercent11To099(m_joystickRightHorizontal) * 100);
        value += (int)(TurnPercent11To099(m_joystickLeftVertical) * 10000);
        value += (int)(TurnPercent11To099(m_joystickLeftHorizontal) * 1000000);

        value += Math.Abs( m_startId) * 100000000;
        
        if (m_startId < 0) {
            value *= -1;
        }

        m_asIntCurrent = value;

        
        if(m_wasFiring!= m_isFiring)
        {
            m_wasFiring = m_isFiring;
            if (m_isFiring)
            {
                m_onIntegerValueChanged.Invoke(m_fireOnAction);
            }
            else { 
                m_onIntegerValueChanged.Invoke(m_fireOffAction);
            }
        }

        if (m_asIntPrevious != m_asIntCurrent)
        {
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
        return  Mathf.Clamp((int)Math.Round (1f + (((percent + 1f) * 0.5f) * 98f),0),0,99);
    }
}
