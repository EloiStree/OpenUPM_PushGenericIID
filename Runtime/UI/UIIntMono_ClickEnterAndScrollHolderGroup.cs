using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIIntMono_ClickEnterAndScrollHolderGroup : MonoBehaviour
{
    public UnityEvent<int> m_onIntegerAction;

    public UIIntMono_IntegerHandlerEvent [] m_group;
    public bool m_autoUpdateWithChildren = true;
    public void Awake()
    {
        if (m_autoUpdateWithChildren)
            UpdateGroupListFromChilddren();
    }


    [ContextMenu("Refresh List")]
    public void UpdateGroupListFromChilddren()
    {
        m_group = GetComponentsInChildren<UIIntMono_IntegerHandlerEvent>();
        for (int i = 0; i < m_group.Length; i++)
        {
            if(m_group[i] != null)
                m_group[i].m_onIntegerAction.AddListener(PushInteger);
        }
    }

    public void PushInteger(int integerValue)
    {
        if(this.gameObject.activeInHierarchy)
            m_onIntegerAction.Invoke(integerValue);
    }
}
