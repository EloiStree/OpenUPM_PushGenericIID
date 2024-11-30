using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class IntegerToOculusGamepads2020Utility
{

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
    public static void GetIntegerAs32BitsRightLeft(int value, out string text)
    {
        GetIntegerAs32BitsLeftRight(value, out bool [] bits32);
        Array.Reverse(bits32);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 32; i++)
        {
            sb.Append(bits32[i] ? "1" : "0");
        }
        text = sb.ToString();
    }


    public static void Parse(ref STRUCT_QuestGamepads2020 gamepadData, ref STRUCT_QuestGamepadsRawInt2020 gamepadRawData)
    {

        gamepadRawData.m_buttonsState = 0;
        gamepadRawData.m_axisState = 0;

        gamepadRawData.SetBitState(0, gamepadData.m_brl0_topLeft);
        gamepadRawData.SetBitState(1, gamepadData.m_brl1_topRight);
        gamepadRawData.SetBitState(2, gamepadData.m_brl2_downLeft);
        gamepadRawData.SetBitState(3, gamepadData.m_brl3_downRight);
        gamepadRawData.SetBitState(4, gamepadData.m_brl4_joystickLeft);
        gamepadRawData.SetBitState(5, gamepadData.m_brl5_joystickRight);
        gamepadRawData.SetBitState(6, gamepadData.m_brl6_thumbRestLeft);
        gamepadRawData.SetBitState(7, gamepadData.m_brl7_thumbRestRight);

        gamepadRawData.SetBitState(8, gamepadData.m_brl8_topLeftTouch);
        gamepadRawData.SetBitState(9, gamepadData.m_brl9_topRightTouch);
        gamepadRawData.SetBitState(10, gamepadData.m_brl10_downLeftTouch);
        gamepadRawData.SetBitState(11, gamepadData.m_brl11_downRightTouch);
        gamepadRawData.SetBitState(12, gamepadData.m_brl12_joystickLeftTouch);
        gamepadRawData.SetBitState(13, gamepadData.m_brl13_joystickRightTouch);
        gamepadRawData.SetBitState(14, gamepadData.m_brl14_triggerLeftTouch);
        gamepadRawData.SetBitState(15, gamepadData.m_brl15_triggerRightTouch);

        gamepadRawData.SetBitState(16, gamepadData.m_brl16_menuLeft);
        gamepadRawData.SetBitState(17, gamepadData.m_brl17_menuRight);
        gamepadRawData.SetBitState(18, gamepadData.m_brl18_isLeftTracked);
        gamepadRawData.SetBitState(19, gamepadData.m_brl19_isRightTracked);
        gamepadRawData.SetBitState(20, gamepadData.m_brl20_isTriggerLeftPressing);
        gamepadRawData.SetBitState(21, gamepadData.m_brl21_isTriggerRightPressing);
        gamepadRawData.SetBitState(22, gamepadData.m_brl22_isGripLeftPressing);
        gamepadRawData.SetBitState(23, gamepadData.m_brl23_isGripRightPressing);


        gamepadRawData.SetAxisState(0, gamepadData.m_lr0_leftHorizontal11);
        gamepadRawData.SetAxisState(1, gamepadData.m_lr1_leftVertical11);
        gamepadRawData.SetAxisState(2, gamepadData.m_lr2_rightHorizontal11);
        gamepadRawData.SetAxisState(3, gamepadData.m_lr3_rightVertical11);
        gamepadRawData.SetAxisState(4, gamepadData.m_lr4_triggerLeft01);
        gamepadRawData.SetAxisState(5, gamepadData.m_lr5_triggerRight01);
        gamepadRawData.SetAxisState(6, gamepadData.m_lr6_gripLeft01);
        gamepadRawData.SetAxisState(7, gamepadData.m_lr7_gripRight01);

    }

    public static void Parse(ref STRUCT_QuestGamepadsRawInt2020 gamepadRawData, ref STRUCT_QuestGamepads2020 gamepadData)
    {
        gamepadRawData.GetAxisState(0, out gamepadData.m_lr0_leftHorizontal11);
        gamepadRawData.GetAxisState(1, out gamepadData.m_lr1_leftVertical11);
        gamepadRawData.GetAxisState(2, out gamepadData.m_lr2_rightHorizontal11);
        gamepadRawData.GetAxisState(3, out gamepadData.m_lr3_rightVertical11);
        gamepadRawData.GetAxisState(4, out gamepadData.m_lr4_triggerLeft01);
        gamepadRawData.GetAxisState(5, out gamepadData.m_lr5_triggerRight01);
        gamepadRawData.GetAxisState(6, out gamepadData.m_lr6_gripLeft01);
        gamepadRawData.GetAxisState(7, out gamepadData.m_lr7_gripRight01);
        gamepadRawData.GetBitState(0,  out gamepadData.m_brl0_topLeft);
        gamepadRawData.GetBitState(1,  out gamepadData.m_brl1_topRight);
        gamepadRawData.GetBitState(2,  out gamepadData.m_brl2_downLeft);
        gamepadRawData.GetBitState(3,  out gamepadData.m_brl3_downRight);
        gamepadRawData.GetBitState(4,  out gamepadData.m_brl4_joystickLeft);
        gamepadRawData.GetBitState(5,  out gamepadData.m_brl5_joystickRight);
        gamepadRawData.GetBitState(6,  out gamepadData.m_brl6_thumbRestLeft);
        gamepadRawData.GetBitState(7,  out gamepadData.m_brl7_thumbRestRight);
        gamepadRawData.GetBitState(8,  out gamepadData.m_brl8_topLeftTouch);
        gamepadRawData.GetBitState(9,  out gamepadData.m_brl9_topRightTouch);
        gamepadRawData.GetBitState(10, out gamepadData.m_brl10_downLeftTouch);
        gamepadRawData.GetBitState(11, out gamepadData.m_brl11_downRightTouch);
        gamepadRawData.GetBitState(12, out gamepadData.m_brl12_joystickLeftTouch);
        gamepadRawData.GetBitState(13, out gamepadData.m_brl13_joystickRightTouch);
        gamepadRawData.GetBitState(14, out gamepadData.m_brl14_triggerLeftTouch);
        gamepadRawData.GetBitState(15, out gamepadData.m_brl15_triggerRightTouch);
        gamepadRawData.GetBitState(16, out gamepadData.m_brl16_menuLeft);
        gamepadRawData.GetBitState(17, out gamepadData.m_brl17_menuRight);
        gamepadRawData.GetBitState(18, out gamepadData.m_brl18_isLeftTracked);
        gamepadRawData.GetBitState(19, out gamepadData.m_brl19_isRightTracked);
        gamepadRawData.GetBitState(20, out gamepadData.m_brl20_isTriggerLeftPressing);
        gamepadRawData.GetBitState(21, out gamepadData.m_brl21_isTriggerRightPressing);
        gamepadRawData.GetBitState(22, out gamepadData.m_brl22_isGripLeftPressing);
        gamepadRawData.GetBitState(23, out gamepadData.m_brl23_isGripRightPressing);
    }

    public static void SetFromInteger( int possibleIntegerCommand, ref STRUCT_QuestGamepadsRawInt2020 gamepadRawData)
    {
        int tag = possibleIntegerCommand / 100000000;
       // Debug.Log("tag " + tag);
        if (tag == 10)
        {
            gamepadRawData.m_buttonsState = (possibleIntegerCommand%100000000);
            gamepadRawData.m_buttonsStateWithTag = gamepadRawData.m_buttonsState + 1000000000;
        }
        else if (tag == 11)
        {
            gamepadRawData.m_axisState = (possibleIntegerCommand % 100000000);
            gamepadRawData.m_axisStateWithTag = gamepadRawData.m_axisState + 1100000000;
        }
    }
}

