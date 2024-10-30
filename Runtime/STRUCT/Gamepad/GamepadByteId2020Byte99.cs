using UnityEngine;

[System.Serializable]
public struct GamepadByteId2020Byte99
{
    [Range(-20,20)]
    public short m_id2020;
    [Range(0,99)]
    public byte m_joystickLeftHorizontal;
    [Range(0, 99)]
    public byte m_joystickLeftVertical;
    [Range(0, 99)]
    public byte m_joystickRightHorizontal;
    [Range(0, 99)]
    public byte m_joystickRightVertical;
}
