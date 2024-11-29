using UnityEngine;
using UnityEngine.Events;

public class UI2D_OnPanelMouseClickIntegerGroup : MonoBehaviour

{
    public UnityEvent<int> m_onPress;
    public UnityEvent<int> m_onRelease;

    public UI2D_OnPanelMouseClickInteger[] m_buttons;
    public bool m_autoResetListAtStart=true;


    private void Start()
    {
        if (m_autoResetListAtStart)
        {
            ResetWithAllChildrens();
        }
        foreach (UI2D_OnPanelMouseClickInteger button in m_buttons)
        {
            button.m_onPress.AddListener(OnPress);
            button.m_onRelease.AddListener(OnRelease);
        }
    }

    private void Reset()
    {
        ResetWithAllChildrens();
    }
    [ContextMenu("Reset list with all childrens")]
    public void ResetWithAllChildrens()
    {
        m_buttons = GetComponentsInChildren<UI2D_OnPanelMouseClickInteger>();
    }

    private void OnRelease(int arg0)
    {
        m_onRelease.Invoke(arg0);
    }

    private void OnPress(int arg0)
    {
        m_onPress.Invoke(arg0); 
    }
}