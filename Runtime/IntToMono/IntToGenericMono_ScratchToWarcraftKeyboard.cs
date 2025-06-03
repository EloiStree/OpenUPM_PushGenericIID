using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;

public class IntToGenericMono_ScratchToWarcraftKeyboard : MonoBehaviour
{
    public IntToGeneric_ScratchToWarcraftKeyboard m_data;

    public void PushInBytes(byte[] bytes) { m_data.PushInBytes(bytes); }
    public void PushInInteger(int value) { m_data.PushInInteger(value); }
    public void PushInEnum(EnumScratchKeyboardWinHardware value) { m_data.PushInEnum(value); }

    public void DebugLogPressed(EnumScratchKeyboardWinHardware key) {

        Debug.Log("Pressed: " + key);
    }
    public void DebugLogReleased(EnumScratchKeyboardWinHardware key)
    {
        Debug.Log("Released: " + key);
    }

 


    [ContextMenu("Press All Numpad Number")]
    public void PressAllNumpadNumber() => m_data.PushInEnumList(true,EnumScratchToWarcraftList.ALL_NUMPAD_0TO9);
    [ContextMenu("Release All Numpad Number")]
    public void ReleaseAllNumpadNumber() => m_data.PushInEnumList(false, EnumScratchToWarcraftList.ALL_NUMPAD_0TO9);
    [ContextMenu("Press All Ctrl Shift Alt")]

    public void PressAllCtrlShiftAlt() => m_data.PushInEnumList(true, EnumScratchToWarcraftList.ALL_CONTROLSHIFTALT);
    [ContextMenu("Release All Ctrl Shift Alt")]
    public void ReleaseAllCtrlShiftAlt() => m_data.PushInEnumList(false, EnumScratchToWarcraftList.ALL_CONTROLSHIFTALT);


    [ContextMenu("Release All")]
    public void ReleaseAll()
    {
        m_data.ReleaseAll();
    }

    private void Update()
    {
        m_data.Update();
    }
}


[System.Serializable]
public class IntToGeneric_ScratchToWarcraftKeyboard
{

    public UnityEvent<EnumScratchKeyboardWinHardware> m_onKeyPressed = new UnityEvent<EnumScratchKeyboardWinHardware>();
    public UnityEvent<EnumScratchKeyboardWinHardware> m_onKeyReleased = new UnityEvent<EnumScratchKeyboardWinHardware>();
    public UnityEvent<EnumScratchKeyboardWinHardware> m_onKeyChanged = new UnityEvent<EnumScratchKeyboardWinHardware>();
    public UnityEvent<int> m_onKeyChangedAsInt = new UnityEvent<int>();
    public STRUCT_ScratchKeyboard m_keyboardState;
    public STRUCT_ScratchKeyboard m_keyboardObservedChangedState;
   

    public void PushInEnum(EnumScratchKeyboardWinHardware value)
    {
        PushInInteger((int)value);
    }
    public void PushInBytes(byte[] bytes)
    {
        if (bytes.Length == 4)
            PushInInteger(System.BitConverter.ToInt32(bytes, 0));
        if (bytes.Length == 8)
            PushInInteger(System.BitConverter.ToInt32(bytes, 4));
        if (bytes.Length == 16)
            PushInInteger(System.BitConverter.ToInt32(bytes, 4));
        if (bytes.Length == 8)
            PushInInteger(System.BitConverter.ToInt32(bytes, 0));
    }
    public void PushInInteger(int value)
    {
        bool isBetween1000 = value >= 1000 && value < 2000;
        bool isBetween2000 = value >= 2000 && value < 3000;
        if ( !isBetween1000 && !isBetween2000)
        {
            return;
        }


        if (isBetween1000 || isBetween2000) {
            bool isPressCommand = isBetween1000;
            bool isReleaseCommand = isBetween2000;
            int keyCode = value % 1000;
            if (keyCode < 0 || keyCode > 256 )
            {
                return;
            }
            if (keyCode == 0)
            {
                ReleaseAll();
                return;
            }

            SetKeyTo((EnumScratchKeyboardWinHardware)keyCode, isPressCommand);
        }


        }
    public void SetKeyTo(EnumScratchKeyboardWinHardware key, bool isPressCommand)
    {
        m_keyboardState.SetKey(key, isPressCommand, out bool changed);
        m_keyboardObservedChangedState.SetKey(key, isPressCommand);
        //Debug.Log($"{key},{isPressCommand},{changed}");
        if (changed)
        {
            m_onKeyChanged.Invoke(key);
            int value = (int)key;
            if (isPressCommand)
            {
                m_onKeyChangedAsInt.Invoke(value);
                m_onKeyPressed.Invoke(key);
            }
            else
            {
                m_onKeyChangedAsInt.Invoke(value+1000);
                m_onKeyReleased.Invoke(key);
            }
        }
    }

    public void Update()
    {
        foreach (var key in m_allKeys)
        {
            m_keyboardState.GetKey(key, out bool isPress);
            m_keyboardObservedChangedState.GetKey(key, out bool isPressObserved);

            if (isPress != isPressObserved)
            {
                SetKeyTo(key, isPress);
            }
        }
    }


    public void ReleaseAll()
    {
        foreach (var key in m_allKeys)
        {
            SetKeyTo(key, false);
        }
    }

    public void PushInEnumList(bool isPressOn, params EnumScratchKeyboardWinHardware[] paramsArray)
    {
        foreach (var key in paramsArray)
        {
            SetKeyTo(key, isPressOn);
        }
    }

    public static readonly List<EnumScratchKeyboardWinHardware> m_allKeys
        = Enum.GetValues(typeof(EnumScratchKeyboardWinHardware))
        .Cast<EnumScratchKeyboardWinHardware>()
        .ToList();

}
