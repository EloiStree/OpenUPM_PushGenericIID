using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Quest2DMono_MouseEvent : MonoBehaviour
{
    public bool m_isLeftPressing;
    public bool m_isRightPressing;
    public bool m_isMiddlePressing;

    public Vector2 m_mousePosition;
    public Vector2 m_mouseScroll;

    public InputActionReference m_mousePositionRef;
    public InputActionReference m_mouseScrollRef;
    public InputActionReference m_mouseLeftPressingRef;
    public InputActionReference m_mouseRightPressingRef;
    public InputActionReference m_mouseMiddlePressingRef;


    public UnityEvent<Vector2> m_onMousePosition;
    public UnityEvent<bool> m_onMouseLeftPressing;
    public UnityEvent<bool> m_onMouseRightPressing;
    public UnityEvent<bool> m_onMouseMiddlePressing;
    public UnityEvent<bool> m_anyMouseButtonPressing;


    public UnityEvent<int> m_scollUp;
    public UnityEvent<int> m_scollRight;
    public UnityEvent<int> m_scollDown;
    public UnityEvent<int> m_scollLeft;

    public int m_scrollHorizontalDebug;
    public int m_scrollVerticalDebug;


    public void OnEnable()
    {

        m_mousePositionRef.action.Enable();
        m_mouseScrollRef.action.Enable();
        m_mouseLeftPressingRef.action.Enable();
        m_mouseRightPressingRef.action.Enable();
        m_mouseMiddlePressingRef.action.Enable();

        m_mousePositionRef.action.performed += OnMousePosition;
        m_mouseScrollRef.action.performed += OnMouseScroll;
        m_mouseLeftPressingRef.action.performed += OnMouseLeftPressing;
        m_mouseRightPressingRef.action.performed += OnMouseRightPressing;
        m_mouseMiddlePressingRef.action.performed += OnMouseMiddlePressing;


        m_mousePositionRef.action.canceled += OnMousePosition;
        m_mouseScrollRef.action.canceled += OnMouseScroll;
        m_mouseLeftPressingRef.action.canceled += OnMouseLeftPressing;
        m_mouseRightPressingRef.action.canceled += OnMouseRightPressing;
        m_mouseMiddlePressingRef.action.canceled += OnMouseMiddlePressing;
    }

    private void OnMouseMiddlePressing(InputAction.CallbackContext context)
    {
        bool isPressing = context.ReadValue<float>() > 0.5f;
        if(isPressing != m_isMiddlePressing)
        {
            m_isMiddlePressing = isPressing;
            m_onMouseMiddlePressing.Invoke(isPressing);
            m_anyMouseButtonPressing.Invoke(m_isLeftPressing || m_isRightPressing || m_isMiddlePressing);
            PushDebug();
        }
    }

    private void OnMouseRightPressing(InputAction.CallbackContext context)
    {
        bool isPressing = context.ReadValue<float>() > 0.5f;
        if(isPressing != m_isRightPressing)
        {
            m_isRightPressing = isPressing;
            m_onMouseRightPressing.Invoke(isPressing);
            m_anyMouseButtonPressing.Invoke(m_isLeftPressing || m_isRightPressing || m_isMiddlePressing);
            PushDebug();
        }
    }

    private void OnMouseLeftPressing(InputAction.CallbackContext context)
    {
        bool isPressing = context.ReadValue<float>() > 0.5f;
        if(isPressing != m_isLeftPressing)
        {
            m_isLeftPressing = isPressing;
            m_onMouseLeftPressing.Invoke(isPressing);
            m_anyMouseButtonPressing.Invoke(m_isLeftPressing || m_isRightPressing || m_isMiddlePressing);
            PushDebug();
        }
    }

    private void OnMouseScroll(InputAction.CallbackContext context)
    {
        Vector2 scroll = context.ReadValue<Vector2>();
        m_mouseScroll = scroll;
        if(scroll.y > 0)
        {
            m_scollUp.Invoke((int)scroll.y);
            m_scrollVerticalDebug = (int)scroll.y;
        }
        else if(scroll.y < 0)
        {
            m_scollDown.Invoke((int)scroll.y);
            m_scrollVerticalDebug = (int)scroll.y;
        }

        if(scroll.x > 0)
        {
            m_scollRight.Invoke((int)scroll.x);
            m_scrollHorizontalDebug = (int)scroll.x;
        }
        else if(scroll.x < 0)
        {
            m_scollLeft.Invoke((int)scroll.x);
            m_scrollHorizontalDebug = (int)scroll.x;
        }
    }

    private void OnMousePosition(InputAction.CallbackContext context)
    {
        Vector2 position = context.ReadValue<Vector2>();
        if(position != m_mousePosition)
        {
            m_mousePosition = position;
            m_onMousePosition.Invoke(m_mousePosition);
            PushDebug();
        }
    }

    public void OnDisable()
    {
        m_mousePositionRef.action.Disable();
        m_mouseScrollRef.action.Disable();
        m_mouseLeftPressingRef.action.Disable();
        m_mouseRightPressingRef.action.Disable();
        m_mouseMiddlePressingRef.action.Disable();

        m_mousePositionRef.action.performed -= OnMousePosition;
        m_mouseScrollRef.action.performed -= OnMouseScroll;
        m_mouseLeftPressingRef.action.performed -= OnMouseLeftPressing;
        m_mouseRightPressingRef.action.performed -= OnMouseRightPressing;
        m_mouseMiddlePressingRef.action.performed -= OnMouseMiddlePressing;

        m_mousePositionRef.action.canceled -= OnMousePosition;
        m_mouseScrollRef.action.canceled -= OnMouseScroll;
        m_mouseLeftPressingRef.action.canceled -= OnMouseLeftPressing;
        m_mouseRightPressingRef.action.canceled -= OnMouseRightPressing;
        m_mouseMiddlePressingRef.action.canceled -= OnMouseMiddlePressing;

    }

    public bool m_isDebuggingLine;
    public UnityEvent<string> m_onLinerDebug;
    private void PushDebug()
    {
        if (m_isDebuggingLine)
        {
            string debug = string.Join(" ", new string[] {
                "L:", m_isLeftPressing.ToString(),
                "R:", m_isRightPressing.ToString(),
                "M:", m_isMiddlePressing.ToString(),
                "P:", m_mousePosition.ToString() }
                );
            m_onLinerDebug.Invoke(debug);
        }
    }
}
