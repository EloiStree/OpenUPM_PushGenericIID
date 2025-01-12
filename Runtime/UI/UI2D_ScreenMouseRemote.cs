using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UI2D_ScreenMouseRemote : MonoBehaviour {

    public short m_intTag2020 = 15;
    public InputActionReference m_mousePosition;
    public InputActionReference m_mousePression;

    public float m_xLeftToRightPercent;
    public float m_yDownToTopPercent;
    public bool m_isPressing;

    public int m_pressAction = 1260;
    public int m_releaseAction = 2260;

    public UnityEvent<int> m_onMousePressEvent;
    public UnityEvent<int> m_onMouseReleaseEvent;

    public int m_currentMousePositionAsInteger;

    private void OnEnable()
    {
        m_mousePression.action.Enable();
        m_mousePression.action.performed += OnMousePression;
        m_mousePression.action.canceled += OnMousePression;

        m_mousePosition.action.Enable();
        m_mousePosition.action.performed += OnMousePosition;
        m_mousePosition.action.canceled += OnMousePosition;
    
    }

    private void OnDisable()
    {
        m_mousePression.action.performed -= OnMousePression;
        m_mousePression.action.canceled -= OnMousePression;

        m_mousePosition.action.performed -= OnMousePosition;
        m_mousePosition.action.canceled -= OnMousePosition;
    }

    private void OnMousePosition(InputAction.CallbackContext context)
    {
        Vector2 position = context.ReadValue<Vector2>();
        m_xLeftToRightPercent = position.x / Screen.width;
        m_yDownToTopPercent = position.y / Screen.height;
        m_xLeftToRightPercent = Mathf.Clamp01(m_xLeftToRightPercent);
        m_yDownToTopPercent = Mathf.Clamp01(m_yDownToTopPercent);

        IntegerToMousePosition2020Utility.ParseMousePosition2020ToInteger(
            out m_currentMousePositionAsInteger
            , m_intTag2020,
            m_xLeftToRightPercent,
            m_yDownToTopPercent);
    }

    private void OnMousePression(InputAction.CallbackContext context)
    {
        bool isPressing = m_isPressing;
        m_isPressing = context.ReadValue<float>() > 0;
        if(isPressing != m_isPressing)
        {
            if (m_isPressing)
            {
                m_onMousePressEvent.Invoke(m_currentMousePositionAsInteger);
                m_onMousePressEvent.Invoke(m_pressAction);
            }
            else             {
                m_onMouseReleaseEvent.Invoke(m_currentMousePositionAsInteger);
                m_onMouseReleaseEvent.Invoke(m_releaseAction);
            }
        }

    }
}
