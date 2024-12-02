using UnityEngine;

public class IntEventMono_FromFloat : MonoBehaviour
{
    public IntEvent_FromFloat m_action;

    public void PushIn(float value)
    {
        m_action.PushIn(value);
    }
}
