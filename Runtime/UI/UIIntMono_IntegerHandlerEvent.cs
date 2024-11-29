using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class UIIntMono_IntegerHandlerEvent : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler, IScrollHandler, IPointerClickHandler

    
{
    [System.Serializable]
    public class InteractionEvent : UnityEvent<int> { }
    public InteractionEvent m_onIntegerAction;

    public bool m_usePressRelease = true;
    public int m_pressInteger;
    public int m_releaseInteger;

    public bool m_useEnterExit = false;
    public int m_enterInteger;
    public int m_exitInteger;

    public bool m_useClick = true;
    public int [] m_clickInteger;


    public bool m_useScroll = false;
    public int[] m_scrollUpInteger;
    public int[] m_scrollDownInteger;
    public int[] m_scrollLeftInteger;
    public int[] m_scrollRightInteger;

    [ContextMenu("Set release as add +1000")]
    public void SetReleaseAsPressWithAdd1000()
    {

        m_releaseInteger = m_pressInteger + 1000;
    }
    [ContextMenu("Set Exit as add +1000")]
    public void SetExitAsEnterWithAdd1000()
    {

        m_exitInteger = m_enterInteger + 1000;
    }
    

    public void Awake()
    {
        if (m_onIntegerAction == null)
            m_onIntegerAction = new InteractionEvent();
    }

    public bool m_useOnMouse = false;
    private void OnMouseDown()
    {

        if (m_usePressRelease && m_useOnMouse)
            m_onIntegerAction.Invoke(m_pressInteger);
    }
    private void OnMouseUp()
    {
        if (m_usePressRelease && m_useOnMouse)
            m_onIntegerAction.Invoke(m_releaseInteger);
    }
    public void OnMouseEnter()
    {
        if (m_useEnterExit && m_useOnMouse)
            m_onIntegerAction.Invoke(m_enterInteger);
    }
    public void OnMouseExit()
    {
        if (m_useEnterExit && m_useOnMouse)
            m_onIntegerAction.Invoke(m_exitInteger);
    }

    // Pointer Enter
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (m_useEnterExit)
        m_onIntegerAction.Invoke(m_enterInteger);
    }

    // Pointer Exit
    public void OnPointerExit(PointerEventData eventData)
    {
        if (m_useEnterExit)
        m_onIntegerAction.Invoke(m_exitInteger);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (m_usePressRelease)
        m_onIntegerAction.Invoke(m_pressInteger);
    }

    // Pointer Up
    public void OnPointerUp(PointerEventData eventData)
    {
        if (m_usePressRelease)
        m_onIntegerAction.Invoke(m_releaseInteger);
    }

    public void OnScroll(PointerEventData eventData) {
        if (m_useScroll) { 
            bool isScrollingUp = eventData.scrollDelta.y > 0;
            bool isScrollingDown = eventData.scrollDelta.y < 0;
            bool isScrollingLeft = eventData.scrollDelta.x < 0;
            bool isScrollingRight = eventData.scrollDelta.x > 0;
            if (isScrollingUp)
            {
                for (int i = 0; i < m_scrollUpInteger.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_scrollUpInteger[i]);
                }
            }
            if (isScrollingDown)
            {
                for (int i = 0; i < m_scrollDownInteger.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_scrollDownInteger[i]);
                }
            }
            if (isScrollingLeft)
            {
                for (int i = 0; i < m_scrollLeftInteger.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_scrollLeftInteger[i]);
                }
            }
            if (isScrollingRight)
            {
                for (int i = 0; i < m_scrollRightInteger.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_scrollRightInteger[i]);
                }
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (m_useClick) { 
        
            for (int i = 0; i < m_clickInteger.Length; i++)
            {
                m_onIntegerAction.Invoke(m_clickInteger[i]);
            }
        }
    }


}
