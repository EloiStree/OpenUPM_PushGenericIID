using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RawIntEventMono_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public struct STRUCT_DialArrowIntAction
{

    public int[] m_upAction;
    public int[] m_upRightAction;
    public int[] m_rightAction;
    public int[] m_downRightAction;
    public int[] m_downAction;
    public int[] m_downLeftAction;
    public int[] m_leftAction;
    public int[] m_upLeftAction;

}


public struct STRUCT_CrossArrowIntAction
{
    public int[] m_upAction;
    public int[] m_rightAction;
    public int[] m_downAction;
    public int[] m_leftAction;
}

public class IntEvent_FromVector2DialArrow
{
    public STRUCT_DialArrowIntAction m_dialAction;

}
public class IntEvent_FromVector2CrossArrow {

    STRUCT_CrossArrowIntAction m_crossAction;

}

[System.Serializable]
public class FloatRangeIntActionBoundary
{
    public float m_boundaryA = 1;
    public float m_boundaryB = 0.8f;
    public int[] m_enterAction;
    public int[] m_exitAction;
    public bool m_isInRange = false;
}


[System.Serializable]
public class IntEvent_FromFloat
{

    public UnityEvent<int> m_onIntegerAction;
    public float m_currentValue = 0;
    public float m_previousValue = 0;

    public FloatRangeIntActionBoundary[] m_rangeActions = new FloatRangeIntActionBoundary[]{

        new FloatRangeIntActionBoundary{m_boundaryA=-1f,m_boundaryB=-0.8f,m_enterAction=new int[]{1001},m_exitAction=new int[]{2000}},
        new FloatRangeIntActionBoundary{m_boundaryA=-0.8f,m_boundaryB=-0.1f,m_enterAction=new int[]{1002},m_exitAction=new int[]{2001}},
        new FloatRangeIntActionBoundary{m_boundaryA=0.1f,m_boundaryB=0.5f,m_enterAction=new int[]{1003},m_exitAction=new int[]{2002}},
        new FloatRangeIntActionBoundary{m_boundaryA=0.8f,m_boundaryB=1.0f,m_enterAction=new int[]{1004},m_exitAction=new int[]{2003}},
    };

    public void PushIn(float value)
    {

        m_previousValue = m_currentValue;
        m_currentValue = value;

        foreach (FloatRangeIntActionBoundary rangeAction in m_rangeActions)
        {
            bool previousIn = m_previousValue >= rangeAction.m_boundaryA && m_previousValue <= rangeAction.m_boundaryB;
            bool currentIn = m_currentValue >= rangeAction.m_boundaryA && m_currentValue <= rangeAction.m_boundaryB;
            rangeAction.m_isInRange = currentIn;
            if (currentIn && !previousIn)
            {
                for (int i = 0; i < rangeAction.m_enterAction.Length; i++)
                {
                    m_onIntegerAction.Invoke(rangeAction.m_enterAction[i]);
                }
            }
            if (!currentIn && previousIn)
            {
                for (int i = 0; i < rangeAction.m_exitAction.Length; i++)
                {
                    m_onIntegerAction.Invoke(rangeAction.m_exitAction[i]);
                }
            }
        }

    }
}

[System.Serializable]
public class IntEvent_FromBoolean
{
    public UnityEvent<int> m_onIntegerAction;
    public int[] m_onTrue= new int [] { 1000} ;
    public int[] m_onFalse = new int[] { 2000 };
    public int[] m_onChanged = new int[] { };

    public bool m_value;
    public void PushIn(bool value) { 
    
        bool previousValue = m_value;
        m_value = value;
        if (m_value != previousValue)
        {
            if (m_value)
            {
                for (int i = 0; i < m_onTrue.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_onTrue[i]);
                }
            }
            else
            {
                for (int i = 0; i < m_onFalse.Length; i++)
                {
                    m_onIntegerAction.Invoke(m_onFalse[i]);
                }
            }
            for (int i = 0; i < m_onChanged.Length; i++)
            {
                m_onIntegerAction.Invoke(m_onChanged[i]);
            }

        }
    }
}
