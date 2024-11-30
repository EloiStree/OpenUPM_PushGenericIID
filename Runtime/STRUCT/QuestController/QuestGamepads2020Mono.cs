using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuestGamepads2020Mono : MonoBehaviour ,I_QuestGamepadSetGet
{

    public QuestGamepads2020 m_questGamepads2020;


    public bool m_useOnValidate = true;

    private void OnValidate()
    {
        if (m_useOnValidate)
        {
            RefreshHumanValueToRawInteger();
        }
    }

    [ContextMenu("RefreshRawIntegerToHumanValue")]
    public void RefreshHumanValueToRawInteger() { 
    
        m_questGamepads2020.RefreshHumanValueToRawInteger();
    }

    public bool GetDownLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetDownLeft();
    }

    public bool GetDownLeftTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetDownLeftTouch();
    }

    public bool GetDownRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetDownRight();
    }

    public bool GetDownRightTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetDownRightTouch();
    }

    public float GetGripLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetGripLeft();
    }

    public float GetGripRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetGripRight();
    }

    public bool GetIsGripLeftPressing()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsGripLeftPressing();
    }

    public bool GetIsGripRightPressing()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsGripRightPressing();
    }

    public bool GetIsLeftTracked()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsLeftTracked();
    }

    public bool GetIsRightTracked()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsRightTracked();
    }

    public bool GetIsTriggerLeftPressing()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsTriggerLeftPressing();
    }

    public bool GetIsTriggerRightPressing()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetIsTriggerRightPressing();
    }

    public bool GetJoystickLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetJoystickLeft();
    }

    public bool GetJoystickLeftTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetJoystickLeftTouch();
    }

    public bool GetJoystickRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetJoystickRight();
    }

    public bool GetJoystickRightTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetJoystickRightTouch();
    }

    public float GetLeftHorizontal()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetLeftHorizontal();
    }

    public float GetLeftVertical()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetLeftVertical();
    }

    public bool GetMenuLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetMenuLeft();
    }

    public bool GetMenuRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetMenuRight();
    }

    public float GetRightHorizontal()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetRightHorizontal();
    }

    public float GetRightVertical()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetRightVertical();
    }

    public bool GetThumbRestLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetThumbRestLeft();
    }

    public bool GetThumbRestRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetThumbRestRight();
    }

    public bool GetTopLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTopLeft();
    }

    public bool GetTopLeftTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTopLeftTouch();
    }

    public bool GetTopRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTopRight();
    }

    public bool GetTopRightTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTopRightTouch();
    }

    public float GetTriggerLeft()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTriggerLeft();
    }

    public bool GetTriggerLeftTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTriggerLeftTouch();
    }

    public float GetTriggerRight()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTriggerRight();
    }

    public bool GetTriggerRightTouch()
    {
        return ((I_QuestGamepadsGet)m_questGamepads2020).GetTriggerRightTouch();
    }

    public void SetDownLeft(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetDownLeft(value);
    }

    public void SetDownLeftTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetDownLeftTouch(value);
    }

    public void SetDownRight(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetDownRight(value);
    }

    public void SetDownRightTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetDownRightTouch(value);
    }

    public void SetGripLeft(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetGripLeft(value);
    }

    public void SetGripRight(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetGripRight(value);
    }

    public void SetIsGripLeftPressing(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsGripLeftPressing(value);
    }

    public void SetIsGripRightPressing(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsGripRightPressing(value);
    }

    public void SetIsLeftTracked(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsLeftTracked(value);
    }

    public void SetIsRightTracked(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsRightTracked(value);
    }

    public void SetIsTriggerLeftPressing(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsTriggerLeftPressing(value);
    }

    public void SetIsTriggerRightPressing(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetIsTriggerRightPressing(value);
    }

    public void SetJoystickLeft(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetJoystickLeft(value);
    }

    public void SetJoystickLeftTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetJoystickLeftTouch(value);
    }

    public void SetJoystickRight(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetJoystickRight(value);
    }

    public void SetJoystickRightTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetJoystickRightTouch(value);
    }

    public void SetLeftHorizontal(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetLeftHorizontal(value);
    }

    public void SetLeftVertical(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetLeftVertical(value);
    }

    public void SetMenuLeft(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetMenuLeft(value);
    }

    public void SetMenuRight(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetMenuRight(value);
    }

    public void SetRightHorizontal(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetRightHorizontal(value);
    }

    public void SetRightVertical(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetRightVertical(value);
    }

    public void SetThumbRestLeft(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetThumbRestLeft(value);
    }

    public void SetThumbRestRight(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetThumbRestRight(value);
    }

    public void SetTopLeft(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTopLeft(value);
    }

    public void SetTopLeftTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTopLeftTouch(value);
    }

    public void SetTopRight(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTopRight(value);
    }

    public void SetTopRightTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTopRightTouch(value);
    }

    public void SetTriggerLeft(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTriggerLeft(value);
    }

    public void SetTriggerLeftTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTriggerLeftTouch(value);
    }

    public void SetTriggerRight(float value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTriggerRight(value);
    }

    public void SetTriggerRightTouch(bool value)
    {
        ((I_QuestGamepadsSet)m_questGamepads2020).SetTriggerRightTouch(value);
    }
}
