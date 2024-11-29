using UnityEngine;

public class IntegerToMousePosition2020Utility {

    public static void ParseMousePosition2020FromInteger(int value, out STRUCT_CursorPosition2020 gamepad)
    {
        ParseMousePosition2020FromInteger(value, 
            out gamepad.m_id2020,
            out gamepad.m_leftRight9999,
            out gamepad.m_downTop9999,
            out gamepad.m_leftRightPercent,
            out gamepad.m_downTopPercent);
    }
    public static void ParseMousePosition2020FromInteger(int value,
        out short elementId,
        out ushort leftRight9999,
        out ushort downTop9999,
        out float leftRightPercent,
        out float downTopPercent)
    {
        elementId = (short)(value / 100000000);
        if (value < 0)
            value *= -1;
        int lr = (value / 10000)%10000;
        int dt = value % 10000;
        leftRight9999 = (ushort)lr;
        downTop9999 = (ushort) dt;

        leftRightPercent = ((int)leftRight9999) / 10000f;
        downTopPercent = ((int)downTop9999) / 10000f;
    }

    public static void ParseMousePosition2020ToInteger(out int value, STRUCT_CursorPosition2020 gamepad)
    {
        ParseMousePosition2020ToInteger(out value,
            gamepad.m_id2020,
            gamepad.m_leftRight9999,
            gamepad.m_downTop9999);
    }

    public static void ParseMousePosition2020ToInteger(out int value, short elementId, ushort leftRight9999, ushort downTop9999)
    {
        if(leftRight9999>9999)
            leftRight9999 = 9999;
        if(downTop9999>9999)
            downTop9999 = 9999;

        if(elementId>20)
            elementId = 20;
        if(elementId<-20)
            elementId = -20;

        
        value = 0;
        value += leftRight9999 * 10000;
        value += downTop9999;

        if (elementId > 0)
        {
            value += elementId * 100000000;
        }
        else if (elementId < 0)
        {
            value += -elementId * 100000000;
            value *= -1;
        }
    }
    public static void ParseMousePosition2020ToInteger(out int value, short elementId, float leftRightPercent, float downTopPercent)
    {
        leftRightPercent = Mathf.Clamp01(leftRightPercent);
        downTopPercent = Mathf.Clamp01(downTopPercent);
        if (elementId > 20)
            elementId = 20;
        if (elementId < -20)
            elementId = -20;

        value = 0;
        value += (int)(((int)(leftRightPercent*9999f)) * 10000);
        value += (int)(downTopPercent *9999f);

        if (elementId > 0)
        {
            value += elementId * 100000000;
        }
        else if (elementId < 0)
        {
            value += -elementId * 100000000;
            value *= -1;
        }
    }


    public static void GetTwoFirstDigits(int value, out int first)
    {
        first = value / 100000000;
    }

}
