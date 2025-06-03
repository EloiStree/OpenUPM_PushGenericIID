
using System;
using UnityEngine;

namespace Eloi.ScratchToWarcraft
{
    public class ScratchToWarcraftEnumMono : MonoBehaviour
{
        public EnumScratchKeyboardWinHardware[] m_enumHardware = GenerateEnumArray<EnumScratchKeyboardWinHardware>();
        public EnumScratchToWarcraftGamepad[] m_gamepad = GenerateEnumArray<EnumScratchToWarcraftGamepad>();
        public EnumScratchToWarcraftChar125UTF8[] m_mouse = GenerateEnumArray<EnumScratchToWarcraftChar125UTF8>();
        public ScratchToWarcraftChar [] m_char = ScratchToWarcraftChar.UTF8;
    public static T[] GenerateEnumArray<T>() where T :Enum
    {
        var enumType = typeof(T);
        var enumValues = Enum.GetValues(enumType);
        var enumArray = new T[enumValues.Length];
        for (int i = 0; i < enumValues.Length; i++)
        {
            enumArray[i] = (T)enumValues.GetValue(i);
        }
        return enumArray;
    }

}

}