using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIIntMono_DragDropIntegerEventAction : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public UnityEvent<int> m_onIntegerAction;

    public int m_beginDragInteger;
    public int m_stopDragInteger;

    public bool m_useMoveDraggedInteger = false;
    public int m_moveDraggedInteger;

    public UnityEvent m_startDragging;
    public UnityEvent m_moveDragged;
    public UnityEvent m_stopDragging;


    public void OnBeginDrag(PointerEventData eventData)
    {
        m_onIntegerAction.Invoke(m_beginDragInteger);
        m_startDragging.Invoke();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(m_useMoveDraggedInteger)
            m_onIntegerAction.Invoke(m_moveDraggedInteger);
           // m_moveDraggedInteger = (int)eventData.delta.magnitude;
        m_moveDragged.Invoke();
    }

    

    public void OnEndDrag(PointerEventData eventData)
    {
        m_onIntegerAction.Invoke(m_stopDragInteger);
        m_stopDragging.Invoke();
    }
}
