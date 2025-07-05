using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Int1899 { 

    public class Int1899Mono_PushOneDualStickAsInt : MonoBehaviour {

        public STRUCT_16DualStick m_playerGamepad;
        [Range(0, 1)]
        public float m_leftTriggerPercent01 = 0.0f;
        [Range(0, 1)]
        public float m_rightTriggerPercent01 = 0.0f;
        public UnityEvent<int> m_onIntChanged;
        public bool m_useOnValidate = true;


    private void OnValidate()
    {
        if (m_useOnValidate)
            RefreshAndPush();
    }

    public byte m_type_scratchToWarcraftCommand = 19;
    public int m_lastScratchToWarcraftCommand = 0;



    [Header("TAG 9 9 9 9 9 9")]
    public bool m_useCompressAxisAndTrigger = true;
    public byte m_type_setJoystick999999AxisAndTrigger = 20;

    [Header("VALUE 9 9 9 9 9 9")]
    public int m_value_setJoystick999999AxisAndTrigger = 0;

    [Header("TAG 999 999")]
    public bool m_useCompressLeftRightXY = true;
    public byte m_type_setJoystick999LeftXY = 21;
    public byte m_type_setJoystick999RightXY = 22;

    [Header("VALUE 999 999")]
    public int m_value_setJoystick999LeftXY = 0;
    public int m_value_setJoystick999RightXY = 0;

    [Header("TAG 999999")]
    public bool m_useFourIntegerForLeftRight = true;
    public byte m_type_setJoystick999999LeftX = 23;
    public byte m_type_setJoystick999999LeftY = 24;
    public byte m_type_setJoystick999999RightX = 25;
    public byte m_type_setJoystick999999RightY = 26;
    public byte m_type_setTrigger999999Left = 27;
    public byte m_type_setTrigger999999Right = 28;

    [Header("VALUE 999999")]
    public int m_value_setJoystick999999LeftX = 0;
    public int m_value_setJoystick999999LeftY = 0;
    public int m_value_setJoystick999999RightX = 0;
    public int m_value_setJoystick999999RightY = 0;
    public int m_value_setTrigger999999Left = 0;
    public int m_value_setTrigger999999Right = 0;


    [ContextMenu("Tap Gamepad B")]
    public void TapGamepadB()=>TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressB);

    [ContextMenu("Tap Gamepad A")]
    public void TapGamepadA() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressA);

    [ContextMenu("Tap Gamepad X")]
    public void TapGamepadX() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressX);

    [ContextMenu("Tap Gamepad Y")]
    public void TapGamepadY() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressY);

    [ContextMenu("Tap Gamepad Left Side Button")]
    public void TapGamepadLeftSideButton() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressLeftSideButton);

    [ContextMenu("Tap Gamepad Right Side Button")]
    public void TapGamepadRightSideButton() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressRightSideButton);

        [ContextMenu("Tap Gamepad Left Stick")]
        public void TapGamepadLeftStick() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressLeftStick);

        [ContextMenu("Tap Gamepad Right Stick")]
        public void TapGamepadRightStick() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressRightStick);

        [ContextMenu("Tap Gamepad Menu Right")]
        public void TapGamepadMenuRight() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressMenuRight);

        [ContextMenu("Tap Gamepad Menu Left")]
        public void TapGamepadMenuLeft() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressMenuLeft);

        [ContextMenu("Tap Arrow North")]
        public void TapGamepadArrowNorth() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressArrowNorth);

        [ContextMenu("Tap Arrow East")]

        public void TapGamepadArrowEast() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressArrowEast);

        [ContextMenu("Tap Arrow South")]
        public void TapGamepadArrowSouth() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressArrowSouth);

        [ContextMenu("Tap Arrow West")]
        public void TapGamepadArrowWest() => TapScratchToWarcraftKey(EnumScratchToWarcraftGamepad.PressArrowWest);





   
    public void TapScratchToWarcraftKey( EnumScratchToWarcraftGamepad action)
    { 
    
        StartCoroutine(Coroutine_TapScratchToWarcraftKey((int)action));

    }

        public float m_timeBetweenPresses = 2; 
        public IEnumerator Coroutine_TapScratchToWarcraftKey(int commandKeyPress)
    {
        PushScratchToWarcraftCommand999999(commandKeyPress);
        yield return new WaitForSeconds(m_timeBetweenPresses);
        PushScratchToWarcraftCommand999999(commandKeyPress+1000); 
    }
    public void PushScratchToWarcraftCommand999999(int value) {


        Int1899Parser.TagIntegerWithPlayerAndType( 
            ref value,
            m_playerGamepad.m_playerId1To16,
            m_type_scratchToWarcraftCommand
             );
        m_lastScratchToWarcraftCommand = value;
        m_onIntChanged?.Invoke(value);
    }


    public void PushInPressAction
        (EnumScratchToWarcraftGamepad action)
    {
        int value =(int)action;
        PushScratchToWarcraftCommand999999(value);
    }
    public void PushInReleaseAction
        (EnumScratchToWarcraftGamepad action)
    {
        int value = (int)action;
        PushScratchToWarcraftCommand999999(value+1000);
    }




    [ContextMenu("Refresh And Push")]
    public void RefreshAndPush()
        {
            PushAsSingleInt();
            PushAsDoubleIntegerIfChanged();
            PushAsFourIntegerIfChanged();

            PushAsTriggerIfChanged();
        }

        private void PushAsTriggerIfChanged()
        {
            Int1899Parser.ToIntFloatToPercent01To999999(
                 out int leftTrigger999999,
                    m_playerGamepad.m_playerId1To16,
                    m_type_setTrigger999999Left,
                    m_leftTriggerPercent01
                    );
            PushIfChangeAndStore(ref m_value_setTrigger999999Left, leftTrigger999999);
            Int1899Parser.ToIntFloatToPercent01To999999(
                out int rightTrigger999999,
                m_playerGamepad.m_playerId1To16,
                m_type_setTrigger999999Right,
                m_rightTriggerPercent01
            );
            PushIfChangeAndStore(ref m_value_setTrigger999999Right, rightTrigger999999);
        }

        private void PushAsSingleInt()
    {
        if (!m_useCompressAxisAndTrigger)
            return;
        Int1899Parser.ToIntJoystickAndTrigger999999(
                    out int joystick99999AxisTrigger,
                    m_playerGamepad.m_playerId1To16,
                    m_type_setJoystick999999AxisAndTrigger,
                    m_playerGamepad.m_dualStick.m_leftJoystickXPercent11,
                    m_playerGamepad.m_dualStick.m_leftJoystickYPercent11,
                    m_playerGamepad.m_dualStick.m_rightJoystickXPercent11,
                    m_playerGamepad.m_dualStick.m_rightJoystickYPercent11,
                    0,
                    0
                    );
        if (m_value_setJoystick999999AxisAndTrigger != joystick99999AxisTrigger)
        {
            m_value_setJoystick999999AxisAndTrigger = joystick99999AxisTrigger;
            m_onIntChanged?.Invoke(m_value_setJoystick999999AxisAndTrigger);
        }
    }

    private void PushAsFourIntegerIfChanged()
    {
        if (!m_useFourIntegerForLeftRight)
            return;
        Int1899Parser.ToIntFloatToPercent11To999999(
                    out int leftX999999,
                    m_playerGamepad.m_playerId1To16,
                    m_type_setJoystick999999LeftX,
                    m_playerGamepad.m_dualStick.m_leftJoystickXPercent11
                );

        Int1899Parser.ToIntFloatToPercent11To999999(
            out int leftY999999,
            m_playerGamepad.m_playerId1To16,
            m_type_setJoystick999999LeftY,
            m_playerGamepad.m_dualStick.m_leftJoystickYPercent11
            );
        Int1899Parser.ToIntFloatToPercent11To999999(
            out int rightX999999,
            m_playerGamepad.m_playerId1To16,
            m_type_setJoystick999999RightX,
            m_playerGamepad.m_dualStick.m_rightJoystickXPercent11
        );
        Int1899Parser.ToIntFloatToPercent11To999999(
            out int rightY999999,
            m_playerGamepad.m_playerId1To16,
            m_type_setJoystick999999RightY,
            m_playerGamepad.m_dualStick.m_rightJoystickYPercent11
        );
        PushIfChangeAndStore(ref m_value_setJoystick999999LeftX, leftX999999);
        PushIfChangeAndStore(ref m_value_setJoystick999999LeftY, leftY999999);
        PushIfChangeAndStore(ref m_value_setJoystick999999RightX, rightX999999);
        PushIfChangeAndStore(ref m_value_setJoystick999999RightY, rightY999999);
    }

    private void PushAsDoubleIntegerIfChanged()
    {
        if (!m_useCompressLeftRightXY)
            return;
        Int1899Parser.ToIntFloatToDoublePercent999999(
            out int leftXY999999,
            m_playerGamepad.m_playerId1To16,
            m_type_setJoystick999LeftXY,
            m_playerGamepad.m_dualStick.m_leftJoystickXPercent11,
            m_playerGamepad.m_dualStick.m_leftJoystickYPercent11
        );
        Int1899Parser.ToIntFloatToDoublePercent999999(
            out int rightXY999999,
            m_playerGamepad.m_playerId1To16,
            m_type_setJoystick999RightXY,
            m_playerGamepad.m_dualStick.m_rightJoystickXPercent11,
            m_playerGamepad.m_dualStick.m_rightJoystickYPercent11
        );

        PushIfChangeAndStore(ref m_value_setJoystick999LeftXY, leftXY999999);
        PushIfChangeAndStore(ref m_value_setJoystick999RightXY, rightXY999999);
    }

    public void  PushIfChangeAndStore(ref int valueToCheck, int newValue)
    {
        if (valueToCheck != newValue)
        {
            valueToCheck = newValue;
            m_onIntChanged?.Invoke(valueToCheck);
        }
    }

    public void SetJoystickLeftX(float percent11)
    {
        m_playerGamepad.m_dualStick.m_leftJoystickXPercent11 = Mathf.Clamp(percent11, -1, 1);
        RefreshAndPush();
    }

    

    public void SetJoystickLeftY(float percent11)
    {

     m_playerGamepad.m_dualStick.m_leftJoystickYPercent11 = Mathf.Clamp(percent11, -1, 1);
        RefreshAndPush();
    }

    public void SetJoystickRightX(float percent11)
    {

     m_playerGamepad.m_dualStick.m_rightJoystickXPercent11 = Mathf.Clamp(percent11, -1, 1);
        RefreshAndPush();
    }
    public void SetJoystickRightY(float percent11)
    {

     m_playerGamepad.m_dualStick.m_rightJoystickYPercent11 = Mathf.Clamp(percent11, -1, 1);
        RefreshAndPush();
    }


    public void SetJoystickLeft(Vector2 joystickValue)
    {
        m_playerGamepad.m_dualStick.m_leftJoystickXPercent11 = Mathf.Clamp(joystickValue.x, -1, 1);
        m_playerGamepad.m_dualStick.m_leftJoystickYPercent11 = Mathf.Clamp(joystickValue.y, -1, 1);
        RefreshAndPush();
    }
    public void SetJoystickRight(Vector2 joystickValue)
    {
        m_playerGamepad.m_dualStick.m_rightJoystickXPercent11 = Mathf.Clamp(joystickValue.x, -1, 1);
        m_playerGamepad.m_dualStick.m_rightJoystickYPercent11 = Mathf.Clamp(joystickValue.y, -1, 1);
        RefreshAndPush();
    }
    public void SetJoystickLeftRight(Vector2 leftJoystickValue, Vector2 rightJoystickValue)
    {
        m_playerGamepad.m_dualStick.m_leftJoystickXPercent11 = Mathf.Clamp(leftJoystickValue.x, -1, 1);
        m_playerGamepad.m_dualStick.m_leftJoystickYPercent11 = Mathf.Clamp(leftJoystickValue.y, -1, 1);
        m_playerGamepad.m_dualStick.m_rightJoystickXPercent11 = Mathf.Clamp(rightJoystickValue.x, -1, 1);
        m_playerGamepad.m_dualStick.m_rightJoystickYPercent11 = Mathf.Clamp(rightJoystickValue.y, -1, 1);
        RefreshAndPush();
    }


}

}