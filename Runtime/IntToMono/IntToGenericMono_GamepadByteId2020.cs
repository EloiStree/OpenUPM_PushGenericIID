using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntToGenericMono_GamepadByteId2020 : MonoBehaviour
{
    public int m_receivedInteger;
    public STRUCT_GamepadByteId2020Percent11 m_receivedGamepadByteId2020;
    public UnityEvent<STRUCT_GamepadByteId2020Percent11> m_onGamepadReceived;

    public void PushInInteger(int value)
    {
        m_receivedInteger = value;
        IntegerToGamepad2020Utility.ParseGamepadByteId2020FromInteger(value, out m_receivedGamepadByteId2020);
        m_onGamepadReceived.Invoke(m_receivedGamepadByteId2020);
    }

}
