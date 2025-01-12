using UnityEngine;
using UnityEngine.Events;

public class Quest2DMono_IsApplicationFocused : MonoBehaviour
{

    public bool m_hasFocus;
    public bool m_isApplicationPaused;
    public UnityEvent<bool> m_onFocus;
    public UnityEvent<bool> m_onPause;

    public void OnApplicationFocus(bool focus)
    {
        if (m_hasFocus != focus) { 
            m_hasFocus = focus;
            m_onFocus.Invoke(focus);
        }
    }

    public void OnApplicationPause(bool pause)
    {
        if (pause != m_isApplicationPaused) { 
            m_isApplicationPaused = pause;
            m_onPause.Invoke(pause);
        }
    }
}
