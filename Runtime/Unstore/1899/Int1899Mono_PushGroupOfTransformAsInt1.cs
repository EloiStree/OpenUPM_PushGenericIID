using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Int1899
{
    public class Int1899Mono_PushGroupOfTransformAsInt : MonoBehaviour
    { 
        public UnityEvent<int> m_onIntChanged;
        public Space m_space = Space.World;
        public Int1899RotationSendType m_rotationSendType = Int1899RotationSendType.Euler;
    
        public Transform[] m_sourceToPush = new Transform[16];
        public IntegerTransformAsIntegerIntValue[] m_lastPushedOfInteger = new IntegerTransformAsIntegerIntValue[16];
        public TypeOfIntegerForTransform m_typeOfInteger = new TypeOfIntegerForTransform();


        public bool m_useUpdate = true;

        public void Update()
        {
            if (!m_useUpdate)
                return;
            RefreshAndPushChanged();
        }

        [ContextMenu("Refresh and push")]

        public void RefreshAndPushAll() { 
        

            // SHOULD REFRESH THE INFO BEFORE

            foreach (var item in m_lastPushedOfInteger)
            {
                if (item != null)
                { 
                
                    m_onIntChanged?.Invoke(item.m_value_01_x1_999_999);
                    m_onIntChanged?.Invoke(item.m_value_02_x2_999999);
                    m_onIntChanged?.Invoke(item.m_value_03_y1_999_999);
                    m_onIntChanged?.Invoke(item.m_value_04_y2_999999);
                    m_onIntChanged?.Invoke(item.m_value_05_z1_999_999);
                    m_onIntChanged?.Invoke(item.m_value_06_z2_999999);
                    m_onIntChanged?.Invoke(item.m_value_07_eulerCompressed_999999);
                    m_onIntChanged?.Invoke(item.m_value_08_quaternionX_999999);
                    m_onIntChanged?.Invoke(item.m_value_09_quaternionY_999999);
                    m_onIntChanged?.Invoke(item.m_value_10_quaternionZ_999999);
                    m_onIntChanged?.Invoke(item.m_value_11_quaternionW_999999);
                    m_onIntChanged?.Invoke(item.m_value_12_scale_999999);

                }
            }
        }

        [ContextMenu("Refresh and push Changed")]
        public void RefreshAndPushChanged()
        {


            for (int i = 0; i < m_sourceToPush.Length; i++)
            {
                if (m_sourceToPush[i] == null) continue;
                Transform selectTransform = m_sourceToPush[i];
                IntegerTransformAsIntegerIntValue selectValue = m_lastPushedOfInteger[i];

                byte playerId1To18 = (byte)(i + 1);

                Int1899Parser.ToIntTransfromPosition(
                    (byte)(i + 1),
                    m_space == Space.World ? selectTransform.position : selectTransform.localPosition,
                    out int value_01_x1_999_999,
                    out int value_02_x2_999999,
                    out int value_03_y1_999_999,
                    out int value_04_y2_999999,
                    out int value_05_z1_999_999,
                    out int value_06_z2_999999);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_01_x1_999_999, playerId1To18, m_typeOfInteger.m_type_01_x1);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_02_x2_999999, playerId1To18, m_typeOfInteger.m_type_02_x2);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_03_y1_999_999, playerId1To18, m_typeOfInteger.m_type_03_y1);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_04_y2_999999, playerId1To18, m_typeOfInteger.m_type_04_y2);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_05_z1_999_999, playerId1To18, m_typeOfInteger.m_type_05_z1);
                Int1899Parser.TagIntegerWithPlayerAndType(ref value_06_z2_999999, playerId1To18, m_typeOfInteger.m_type_06_z2);


                PushIfChanged(ref selectValue.m_value_01_x1_999_999, value_01_x1_999_999);
                PushIfChanged(ref selectValue.m_value_02_x2_999999, value_02_x2_999999);
                PushIfChanged(ref selectValue.m_value_03_y1_999_999, value_03_y1_999_999);
                PushIfChanged(ref selectValue.m_value_04_y2_999999, value_04_y2_999999);
                PushIfChanged(ref selectValue.m_value_05_z1_999_999, value_05_z1_999_999);
                PushIfChanged(ref selectValue.m_value_06_z2_999999, value_06_z2_999999);




                float scale = selectTransform.localScale.x;
                int intScale999999 = Int1899Parser.ToIntScale(scale);
                Int1899Parser.TagIntegerWithPlayerAndType(ref intScale999999, playerId1To18, m_typeOfInteger.m_type_12_scale);
                PushIfChanged(ref selectValue.m_value_12_scale_999999, intScale999999);


                if (m_rotationSendType == Int1899RotationSendType.Euler)
                {
                    Int1899Parser.ToIntEulerRotation(
                        playerId1To18,
                        m_space == Space.World ?
                        selectTransform.rotation.eulerAngles :
                        selectTransform.localRotation.eulerAngles,
                        out int intEuler);

                    Int1899Parser.TagIntegerWithPlayerAndType(ref intEuler,
                        playerId1To18, m_typeOfInteger.m_type_07_eulerCompressed);

                    PushIfChanged(ref selectValue.m_value_07_eulerCompressed_999999, intEuler);
                }
                else
                {

                    Int1899Parser.ToIntQuaternionRotation(
                        playerId1To18,
                        m_space == Space.World ?
                        selectTransform.rotation :
                        selectTransform.localRotation,
                        out int x1_999999,
                        out int y1_999999,
                        out int z1_999999,
                        out int w1_999999);

                    Int1899Parser.TagIntegerWithPlayerAndType(ref x1_999999, playerId1To18, m_typeOfInteger.m_type_08_quaternionX);
                    Int1899Parser.TagIntegerWithPlayerAndType(ref y1_999999, playerId1To18, m_typeOfInteger.m_type_09_quaternionY);
                    Int1899Parser.TagIntegerWithPlayerAndType(ref z1_999999, playerId1To18, m_typeOfInteger.m_type_10_quaternionZ);
                    Int1899Parser.TagIntegerWithPlayerAndType(ref w1_999999, playerId1To18, m_typeOfInteger.m_type_11_quaternionW);
                    PushIfChanged(ref selectValue.m_value_08_quaternionX_999999, x1_999999);
                    PushIfChanged(ref selectValue.m_value_09_quaternionY_999999, y1_999999);
                    PushIfChanged(ref selectValue.m_value_10_quaternionZ_999999, z1_999999);
                    PushIfChanged(ref selectValue.m_value_11_quaternionW_999999, w1_999999);

                }
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
}