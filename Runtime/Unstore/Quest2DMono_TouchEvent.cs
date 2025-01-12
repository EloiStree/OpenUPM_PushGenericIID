using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Quest2DMono_TouchEvent : MonoBehaviour
{
    
    public bool m_isPrimaryTouchPressing;
    public bool m_isSecondaryTouchPressing;

    public Vector2 m_primaryTouchPosition;
    public Vector2 m_secondaryTouchPosition;

    public Vector2 m_primaryTouchPositionStart;
    public Vector2 m_secondaryTouchPositionStart;


    public InputActionReference m_primaryTouchPressingRef;
    public InputActionReference m_secondaryTouchPressingRef;
    public InputActionReference m_primaryTouchPositionRef;
    public InputActionReference m_secondaryTouchPositionRef;
    public InputActionReference m_primaryTouchPositionStartRef;
    public InputActionReference m_secondaryTouchPositionStartRef;

    public UnityEvent<Vector2> m_onPrimaryTouchPosition;
    public UnityEvent<Vector2> m_onSecondaryTouchPosition;

    public UnityEvent<Vector2> m_onPrimaryTouchPositionStarted;
    public UnityEvent<Vector2> m_onSecondaryTouchPositionStarted;

    public UnityEvent<bool> m_onPrimaryTouchPressing;
    public UnityEvent<bool> m_onSecondaryTouchPressing;



    public void OnEnable()
    {
        m_primaryTouchPressingRef.action.Enable();
        m_secondaryTouchPressingRef.action.Enable();
        m_primaryTouchPositionRef.action.Enable();
        m_secondaryTouchPositionRef.action.Enable();
        m_primaryTouchPositionStartRef.action.Enable();
        m_secondaryTouchPositionStartRef.action.Enable();

        m_primaryTouchPressingRef.action.performed += OnPrimaryTouchPressing;
        m_secondaryTouchPressingRef.action.performed += OnSecondaryTouchPressing;
        m_primaryTouchPositionRef.action.performed += OnPrimaryTouchPosition;
        m_secondaryTouchPositionRef.action.performed += OnSecondaryTouchPosition;
        m_primaryTouchPositionStartRef.action.performed += OnPrimaryTouchPositionStarted;
        m_secondaryTouchPositionStartRef.action.performed += OnSecondaryTouchPositionStarted;


        m_primaryTouchPressingRef.action.canceled += OnPrimaryTouchPressing;
        m_secondaryTouchPressingRef.action.canceled += OnSecondaryTouchPressing;
        m_primaryTouchPositionRef.action.canceled += OnPrimaryTouchPosition;
        m_secondaryTouchPositionRef.action.canceled += OnSecondaryTouchPosition;
        m_primaryTouchPositionStartRef.action.canceled += OnPrimaryTouchPositionStarted;
        m_secondaryTouchPositionStartRef.action.canceled += OnSecondaryTouchPositionStarted;

    }

    private void OnPrimaryTouchPositionStarted(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        if (value != m_primaryTouchPositionStart) { 
            m_primaryTouchPositionStart = context.ReadValue<Vector2>();
            m_onPrimaryTouchPositionStarted.Invoke(m_primaryTouchPositionStart);
        }
    }

    private void OnSecondaryTouchPositionStarted(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        if (value != m_secondaryTouchPositionStart) { 
            m_secondaryTouchPositionStart = context.ReadValue<Vector2>();
            m_onSecondaryTouchPositionStarted.Invoke(m_secondaryTouchPositionStart);
        }
    }

    public void OnDisable()
    {

        m_primaryTouchPressingRef.action.performed -= OnPrimaryTouchPressing;
        m_secondaryTouchPressingRef.action.performed -= OnSecondaryTouchPressing;
        m_primaryTouchPositionRef.action.performed -= OnPrimaryTouchPosition;
        m_secondaryTouchPositionRef.action.performed -= OnSecondaryTouchPosition;
        m_primaryTouchPressingRef.action.performed -= OnPrimaryTouchPressing;
        m_secondaryTouchPressingRef.action.performed -= OnSecondaryTouchPressing;

        m_primaryTouchPressingRef.action.canceled -= OnPrimaryTouchPressing;
        m_secondaryTouchPressingRef.action.canceled -= OnSecondaryTouchPressing;
        m_primaryTouchPositionRef.action.canceled -= OnPrimaryTouchPosition;
        m_secondaryTouchPositionRef.action.canceled -= OnSecondaryTouchPosition;
        m_primaryTouchPositionStartRef.action.canceled -= OnPrimaryTouchPositionStarted;
        m_secondaryTouchPositionStartRef.action.canceled -= OnSecondaryTouchPositionStarted;

    }

    private void OnSecondaryTouchPosition(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        if (value != m_secondaryTouchPosition) { 
            m_secondaryTouchPosition = context.ReadValue<Vector2>();
            m_onSecondaryTouchPosition.Invoke(m_secondaryTouchPosition);
            PushDebug();
        }
    }

    public bool m_isDebuggingLine;
    public UnityEvent<string> m_onLinerDebug;
    private void PushDebug()
    {
        if(m_isDebuggingLine)
        {
            string debug = string.Join(" ", new string[] {
                "T0:", m_isPrimaryTouchPressing.ToString(),
                "T1:", m_isSecondaryTouchPressing.ToString(),
                "Tp0:", m_primaryTouchPosition.ToString(),
                "Tp1:", m_secondaryTouchPosition.ToString(),
                "Ts0:", m_primaryTouchPositionStart.ToString(),
                "Ts1:", m_secondaryTouchPositionStart.ToString()
            });
            m_onLinerDebug.Invoke(debug);
        }
    }

    private void OnPrimaryTouchPosition(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        if (value != m_primaryTouchPosition) { 
            m_primaryTouchPosition = context.ReadValue<Vector2>();
            m_onPrimaryTouchPosition.Invoke(m_primaryTouchPosition);
            PushDebug();
        }
    }

    private void OnSecondaryTouchPressing(InputAction.CallbackContext context)
    {
        bool isPressing = context.ReadValue<float>() > 0.5f;
        if(isPressing != m_isSecondaryTouchPressing)
        {
            m_isSecondaryTouchPressing = isPressing;
            m_onSecondaryTouchPressing.Invoke(isPressing);
            PushDebug();
        }
    }

    private void OnPrimaryTouchPressing(InputAction.CallbackContext context)
    {
        bool isPressing = context.ReadValue<float>() > 0.5f;
        if(isPressing != m_isPrimaryTouchPressing)
        {
            m_isPrimaryTouchPressing = isPressing;
            m_onPrimaryTouchPressing.Invoke(isPressing);
            PushDebug();
        }
    }
}
