using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_IntegerRelay : MonoBehaviour
{    
    public UnityEvent<int> m_onIntegerToRelay;
    public int m_lastReceivedValue;
    public bool m_onlyIfChanged = false;

    public void PushIn(int integer) { 
    

        if (m_onlyIfChanged && m_lastReceivedValue == integer)
            return;
        m_lastReceivedValue = integer;
        m_onIntegerToRelay.Invoke(integer);
    }

}