[System.Serializable]
public class QuestGamepads2020 : I_QuestGamepadSetGet {
    public STRUCT_QuestGamepadsRawInt2020 m_gamepadAsRawValue;
    [Tooltip("This is here just for human to debug the raw value of the gamepad as a double integer")]
    public STRUCT_QuestGamepads2020 m_gamepadHumanValue;


    public void RefreshDebug() {
        IntegerToOculusGamepads2020Utility.Parse(ref m_gamepadAsRawValue, ref m_gamepadHumanValue);
    }

    public bool GetDownLeft() => m_gamepadHumanValue.m_brl2_downLeft;

    public bool GetDownLeftTouch() => m_gamepadHumanValue.m_brl10_downLeftTouch;

    public bool GetDownRight() => m_gamepadHumanValue.m_brl3_downRight;


    public bool GetDownRightTouch() => m_gamepadHumanValue.m_brl11_downRightTouch;


    public float GetGripLeft() => m_gamepadHumanValue.m_lr6_gripLeft01;


    public float GetGripRight() => m_gamepadHumanValue.m_lr7_gripRight01;


    public bool GetIsGripLeftPressing() => m_gamepadHumanValue.m_brl22_isGripLeftPressing;

    public bool GetIsGripRightPressing() => m_gamepadHumanValue.m_brl23_isGripRightPressing;

