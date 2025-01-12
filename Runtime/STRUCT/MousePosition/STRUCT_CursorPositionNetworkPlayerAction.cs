
/// <summary>
/// 1510009000 15 1000 9000 Move the mouse at 10% left and 90% down of screen space
/// Allows to make multiplayer game action to queue and dequeue
/// </summary>
public struct STRUCT_CursorPositionNetworkPlayerAction
{
    /// <summary>
    /// Mouse Position when action request occurred
    /// </summary>
    public STRUCT_CursorPosition2020 m_mousePosition;
    /// <summary>
    /// The player network id when action request occurred
    /// </summary>
    public int m_playerNetworkId;
    /// <summary>
    /// The player claim index id when action request occurred
    /// </summary>
    public int m_playerIndexId;
    /// <summary>   
    /// Action as integer to be used when dequeue for player action
    /// </summary>
    public int m_playerValueAction;
}


