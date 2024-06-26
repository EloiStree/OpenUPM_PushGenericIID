using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushGenericMono_JoinAndConfirmed : MonoBehaviour
{
    public UnityEvent<int> m_onIntegerPushed;

    public int m_joinInteger=123456789;
    public int m_confirmedJoinInteger=987654321;


    [ContextMenu("Join")]
    public void PushJoin()=> m_onIntegerPushed.Invoke(m_joinInteger);

    [ContextMenu("Confirmed")]
    public void PushConfirmed()=> m_onIntegerPushed.Invoke(m_confirmedJoinInteger);

    [ContextMenu("Join and confirmed")]
    public void PushJoinAndConfirmed() { m_onIntegerPushed.Invoke(m_joinInteger); m_onIntegerPushed.Invoke(m_confirmedJoinInteger); }

}
