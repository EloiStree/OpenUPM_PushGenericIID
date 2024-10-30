using System;
using UnityEngine;

public class IntegerToGamepad2020Utility
{
    public static void ParseGamepadByteId2020FromInteger(int value, out GamepadByteId2020Percent11 gamepad)
    {
        ParseGamepadByteId2020FromInteger(value, out gamepad.m_id2020, out gamepad.m_joystickLeftHorizontal, out gamepad.m_joystickLeftVertical, out gamepad.m_joystickRightHorizontal, out gamepad.m_joystickRightVertical);
    }
    public static void ParseGamepadByteId2020FromInteger(int value, out short elementId, out float joystickLeftHorizontal, out float joystickLeftVertical, out float joystickRightHorizontal, out float joystickRightVertical)
    {
        elementId = (short)(value / 100000000);
        //if (elementId < 0)
        //    elementId = (short)(elementId * -1);
        if(value < 0) 
            value *= -1;
        joystickLeftHorizontal = ParsePercent99To11((value / 1000000) % 100);
        joystickLeftVertical = ParsePercent99To11((value / 10000) % 100);
        joystickRightHorizontal = ParsePercent99To11((value / 100) % 100);
        joystickRightVertical = ParsePercent99To11(value % 100);
    }

    public static void ParseGamepadByteId2020ToInteger(out int value, GamepadByteId2020Percent11 gamepad)
    {
        ParseGamepadByteId2020ToInteger(out value, gamepad.m_id2020, gamepad.m_joystickLeftHorizontal, gamepad.m_joystickLeftVertical, gamepad.m_joystickRightHorizontal, gamepad.m_joystickRightVertical);
    }
    
    public static void ParseGamepadByteId2020ToInteger(out int value, short elementId, float joystickLeftHorizontal, float joystickLeftVertical, float joystickRightHorizontal, float joystickRightVertical)
    {
        value = 0;
        value += ParsePercent11To099(joystickRightVertical);
        value += ParsePercent11To099(joystickRightHorizontal) * 100;
        value += ParsePercent11To099(joystickLeftVertical) * 10000;
        value += ParsePercent11To099(joystickLeftHorizontal) * 1000000;

        if (elementId > 0)
        {
            value += elementId * 100000000;
        }
        else if (elementId < 0)
        {
            value += -elementId * 100000000;
            value *= -1;
        }
    }


    public static float ParsePercent99To11(int percent) { 
        if(percent==0)
            return 0;
        return (percent - 1f) / 98f * 2f - 1f;
    }
    public static byte ParsePercent11To099(float percent)
    {
        if (percent == 0)
            return 0;
        return (byte)(Mathf.Round(((((percent + 1f) / 2f)) * 98f) + 1f));
    }

    public static void GetTwoFirstDigits(int value, out int first)
    {
        first = value / 100000000;
    }
}