    public bool GetIsLeftTracked() => m_gamepadHumanValue.m_brl18_isLeftTracked;

    public bool GetIsRightTracked() => m_gamepadHumanValue.m_brl19_isRightTracked;

    public bool GetIsTriggerLeftPressing() => m_gamepadHumanValue.m_brl20_isTriggerLeftPressing;
    public bool GetIsTriggerRightPressing() => m_gamepadHumanValue.m_brl21_isTriggerRightPressing;
    public bool GetJoystickLeft() => m_gamepadHumanValue.m_brl4_joystickLeft;
    public bool GetJoystickLeftTouch() => m_gamepadHumanValue.m_brl12_joystickLeftTouch;
    public bool GetJoystickRight() => m_gamepadHumanValue.m_brl5_joystickRight;
    public bool GetJoystickRightTouch() => m_gamepadHumanValue.m_brl13_joystickRightTouch;
    public float GetLeftHorizontal() => m_gamepadHumanValue.m_lr0_leftHorizontal11;
    public float GetLeftVertical() => m_gamepadHumanValue.m_lr1_leftVertical11;

    public bool GetMenuLeft() => m_gamepadHumanValue.m_brl16_menuLeft;

    public bool GetMenuRight() => m_gamepadHumanValue.m_brl17_menuRight;

    public float GetRightHorizontal() => m_gamepadHumanValue.m_lr2_rightHorizontal11;

    public float GetRightVertical() => m_gamepadHumanValue.m_lr3_rightVertical11;

    public bool GetThumbRestLeft() => m_gamepadHumanValue.m_brl6_thumbRestLeft;

    public bool GetThumbRestRight() => m_gamepadHumanValue.m_brl7_thumbRestRight;

    public bool GetTopLeft() => m_gamepadHumanValue.m_brl0_topLeft;

    public bool GetTopLeftTouch() => m_gamepadHumanValue.m_brl8_topLeftTouch;

    public bool GetTopRight() => m_gamepadHumanValue.m_brl1_topRight;
    public bool GetTopRightTouch() => m_gamepadHumanValue.m_brl9_topRightTouch;

    public float GetTriggerLeft() => m_gamepadHumanValue.m_lr4_triggerLeft01;
    public bool GetTriggerLeftTouch() => m_gamepadHumanValue.m_brl14_triggerLeftTouch;

    public float GetTriggerRight() => m_gamepadHumanValue.m_lr5_triggerRight01;
    public bool GetTriggerRightTouch() => m_gamepadHumanValue.m_brl15_triggerRightTouch;

    public void SetDownLeft(bool value)
    {
        if(m_gamepadHumanValue.m_brl2_downLeft == value) return;
        m_gamepadHumanValue.m_brl2_downLeft = value;
        RefreshHumanValueToRawInteger();
    }

    public void RefreshHumanValueToRawInteger()
    {
        IntegerToOculusGamepads2020Utility.Parse(ref m_gamepadHumanValue, ref m_gamepadAsRawValue);
    }
    public void RefreshHumanValueFromRawInteger()
    {
        IntegerToOculusGamepads2020Utility.Parse(ref m_gamepadAsRawValue, ref m_gamepadHumanValue);
    }

