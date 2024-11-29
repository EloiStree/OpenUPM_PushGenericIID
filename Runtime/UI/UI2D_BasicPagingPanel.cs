using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2D_BasicPagingPanel : MonoBehaviour
{
    public GameObject m_rootPanel;
    public GameObject[] m_pages;
    public int m_currentPageIndex = 0;
    public int m_preferStartIndex = 0;

    private void Awake()
    {
        RefreshPageFromPanel();
        SetToIndex(m_preferStartIndex);
    }

    [ContextMenu("Refresh Panels")]
    private void RefreshPageFromPanel()
    {
        if (m_rootPanel == null)
            return;
        m_pages = new GameObject[m_rootPanel.transform.childCount];
        for (int i = 0; i < m_rootPanel.transform.childCount; i++)
        {
            m_pages[i] = m_rootPanel.transform.GetChild(i).gameObject;
        }
    }

    [ContextMenu("Toggle UI")]
    public void ToggleUI()
    {
        m_rootPanel.SetActive(!m_rootPanel.activeSelf);
    }

    [ContextMenu("Turn On UI")]
    public void TurnOnUI()
    {
        m_rootPanel.SetActive(true);
    }
    [ContextMenu("Turn Off UI")]
    public void TurnOffUI()
    {
        m_rootPanel.SetActive(false);
    }

    [ContextMenu("Set to Zero")]
    public void SetToZero()
    {
        SetToIndex(0);
    }
    [ContextMenu("Set to Max")]
    public void SetToMax()
    {
        SetToIndex(m_pages.Length - 1);
    }

    public void SetToIndex(int index)
    {
        m_currentPageIndex = index% m_pages.Length;

        for (int i = 0; i < m_pages.Length; i++)
        {
            m_pages[i].SetActive(i == m_currentPageIndex);
        }
    }

    [ContextMenu("Next")]
    public void Next()
    {
        Next(1);
    }
    
    public void Next(int value)
    {
        m_currentPageIndex = (m_currentPageIndex + value) % m_pages.Length;
        if (m_currentPageIndex < 0)
            m_currentPageIndex += m_pages.Length; 

        for (int i = 0; i < m_pages.Length; i++)
        {
            m_pages[i].SetActive(i == m_currentPageIndex);
        }

    }

    [ContextMenu("Previous")]
    public void Previous()
    {
        Next(-1);
    }

}
