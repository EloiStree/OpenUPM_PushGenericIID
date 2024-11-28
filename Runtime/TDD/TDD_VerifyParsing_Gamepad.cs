using UnityEngine;

public class TDD_VerifyParsing_Gamepad :MonoBehaviour{

    public STRUCT_GamepadByteId2020Percent11 m_gamepadInValue;
    public int m_integerCommand;
    public STRUCT_GamepadByteId2020Percent11 m_gamepadOutInValue;

    private void OnValidate()
    {
        TestTheCode();
    }

    [ContextMenu("Test Code")]
    public void TestTheCode() {

        IntegerToGamepad2020Utility.ParseGamepadByteId2020ToInteger(
            out m_integerCommand,
            m_gamepadInValue.m_id2020,
            m_gamepadInValue.m_joystickLeftHorizontal,
            m_gamepadInValue.m_joystickLeftVertical,
            m_gamepadInValue.m_joystickRightHorizontal,
            m_gamepadInValue.m_joystickRightVertical
            );

        IntegerToGamepad2020Utility.ParseGamepadByteId2020FromInteger(m_integerCommand,
            out m_gamepadOutInValue.m_id2020,
            out m_gamepadOutInValue.m_joystickLeftHorizontal,
            out m_gamepadOutInValue.m_joystickLeftVertical,
            out m_gamepadOutInValue.m_joystickRightHorizontal,
            out m_gamepadOutInValue.m_joystickRightVertical
            );
    }
}