

using System;


[System.Serializable]
public class IntToGeneric_ScratchToWarcraftChar
{

  
  
    public void PushInBytes(byte[] bytes, out bool found, out char charFound)
    {
        if (bytes.Length == 4)
            PushInInteger(System.BitConverter.ToInt32(bytes, 0), out found, out charFound);
        else if (bytes.Length == 8)
            PushInInteger(System.BitConverter.ToInt32(bytes, 4), out found, out charFound);
        else if (bytes.Length == 16)
            PushInInteger(System.BitConverter.ToInt32(bytes, 4), out found, out charFound);
        else if (bytes.Length == 8)
            PushInInteger(System.BitConverter.ToInt32(bytes, 0), out found, out charFound);
        else {

            found = false;
            charFound = ' ';
        }
    }

    public void PushInEnum(EnumScratchKeyboardWinHardware value, out bool found, out char charFound)
    {
        PushInInteger((int)value, out found, out charFound);
    }

    public void PushInInteger(int value, out bool found, out char charFound)
    {
        found = false;
        charFound = ' ';
        ScratchToWarcraftChar.TryToParse(value, out found, out charFound);
    }

}