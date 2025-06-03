
/// <summary>
/// If you use IID you can set the player form the index.
/// But when you make trusted multiplayer game you only have an integer to share.
/// So you can use the the first digit for th player ID.
/// You case use the seconds 2 as type tag and the reste 666666 as value.
/// The 17-19 is use in my XOMI and ScratchToWarcraft convention. So I avoid it for a dual stick.
/// </summary>
[System.Serializable]
public struct STRUCT_16DualStick
{
    public byte m_playerId1To16;
    public STRUCT_DualStick m_dualStick;
}