    public void SetDownLeftTouch(bool value) { 
        if(m_gamepadHumanValue.m_brl10_downLeftTouch == value) return;
        m_gamepadHumanValue.m_brl10_downLeftTouch = value; 
        RefreshHumanValueToRawInteger();

    }

    public void SetDownRight(bool value)
    {
        if(m_gamepadHumanValue.m_brl3_downRight == value) return;
        m_gamepadHumanValue.m_brl3_downRight = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetDownRightTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl11_downRightTouch == value) return;
        m_gamepadHumanValue.m_brl11_downRightTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetGripLeft(float value)
    {
        if(m_gamepadHumanValue.m_lr6_gripLeft01 == value) return;
        m_gamepadHumanValue.m_lr6_gripLeft01 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetGripRight(float value)
    {
        if(m_gamepadHumanValue.m_lr7_gripRight01 == value) return;
        m_gamepadHumanValue.m_lr7_gripRight01 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsGripLeftPressing(bool value)
    {
        if(m_gamepadHumanValue.m_brl22_isGripLeftPressing == value) return;
        m_gamepadHumanValue.m_brl22_isGripLeftPressing = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsGripRightPressing(bool value)
    {
        if(m_gamepadHumanValue.m_brl23_isGripRightPressing == value) return;
        m_gamepadHumanValue.m_brl23_isGripRightPressing = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsLeftTracked(bool value)
    {
        if(m_gamepadHumanValue.m_brl18_isLeftTracked == value) return;
        m_gamepadHumanValue.m_brl18_isLeftTracked = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsRightTracked(bool value)
    {
        if(m_gamepadHumanValue.m_brl19_isRightTracked == value) return;
        m_gamepadHumanValue.m_brl19_isRightTracked = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsTriggerLeftPressing(bool value)
    {
        if(m_gamepadHumanValue.m_brl20_isTriggerLeftPressing == value) return;
        m_gamepadHumanValue.m_brl20_isTriggerLeftPressing = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetIsTriggerRightPressing(bool value)
    {
        if(m_gamepadHumanValue.m_brl21_isTriggerRightPressing == value) return;
        m_gamepadHumanValue.m_brl21_isTriggerRightPressing = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetJoystickLeft(bool value)
    {
        if(m_gamepadHumanValue.m_brl4_joystickLeft == value) return;
        m_gamepadHumanValue.m_brl4_joystickLeft = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetJoystickLeftTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl12_joystickLeftTouch == value) return;
        m_gamepadHumanValue.m_brl12_joystickLeftTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetJoystickRight(bool value)
    {
        if(m_gamepadHumanValue.m_brl5_joystickRight == value) return;
        m_gamepadHumanValue.m_brl5_joystickRight = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetJoystickRightTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl13_joystickRightTouch == value) return;
        m_gamepadHumanValue.m_brl13_joystickRightTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetLeftHorizontal(float value)
    {
        if(m_gamepadHumanValue.m_lr0_leftHorizontal11 == value) return;
        m_gamepadHumanValue.m_lr0_leftHorizontal11 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetLeftVertical(float value)
    {
        if(m_gamepadHumanValue.m_lr1_leftVertical11 == value) return;
        m_gamepadHumanValue.m_lr1_leftVertical11 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetMenuLeft(bool value)
    {
        if(m_gamepadHumanValue.m_brl16_menuLeft == value) return;
        m_gamepadHumanValue.m_brl16_menuLeft = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetMenuRight(bool value)
    {
        if(m_gamepadHumanValue.m_brl17_menuRight == value) return;
        m_gamepadHumanValue.m_brl17_menuRight = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetRightHorizontal(float value)
    {
        if(m_gamepadHumanValue.m_lr2_rightHorizontal11 == value) return;
        m_gamepadHumanValue.m_lr2_rightHorizontal11 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetRightVertical(float value)
    {
        if(m_gamepadHumanValue.m_lr3_rightVertical11 == value) return;
        m_gamepadHumanValue.m_lr3_rightVertical11 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetThumbRestLeft(bool value)
    {
        if(m_gamepadHumanValue.m_brl6_thumbRestLeft == value) return;
        m_gamepadHumanValue.m_brl6_thumbRestLeft = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetThumbRestRight(bool value)
    {
        if(m_gamepadHumanValue.m_brl7_thumbRestRight == value) return;
        m_gamepadHumanValue.m_brl7_thumbRestRight = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTopLeft(bool value)
    {
        if(m_gamepadHumanValue.m_brl0_topLeft == value) return;
        m_gamepadHumanValue.m_brl0_topLeft = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTopLeftTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl8_topLeftTouch == value) return;
        m_gamepadHumanValue.m_brl8_topLeftTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTopRight(bool value)
    {
        if(m_gamepadHumanValue.m_brl1_topRight == value) return;
        m_gamepadHumanValue.m_brl1_topRight = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTopRightTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl9_topRightTouch == value) return;
        m_gamepadHumanValue.m_brl9_topRightTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTriggerLeft(float value)
    {
        if(m_gamepadHumanValue.m_lr4_triggerLeft01 == value) return;
        m_gamepadHumanValue.m_lr4_triggerLeft01 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTriggerLeftTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl14_triggerLeftTouch == value) return;
        m_gamepadHumanValue.m_brl14_triggerLeftTouch = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTriggerRight(float value)
    {
        if(m_gamepadHumanValue.m_lr5_triggerRight01 == value) return;
        m_gamepadHumanValue.m_lr5_triggerRight01 = value;
        RefreshHumanValueToRawInteger();
    }

    public void SetTriggerRightTouch(bool value)
    {
        if(m_gamepadHumanValue.m_brl15_triggerRightTouch == value) return;
        m_gamepadHumanValue.m_brl15_triggerRightTouch = value;
        RefreshHumanValueToRawInteger();
    }

   
}


public interface I_QuestGamepadSetGet : I_QuestGamepadsGet, I_QuestGamepadsSet { }
public interface I_QuestGamepadsSet { 

    public void SetLeftHorizontal(float value);
    public void SetLeftVertical(float value);
    public void SetRightHorizontal(float value);
    public void SetRightVertical(float value);
    public void SetTriggerLeft(float value);
    public void SetTriggerRight(float value);
    public void SetGripLeft(float value);
    public void SetGripRight(float value);

    public void SetTopLeft(bool value);
    public void SetTopRight(bool value);
    public void SetDownLeft(bool value);
    public void SetDownRight(bool value);
    public void SetJoystickLeft(bool value);
    public void SetJoystickRight(bool value);
    public void SetThumbRestLeft(bool value);
    public void SetThumbRestRight(bool value);
    public void SetTopLeftTouch(bool value);
    public void SetTopRightTouch(bool value);
    public void SetDownLeftTouch(bool value);
    public void SetDownRightTouch(bool value);
    public void SetJoystickLeftTouch(bool value);
    public void SetJoystickRightTouch(bool value);
    public void SetTriggerLeftTouch(bool value);
    public void SetTriggerRightTouch(bool value);
    public void SetMenuLeft(bool value);
    public void SetMenuRight(bool value);
    public void SetIsLeftTracked(bool value);
    public void SetIsRightTracked(bool value);
    public void SetIsTriggerLeftPressing(bool value);
    public void SetIsTriggerRightPressing(bool value);
    public void SetIsGripLeftPressing(bool value);
    public void SetIsGripRightPressing(bool value);

}

public interface I_QuestGamepadsGet { 

    public float GetLeftHorizontal();
    public float GetLeftVertical();
    public float GetRightHorizontal();
    public float GetRightVertical();
    public float GetTriggerLeft();
    public float GetTriggerRight();
    public float GetGripLeft();
    public float GetGripRight();

    public bool GetTopLeft();
    public bool GetTopRight();
    public bool GetDownLeft();
    public bool GetDownRight();
    public bool GetJoystickLeft();
    public bool GetJoystickRight();
    public bool GetThumbRestLeft();
    public bool GetThumbRestRight();
    public bool GetTopLeftTouch();
    public bool GetTopRightTouch();
    public bool GetDownLeftTouch();
    public bool GetDownRightTouch();
    public bool GetJoystickLeftTouch();
    public bool GetJoystickRightTouch();
    public bool GetTriggerLeftTouch();
    public bool GetTriggerRightTouch();
    public bool GetMenuLeft();
    public bool GetMenuRight();
    public bool GetIsLeftTracked();
    public bool GetIsRightTracked();
    public bool GetIsTriggerLeftPressing();
    public bool GetIsTriggerRightPressing();
    public bool GetIsGripLeftPressing();
    public bool GetIsGripRightPressing();

}



[System.Serializable]
public struct STRUCT_QuestGamepadsRawInt2020
{
    [Header("10 11111111 1111111 111111 buttons ")]
    [Tooltip("10 is the default 20 tag, the 3 bytes 24 bits are buttons state")]
    public int m_buttonsState;
    public int m_buttonsStateWithTag ;

    [Header("11 1 2 3 4 5 6 7 8 from 0 to 9")]
    [Tooltip("11 is the default 20 tag, the 8 digits are the axis state 0 + 1-9 value ")]
    public int m_axisState;
    public int m_axisStateWithTag ;
    public void GetBitState(int bitIndexRightLeft, out bool isTrueValue)
    {
        isTrueValue= (m_buttonsState & (1 << bitIndexRightLeft)) != 0;
    }

    public void SetBitState(int bitIndexRightLeft, bool isTrueValue)
    {
        
        if (isTrueValue)
        {
            m_buttonsState |= 1 << bitIndexRightLeft;
        }
        else
        {
            m_buttonsState &= ~(1 << bitIndexRightLeft);
        }
        m_buttonsStateWithTag = 1000000000 + m_buttonsState;
    }

    public void GetAxisState(int bitIndexLeftRight, out float percentValue)
    {
        // Extract the digit at the specified position (using base-10 logic)
        int digitValue = (int)(m_axisState / IntegerPow10(7 - bitIndexLeftRight)) % 10;
        if (digitValue == 0)
        { 
            percentValue = 0;
            return;
        }

        if(bitIndexLeftRight<4)
        {
            percentValue = ((((digitValue-1.0f)/ 8.0f) *2f)-1);
        }
        else
        {
            percentValue = (digitValue- 1.0f) / 8f;
        }

        
    }

    public void SetAxisState(int indexLeftRight, float percentValue)
    {
        int digitValue = 0;

        if (indexLeftRight < 4)
        {
            percentValue = (percentValue + 1f) / 2f;
        }

        if (percentValue == 0.5f)
            digitValue = 5;
        else
            digitValue = (int)(1 + (Mathf.Round(percentValue * 8)));

        int currentDigit = (int)(m_axisState / IntegerPow10(7 - indexLeftRight)) % 10; // Use base-10

        int newValue = m_axisState
            - (currentDigit * IntegerPow10(7 - indexLeftRight ))  // Remove old digit
            + (digitValue * IntegerPow10( 7 - indexLeftRight ));  // Add new digit

        m_axisState = newValue;
        m_axisStateWithTag = 1100000000 + m_axisState;
    }

    public int IntegerPow10(int value )
    {
        int result = 1;
        for (int i = 0; i < value; i++)
        {
            result *= 10;
        }
        return result;
    }
}


[System.Serializable]
public struct STRUCT_QuestGamepads2020 {

    [Header("t(10) 12345678 from 0 to 9")]
    [Range(-1f,1f)]
    public float m_lr0_leftHorizontal11;
    [Range(-1f, 1f)]
    public float m_lr1_leftVertical11;
    [Range(-1f, 1f)]
    public float m_lr2_rightHorizontal11;
    [Range(-1f, 1f)]
    public float m_lr3_rightVertical11;
    [Range(0, 1f)]
    public float m_lr4_triggerLeft01;
    [Range(0, 1f)]
    public float m_lr5_triggerRight01;
    [Range(0, 1f)]
    public float m_lr6_gripLeft01;
    [Range(0, 1f)]
    public float m_lr7_gripRight01;

    [Header("t(11) 00000000 00000000 11111111")]
    public bool m_brl0_topLeft;
    public bool m_brl1_topRight;
    public bool m_brl2_downLeft;
    public bool m_brl3_downRight;
    public bool m_brl4_joystickLeft;
    public bool m_brl5_joystickRight;
    public bool m_brl6_thumbRestLeft;
    public bool m_brl7_thumbRestRight;

    [Header("t(11) 00000000 11111111 00000000")]
    public bool m_brl8_topLeftTouch;
    public bool m_brl9_topRightTouch;
    public bool m_brl10_downLeftTouch;
    public bool m_brl11_downRightTouch;
    public bool m_brl12_joystickLeftTouch;
    public bool m_brl13_joystickRightTouch;
    public bool m_brl14_triggerLeftTouch;
    public bool m_brl15_triggerRightTouch;

    [Header("t(11) 11111111 00000000 00000000")]
    public bool m_brl16_menuLeft;
    public bool m_brl17_menuRight;
    public bool m_brl18_isLeftTracked;
    public bool m_brl19_isRightTracked;
    public bool m_brl20_isTriggerLeftPressing;
    public bool m_brl21_isTriggerRightPressing;
    public bool m_brl22_isGripLeftPressing;
    public bool m_brl23_isGripRightPressing;





//10 12345678
//b(10) +8 0-9 digits
//Integer Axis state
//LeftHorizontal
//LeftVertical
//RightHorizontal
//RightVertical
//TriggerLeft
//TriggerRight
//GripLeft
//GripRight


//    b(11) + 3 bytes Quest Controller buttons state
//11111111 11111111 11111111

    //TopLeft
    //TopRight
    //DownLeft
    //DownRight
    //JoystickLeft
    //JoystickRight
    //ThumbRestLeft
    //ThumbRestRight

    //TopLeftTouch
    //TopRightTouch
    //DownLeftTouch
    //DownRightTouch
    //JoystickLeftTouch
    //JoystickRightTouch
    //TriggerLeftTouch
    //TriggerLeftTouch

    //MenuLeft
    //MenuRight
    //IsLeftTracked
    //IsRightTracked
    //IsTriggerLeftPressing
    //IsTriggerRightPressing
    //IsGripLeftPressing
    //IsGripRightPressing



    //(9) OpenXR Values
    //OpenXR Type value short value
    //Byte Byte                Value as short
    //009     001 LeftHorizontal      -+32767        
    //009     002 RightHorizontal     -+32767        
    //009     003 RightHorizontal	-+32767
    //009     004 RightVertical	-+32767
    //009     005 TriggerLeft		65535
    //009     006 TriggerRight	65535
    //009     007 GripLeft		65535
    //009     008 GripRight		65535
    //009     009 Position Left X     -+32767
    //009     010 Position Left Y     -+32767
    //009     011 Position Left Z     -+32767
    //009     012 Position Right X     -+32767
    //009     013 Position Right Y     -+32767
    //009     014 Position Right Z     -+32767
    //009     015 Position Center X     -+32767
    //009     016 Position Center Y     -+32767
    //009     017 Position Center Z     -+32767

    //// Rotation on two byte ?
    //1111 1111 1111 1111 Quaternion x y z w 0 to 16? 
    //0 11111 11111 11111 Euleur x y z 0 to 32 ? 
    //https://www.researchgate.net/figure/A-circumference-divided-into-32-2-5-congruent-segments_fig2_318940402

    //009     018 Left Controller Euler x y z 0 to 32 11111
    //009     019 Right Controller Euler x y z 0 to 32 11111
    //009     020 Left Hand Euler x y z 0 to 32 11111
    //009     021 Right Hand Euler x y z 0 to 32 11111
    //009     022 Center Controller Euler x y z 0 to 32 11111
    //009     023 Left Index Direction Euler  x y z 0 to 32 11111
    //009     024 Right Index Direction Euler  x y z 0 to 32 11111

    //// Hand tip position
    //0-255 mm from the center

    //009     009 Position Index Tip Left  X     -+32767
    //009     010 Position Index Tip Left  Y     -+32767
    //009     011 Position Index Tip Left  Z     -+32767
    //009     012 Position Index Tip Right X     -+32767
    //009     013 Position Index Tip Right Y     -+32767
    //009     014 Position Index Tip Right Z     -+32767















}
