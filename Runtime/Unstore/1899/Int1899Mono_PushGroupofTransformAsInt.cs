using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Int1899
{
    public class Int1899Mono_PushGroupofTransformAsInt : MonoBehaviour
    {

        private void Reset()
        {
            m_tranformsToPush = new Int1899_PushOneTransformAsInt[16];
            for (int i = 0; i < m_tranformsToPush.Length; i++)
            {
                m_tranformsToPush[i] = new Int1899_PushOneTransformAsInt();
                m_tranformsToPush[i].m_playerId1To18 = (byte)(i + 1);
            }
        }
        public UnityEvent<int> m_onIntChanged;

        public Int1899_PushOneTransformAsInt[] m_tranformsToPush = new Int1899_PushOneTransformAsInt[16];


        private void OnEnable()
        {
            foreach (var pushOne in m_tranformsToPush)
            {
                pushOne.m_onIntChanged.AddListener(m_onIntChanged.Invoke);
            }
        }
        private void OnDisable()
        {
            foreach (var pushOne in m_tranformsToPush)
            {
                pushOne.m_onIntChanged.RemoveListener(m_onIntChanged.Invoke);
            }
        }

        public bool m_useUpdate = true;
        public void Update()
        {
            if (!m_useUpdate)
                return;
            foreach (var pushOne in m_tranformsToPush)
            {
                pushOne.PushCurrentTransform();
            }
        }
        [ContextMenu("Push Current Transform")]
        public void PushCurrentTransform()
        {
            foreach (var pushOne in m_tranformsToPush)
            {
                pushOne.PushCurrentTransform();
            }
        }
    }
}