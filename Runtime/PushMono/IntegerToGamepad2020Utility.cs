using System;
using UnityEngine;

public class IntegerToGamepad2020Utility
{
    public static void ParseGamepadByteId2020FromInteger(int value, out STRUCT_GamepadByteId2020Percent11 gamepad)
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

    public static void ParseGamepadByteId2020ToInteger(out int value, STRUCT_GamepadByteId2020Percent11 gamepad)
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

    public static void GetIntegerAs32BitsLeftRight(int value, out bool[] bits32)
    {
        // from right to left
        bits32 = new bool[32];
        for (int i = 0; i < 32; i++)
        {
            bits32[i] = (value & (1 << i)) != 0;
        }
    }
    public static void GetIntegerAs32BitsRightLeft(int value, out bool[] bits32)
    {
        GetIntegerAs32BitsLeftRight(value, out bits32);
        Array.Reverse(bits32);
    }


    public static void ParseGamepadExtraByteId2020FromInteger(int value, out GamepadId2020Extra pad)
    {
        int elementId = value / 100000000;
        GetIntegerAs32BitsRightLeft(value, out bool[] bits32);
        pad = new GamepadId2020Extra();
        pad.m_id2020 = (sbyte) elementId;
        pad.m_00_buttonUp = bits32[0];
        pad.m_01_buttonDown = bits32[1];
        pad.m_02_buttonLeft = bits32[2];
        pad.m_03_buttonRight = bits32[3];
        pad.m_04_buttonShouldLeft = bits32[4];
        pad.m_05_buttonShouldRight = bits32[5];
        pad.m_06_buttonJoystickLeft = bits32[6];
        pad.m_07_buttonJoystickRight = bits32[7];
        pad.m_08_arrowUp = bits32[8];
        pad.m_09_arrowDown = bits32[9];
        pad.m_10_arrowLeft = bits32[10];
        pad.m_11_arrowRight = bits32[11];
        pad.m_12_menuLeft = bits32[12];
        pad.m_13_menuRight = bits32[13];
        pad.m_14_triggerLeft = bits32[14];
        pad.m_15_triggerRight = bits32[15];
        pad.m_16_triggerRightLow = bits32[16];
        pad.m_17_triggerRightMiddle = bits32[17];
        pad.m_18_triggerRightFull  = bits32[18];
        pad.m_19_triggerLeftLow  = bits32[19];
        pad.m_20_triggerLeftMiddle = bits32[20];
        pad.m_21_triggerLeftFull = bits32[21];
        pad.m_22_menuCenter  = bits32[22];
        pad.m_23_isConnected = bits32[23];
    }
}
