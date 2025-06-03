using Mono.Cecil;
using UnityEngine;

namespace Eloi.Int1899
{




    public class Int1899Mono_ReceiveGroupOfTransformAsInt : MonoBehaviour
    {

        public Space m_space = Space.World;
        public Int1899RotationSendType m_rotationSendType = Int1899RotationSendType.Euler;
        public Transform[] m_toApplyOn = new Transform[16];
        public IntegerTransformAsIntegerIntValue[] m_lastReceivedInteger = new IntegerTransformAsIntegerIntValue[16];
        public TypeOfIntegerForTransform m_typeOfInteger = new TypeOfIntegerForTransform();


        public DebugReceived m_debug = new DebugReceived();

        [System.Serializable]
        public class DebugReceived { 

        public int m_lastReceived;
        public string m_lastReceivedTime;
        public byte m_playerId16 = 0;
        public byte m_tag99 = 0;
        public int m_index = 0;
        public IntegerTransformAsIntegerIntValue m_focus = null;
        }

        public void PushInReceived(int value)
        {
            m_debug. m_lastReceivedTime = System.DateTime.Now.ToString("HH:mm:ss.fff");
            Int1899Parser.GetPlayerId( value, out byte playerId16);
            Int1899Parser.GetTag99( value, out byte type99OfValue);
            Int1899Parser.GetValue999999(value, out int value99);

           m_debug.m_lastReceived = value;
           m_debug.m_playerId16 = playerId16;
            m_debug.m_tag99 = type99OfValue;


            IntegerTransformAsIntegerIntValue focus = null;
            int index = playerId16 - 1;
            m_debug.m_index = index;
            if (index >=0 && index < m_lastReceivedInteger.Length)
            {
                focus = m_lastReceivedInteger[index];
                m_debug.m_focus = focus;
            }
            if (focus == null ) return;


            if (m_typeOfInteger.m_type_01_x1 == type99OfValue)
                focus.m_value_01_x1_999_999 = value;
            else if (m_typeOfInteger.m_type_02_x2 == type99OfValue)
                focus.m_value_02_x2_999999 = value;
            else if (m_typeOfInteger.m_type_03_y1 == type99OfValue)
                focus.m_value_03_y1_999_999 = value;
            else if (m_typeOfInteger.m_type_04_y2 == type99OfValue)
                focus.m_value_04_y2_999999 = value;
            else if (m_typeOfInteger.m_type_05_z1 == type99OfValue)
                focus.m_value_05_z1_999_999 = value;
            else if (m_typeOfInteger.m_type_06_z2 == type99OfValue)
                focus.m_value_06_z2_999999 = value;
            else if (m_typeOfInteger.m_type_07_eulerCompressed == type99OfValue)
                focus.m_value_07_eulerCompressed_999999 = value;
            else if (m_typeOfInteger.m_type_08_quaternionX == type99OfValue)
                focus.m_value_08_quaternionX_999999 = value;
            else if (m_typeOfInteger.m_type_09_quaternionY == type99OfValue)
                focus.m_value_09_quaternionY_999999 = value;
            else if (m_typeOfInteger.m_type_10_quaternionZ == type99OfValue)
                focus.m_value_10_quaternionZ_999999 = value;
            else if (m_typeOfInteger.m_type_11_quaternionW == type99OfValue)
                focus.m_value_11_quaternionW_999999 = value;
            else if (m_typeOfInteger.m_type_12_scale == type99OfValue)
                focus.m_value_12_scale_999999 = value;



            float scale = Int1899Parser.FromIntToScale(focus.m_value_12_scale_999999);

            if (index < m_toApplyOn.Length && m_toApplyOn[index] != null)
            {
               
                    m_toApplyOn[index].localScale = Vector3.one * scale;
            }


            Int1899Parser.FromIntTranformPosition
                (
                in focus.m_value_01_x1_999_999,
                in focus.m_value_02_x2_999999,
                in focus.m_value_03_y1_999_999,
                in focus.m_value_04_y2_999999,
                in focus.m_value_05_z1_999_999,
                in focus.m_value_06_z2_999999,out Vector3 position);
            
            if (index<m_toApplyOn.Length && m_toApplyOn[index] != null)
            {
                if (m_space == Space.World)
                {
                    m_toApplyOn[index].position = position;
                }
                else
                {
                    m_toApplyOn[index].localPosition = position;
                }
            }

            if (m_rotationSendType == Int1899RotationSendType.Euler || m_rotationSendType == Int1899RotationSendType.Both)
            {
                Int1899Parser.FromIntTranformEuler(
                    in focus.m_value_07_eulerCompressed_999999,
                    out Vector3 euler);
                if (index < m_toApplyOn.Length && m_toApplyOn[index] != null)
                {
                    if (m_space == Space.World)
                    {
                        m_toApplyOn[index].eulerAngles = euler;
                    }
                    else
                    {
                        m_toApplyOn[index].localEulerAngles = euler;
                    }
                }
            }
            else if (m_rotationSendType == Int1899RotationSendType.Quaternion || m_rotationSendType == Int1899RotationSendType.Both)
            {
                Int1899Parser.FromIntTranformQuaternion(
                    in focus.m_value_08_quaternionX_999999,
                    in focus.m_value_09_quaternionY_999999,
                    in focus.m_value_10_quaternionZ_999999,
                    in focus.m_value_11_quaternionW_999999, out Quaternion rotation);

                if (index < m_toApplyOn.Length && m_toApplyOn[index] != null)
                {
                    if (m_space == Space.World)
                    {
                        m_toApplyOn[index].rotation = rotation;
                    }
                    else
                    {
                        m_toApplyOn[index].localRotation = rotation;
                    }
                }
            }

            m_lastReceivedInteger[index] = focus;

        }
    }
}