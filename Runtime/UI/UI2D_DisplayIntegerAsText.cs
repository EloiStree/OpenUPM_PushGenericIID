using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UI2D_DisplayIntegerAsText : MonoBehaviour
{

    public int m_value;

    public string m_valueAsText;
    public string m_valueAsLittleEndian;
    public string m_valueAsBigEndian;
    public string m_valueAsHexadecimalLittleEndian;
    public string m_valueAsHexaDecimalBigEndian;
    public string m_valueAsBinary;

    public bool m_oneLiner;
    [TextArea(0,10)]
    public string m_fullDescription;
    public UnityEvent<string> m_onUpdate;

    public UnityEvent<Color> m_colorRGB;
    public UnityEvent<Color> m_alphaBlackWhite;

    public bool m_useValidate = true;
    public void OnValidate()
    {
        if (m_useValidate)
            PushIn(m_value);
    }

    public void PushIn(int index, int value) {
        PushIn(value);
    }
    public void PushIn(int value) { 
    
        byte [] littleEndian = System.BitConverter.GetBytes(value);
        byte [] bigEndian = new byte[littleEndian.Length];
        for (int i = 0; i < littleEndian.Length; i++)
        {
            bigEndian[i] = littleEndian[littleEndian.Length - 1 - i];
        }


        m_value = value;
        m_valueAsText = value.ToString();
        m_valueAsLittleEndian = string.Join(" ", littleEndian);
        m_valueAsBigEndian =  string.Join(" ", bigEndian);
        string littleEndianHex = "";
        for(int i = 0; i < littleEndian.Length; i++)
        {
            littleEndianHex += littleEndian[i].ToString("X2") + " ";
        }
        m_valueAsHexadecimalLittleEndian = littleEndianHex;


        string bigEndianHex = "";   
        for(int i = 0; i < bigEndian.Length; i++)
        {
            bigEndianHex += bigEndian[i].ToString("X2") + " ";
        }
        m_valueAsHexaDecimalBigEndian = bigEndianHex;


        string binary = "";
        for(int i = 0; i < 32; i++)
        {
            binary = ((value & 1) == 1 ? "1" : "0") + binary;
            value = value >> 1;
        }
        m_valueAsBinary = binary;



        if (m_oneLiner) {
            m_fullDescription = string.Join("", new string[] {
                " i: " + m_valueAsText,
                " b: " + m_valueAsBinary,
                "\n",
                " LE: " + m_valueAsLittleEndian,
                 m_valueAsHexadecimalLittleEndian,
                " BE: " + m_valueAsBigEndian,
                 m_valueAsHexaDecimalBigEndian,
            });
        }
        else { 
            m_fullDescription= string.Join("\n", new string[] {
                "Value: " + m_valueAsText,
                "Little Endian: " + m_valueAsLittleEndian,
                "Big Endian: " + m_valueAsBigEndian,
                "Hexadecimal Little Endian: " + m_valueAsHexadecimalLittleEndian,
                "Hexadecimal Big Endian: " + m_valueAsHexaDecimalBigEndian,
                "Binary: " + m_valueAsBinary
            });
        }

        m_onUpdate.Invoke(m_fullDescription);

        m_colorRGB.Invoke(new Color(
            (littleEndian[1] / 255.0f),
            (littleEndian[2] / 255.0f),
            (littleEndian[3] / 255.0f)
        ));
        m_alphaBlackWhite.Invoke(new Color(
            (littleEndian[0] / 255.0f),
            (littleEndian[0] / 255.0f),
            (littleEndian[0] / 255.0f)
        ));
    }
}
