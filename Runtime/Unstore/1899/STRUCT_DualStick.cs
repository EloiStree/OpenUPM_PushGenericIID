using System;
using UnityEngine;

[System.Serializable]
public struct STRUCT_DualStick {

    [Range(-1, 1)]
    public float m_leftJoystickXPercent11;
    [Range(-1, 1)]
    public float m_leftJoystickYPercent11;
    [Range(-1, 1)]
    public float m_rightJoystickXPercent11;
    [Range(-1, 1)]
    public float m_rightJoystickYPercent11;
}
