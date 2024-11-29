using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UI2D_OnPanelMouseClickInteger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public int m_pressInteger;
    public int m_releaseInteger;
    public UnityEvent<int> m_onPress;
    public UnityEvent<int> m_onRelease;
    // Triggered when the mouse button is pressed down on the UI element
    public void OnPointerDown(PointerEventData eventData)
    {
        m_onPress.Invoke(m_pressInteger);
    }

    // Triggered when the mouse button is released on the UI element
    public void OnPointerUp(PointerEventData eventData)
    {
        m_onRelease.Invoke(m_releaseInteger);
    }

    [ContextMenu("Set release as add +1000")]
    public void SetReleaseAsPressWithAdd1000() { 
    
        m_releaseInteger = m_pressInteger + 1000;
    }
}
