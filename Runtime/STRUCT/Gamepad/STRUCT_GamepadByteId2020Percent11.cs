using UnityEngine;

[System.Serializable]
public struct STRUCT_GamepadByteId2020Percent11
{
    [Range(-20,20)]
    public short m_id2020;
    [Range(-1f,1f)]
    public float m_joystickLeftHorizontal;
    [Range(-1f, 1f)]
    public float m_joystickLeftVertical;
    [Range(-1f, 1f)]
    public float m_joystickRightHorizontal;
    [Range(-1f, 1f)]
    public float m_joystickRightVertical;
}
