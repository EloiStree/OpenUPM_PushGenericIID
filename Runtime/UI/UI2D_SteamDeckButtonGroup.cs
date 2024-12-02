using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UI2D_SteamDeckButtonGroup : MonoBehaviour
{
    public int m_tag2020 = 0000000000; //0100000000;
    public int m_addValuePress = 1800;
    public int m_addValueRelease =2800;
    public UnityEvent<int> m_steamDeckPusher; 
    public UI2D_SteamDeckButton[] m_buttons;
    public bool[] m_buttonsIsOn;

    public InputActionReference m_mousePosition;
    public InputActionReference m_mousePression;
    public bool m_isPressing;
    public Vector2 m_inputPosition;
    public int m_lastPushed;
    void Awake()
    {
        

        FetchButtonInChildrens();
    }

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
        m_inputPosition = context.ReadValue<Vector2>();
    }

    private void OnMousePression(InputAction.CallbackContext context)
    {
        bool previous = m_isPressing;
        m_isPressing = context.ReadValue<float>() > 0;
        if (m_steamDeckPusher == null)
            return;
        if (previous != m_isPressing)
        {
            if (m_isPressing)
            {
               
                for (int i = 0; i < m_buttons.Length; i++)
                {
                    if (m_buttons[i].IsMouseOverPanelPixel(m_inputPosition))
                    {
                        m_buttonsIsOn[i] = true;
                        PushIntegerAddTag(i+m_addValuePress);
                    }
                }
            }
            else
            {
                for (int i = 0; i < m_buttons.Length; i++)
                {
                    if (m_buttonsIsOn[i])
                    {
                        m_buttonsIsOn[i] = false;
                        PushIntegerAddTag(i + m_addValueRelease);
                    }
                }
            }
        }
    }

    private void PushIntegerAddTag(int i)
    {
        m_steamDeckPusher.Invoke(i + m_tag2020);
    }

    [ContextMenu("Fretch button in childrens")]
    private void FetchButtonInChildrens()
    {
        m_buttons = transform.GetComponentsInChildren<UI2D_SteamDeckButton>();
        m_buttonsIsOn = new bool[m_buttons.Length];
        for (int i = 0; i < m_buttons.Length; i++)
        {
            m_buttons[i].SetButtonIndex(i);
        }
    }
}
