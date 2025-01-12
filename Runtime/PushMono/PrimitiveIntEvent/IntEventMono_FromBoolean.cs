using UnityEngine;

public class IntEventMono_FromBoolean : MonoBehaviour {

    public IntEvent_FromBoolean m_action;

    public void PushIn(bool value)
    {
        m_action.PushIn(value);
    }

    [ContextMenu("Push True False")]
    public void PushInTrueFalse() { 
    
        m_action.PushIn(true);
        m_action.PushIn(false);
    }

    [ContextMenu("Push True")]
    public void PushInTrue() { 
    
        m_action.PushIn(true);
    }
    [ContextMenu("Push False")]
    public void PushInFalse() { 
    
        m_action.PushIn(false);
    }
}
