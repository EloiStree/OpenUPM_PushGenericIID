using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Int1899
{

    [System.Serializable]
    public class TypeOfIntegerForTransform
    {
        public byte m_type_01_x1 = 1;
        public byte m_type_02_x2 = 2;
        public byte m_type_03_y1 = 3;
        public byte m_type_04_y2 = 4;
        public byte m_type_05_z1 = 5;
        public byte m_type_06_z2 = 6;
        public byte m_type_07_eulerCompressed = 7;
        public byte m_type_08_quaternionX = 8;
        public byte m_type_09_quaternionY = 9;
        public byte m_type_10_quaternionZ = 10;
        public byte m_type_11_quaternionW = 11;
        public byte m_type_12_scale = 12;

    }
    [System.Serializable]
    public class IntegerTransformAsIntegerIntValue
    {
        public int m_value_01_x1_999_999 = 0;
        public int m_value_02_x2_999999 = 0;
        public int m_value_03_y1_999_999 = 0;
        public int m_value_04_y2_999999 = 0;
        public int m_value_05_z1_999_999 = 0;
        public int m_value_06_z2_999999 = 0;
        public int m_value_07_eulerCompressed_999999 = 0;
        public int m_value_08_quaternionX_999999 = 0;
        public int m_value_09_quaternionY_999999 = 0;
        public int m_value_10_quaternionZ_999999 = 0;
        public int m_value_11_quaternionW_999999 = 0;
        public int m_value_12_scale_999999 = 0;

      
    }


    [System.Serializable]
    public class Int1899_PushOneTransformAsInt
    {
        public byte m_playerId1To18 = 18;
        public Transform m_source;
        public Space m_space = Space.World;
        public UnityEvent<int> m_onIntChanged;

        public RotationSendType m_rotationSendType = RotationSendType.Euler;
        public enum RotationSendType { Euler, Quaternion }
        public TypeOfIntegerForTransform m_typeOfInteger = new TypeOfIntegerForTransform();
        public IntegerTransformAsIntegerIntValue m_lastPushedOfInteger = new IntegerTransformAsIntegerIntValue();


        [ContextMenu("Push Current Transform")]
        public void PushCurrentTransform()
        {

            Int1899Parser.ToIntTransfromPosition(
               m_playerId1To18,
               m_space == Space.World ?
               m_source.position : m_source.localPosition,
               out int x1_999_999, out int x2_999999,
               out int y1_999_999, out int y2_999999,
               out int z1_999_999, out int z2_999999
           );

            Int1899Parser.TagIntegerWithPlayerAndType(
                ref x1_999_999, m_playerId1To18, m_typeOfInteger.m_type_01_x1);
            Int1899Parser.TagIntegerWithPlayerAndType(
                ref x2_999999, m_playerId1To18, m_typeOfInteger.m_type_02_x2);
            Int1899Parser.TagIntegerWithPlayerAndType(
                ref y1_999_999, m_playerId1To18, m_typeOfInteger.m_type_03_y1);
            Int1899Parser.TagIntegerWithPlayerAndType(
                ref y2_999999, m_playerId1To18, m_typeOfInteger.m_type_04_y2);
            Int1899Parser.TagIntegerWithPlayerAndType(
                ref z1_999_999, m_playerId1To18, m_typeOfInteger.m_type_05_z1);
            Int1899Parser.TagIntegerWithPlayerAndType(
                ref z2_999999, m_playerId1To18, m_typeOfInteger.m_type_06_z2);

            PushIfChanged(ref m_lastPushedOfInteger.m_value_01_x1_999_999, x1_999_999);
            PushIfChanged(ref m_lastPushedOfInteger.m_value_02_x2_999999, x2_999999);
            PushIfChanged(ref m_lastPushedOfInteger.m_value_03_y1_999_999, y1_999_999);
            PushIfChanged(ref m_lastPushedOfInteger.m_value_04_y2_999999, y2_999999);
            PushIfChanged(ref m_lastPushedOfInteger.m_value_05_z1_999_999, z1_999_999);
            PushIfChanged(ref m_lastPushedOfInteger.m_value_06_z2_999999, z2_999999);



            if (m_rotationSendType == RotationSendType.Euler)
            {
                Int1899Parser.ToIntEulerRotation(
                    m_playerId1To18,
                    m_space == Space.World ?
                    m_source.rotation.eulerAngles :
                    m_source.localRotation.eulerAngles,
                    out int intEuler);
                Int1899Parser.TagIntegerWithPlayerAndType(ref intEuler,
                    m_playerId1To18, m_typeOfInteger.m_type_07_eulerCompressed);

                PushIfChanged(ref m_lastPushedOfInteger.m_value_07_eulerCompressed_999999, intEuler);
            }
            else
            {
                Int1899Parser.ToIntQuaternionRotation(
                    m_playerId1To18,
                        m_space == Space.World ?
                        m_source.rotation :
                        m_source.localRotation,
                    out int x1_999999,
                    out int y1_999999,
                    out int z1_999999,
                    out int w1_999999);
                Int1899Parser.TagIntegerWithPlayerAndType(ref x1_999999, m_playerId1To18, m_typeOfInteger.m_type_08_quaternionX);
                Int1899Parser.TagIntegerWithPlayerAndType(ref y1_999999, m_playerId1To18, m_typeOfInteger.m_type_09_quaternionY);
                Int1899Parser.TagIntegerWithPlayerAndType(ref z1_999999, m_playerId1To18, m_typeOfInteger.m_type_10_quaternionZ);
                Int1899Parser.TagIntegerWithPlayerAndType(ref w1_999999, m_playerId1To18, m_typeOfInteger.m_type_11_quaternionW);
                PushIfChanged(ref m_lastPushedOfInteger.m_value_08_quaternionX_999999, x1_999999);
                PushIfChanged(ref m_lastPushedOfInteger.m_value_09_quaternionY_999999, y1_999999);
                PushIfChanged(ref m_lastPushedOfInteger.m_value_10_quaternionZ_999999, z1_999999);
                PushIfChanged(ref m_lastPushedOfInteger.m_value_11_quaternionW_999999, w1_999999);
            }
        }

        private void PushIfChanged(ref int currentValue, int newValue)
        {
            if (currentValue != newValue)
            {
                currentValue = newValue;
                m_onIntChanged?.Invoke(currentValue);
            }
        }
    }

    public class Int1899Mono_PushOneTransformAsInt : MonoBehaviour
    {
        public Int1899_PushOneTransformAsInt m_pushOneTransformAsInt = new Int1899_PushOneTransformAsInt();
        public bool m_useUpdate = true;
        public void Update()
        {
            if (!m_useUpdate)
                return;
            m_pushOneTransformAsInt.PushCurrentTransform();
        }
        [ContextMenu("Push Current Transform")]
        public void PushCurrentTransform()
        {
            if (m_pushOneTransformAsInt != null)
            {
                m_pushOneTransformAsInt.PushCurrentTransform();
            }
        }

    }
}