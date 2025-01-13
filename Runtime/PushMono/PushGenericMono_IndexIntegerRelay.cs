using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_IndexIntegerRelay : MonoBehaviour
{
    public UnityEvent<int,int> m_onIntegerToRelay;
    public int m_lastReceivedValue;
    public bool m_onlyIfValueChanged = false;

    public int m_indexIfJustInteger=0;

    [ContextMenu("Push In Index Integer")]
    public void PushIndexIntegerFromInspector()
    {
        PushIn(m_indexIfJustInteger, m_lastReceivedValue);
    }
    [ContextMenu("Push In Integer")]
    public void PushIntegerFromInspector()
    {
        PushIn( m_lastReceivedValue);
    }


    public void PushIn(int integer)
    {


        if (m_onlyIfValueChanged && m_lastReceivedValue == integer)
            return;
        m_lastReceivedValue = integer;
        m_onIntegerToRelay.Invoke(m_indexIfJustInteger,integer);
    }

    public void PushIn(int index, int integer)
    {
        if (m_onlyIfValueChanged && m_lastReceivedValue == integer)
            return;
        m_lastReceivedValue = integer;
        m_onIntegerToRelay.Invoke(index,integer);
    }

}
