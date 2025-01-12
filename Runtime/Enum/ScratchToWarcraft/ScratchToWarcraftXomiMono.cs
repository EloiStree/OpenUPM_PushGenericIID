using UnityEngine;
using UnityEngine.Events;

public class ScratchToWarcraftXomiMono : MonoBehaviour {


    public UnityEvent<int> m_onIntegerActionPushed;


    public void PushInteger(int i)
    {
        if(m_onIntegerActionPushed!=null) 
            m_onIntegerActionPushed.Invoke(i);
    }

    public static int FetchInteger(EnumScratchToWarcraftGamepad enumScratchToWarcraftXOMI, bool press)
    {
        int i = (int)enumScratchToWarcraftXOMI;
        return press?i:i+1000;
    }

    public void PressA(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressA,isPressing));
    public void PressX(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressX,isPressing));
    public void PressB(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressB,isPressing));
    public void PressY(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressY,isPressing));
    public void PressLeftSideButton(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressLeftSideButton,isPressing));
    public void PressRightSideButton(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressRightSideButton,isPressing));
    public void PressLeftStick(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressLeftStick,isPressing));
    public void PressRightStick(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressRightStick,isPressing));
    public void PressMenuRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressMenuRight,isPressing));
    public void PressMenuLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressMenuLeft,isPressing));
    public void RandomInputForAllGamepadsNoMenu(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.RandomInputForAllGamepadsNoMenu,isPressing));
    public void EnableHardwareJoystickONOFF(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.EnableHardwareJoystickONOFF,isPressing));
    public void ReleaseDPad(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.ReleaseDPad,isPressing));
    public void PressArrowNorth(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowNorth,isPressing));
    public void PressArrowNortheast(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowNortheast,isPressing));
    public void PressArrowEast(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowEast,isPressing));
    public void PressArrowSoutheast(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowSoutheast,isPressing));
    public void PressArrowSouth(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowSouth,isPressing));
    public void PressArrowSouthwest(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowSouthwest,isPressing));
    public void PressArrowWest(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowWest,isPressing));
    public void PressArrowNorthwest(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressArrowNorthwest,isPressing));
    public void PressXboxHomeButton(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.PressXboxHomeButton,isPressing));
    public void RandomAxis(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.RandomAxis,isPressing));
    public void StartRecording(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.StartRecording,isPressing));
    public void SetLeftStickToNeutralClockwise(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickToNeutralClockwise,isPressing));
    public void MoveLeftStickUp(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickUp,isPressing));
    public void MoveLeftStickUpRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickUpRight,isPressing));
    public void MoveLeftStickRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickRight,isPressing));
    public void MoveLeftStickDownRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickDownRight,isPressing));
    public void MoveLeftStickDown(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickDown,isPressing));
    public void MoveLeftStickDownLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickDownLeft,isPressing));
    public void MoveLeftStickLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickLeft,isPressing));
    public void MoveLeftStickUpLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToLeftStickUpLeft,isPressing));
    public void SetRightStickToNeutralClockwise(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickToNeutralClockwise,isPressing));
    public void MoveRightStickUp(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickUp,isPressing));
    public void MoveRightStickUpRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickUpRight,isPressing));
    public void MoveRightStickRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickRight,isPressing));
    public void MoveRightStickDownRight(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickDownRight,isPressing));
    public void MoveRightStickDown(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickDown,isPressing));
    public void MoveRightStickDownLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickDownLeft,isPressing));
    public void MoveRightStickLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickLeft,isPressing));
    public void MoveRightStickUpLeft(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetToRightStickUpLeft,isPressing));
    public void SetLeftStickHorizontalTo1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalTo1,isPressing));
    public void SetLeftStickHorizontalToMinus1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalToMinus1,isPressing));
    public void SetLeftStickVerticalTo1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalTo1,isPressing));
    public void SetLeftStickVerticalToMinus1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalToMinus1,isPressing));
    public void SetRightStickHorizontalTo1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalTo1,isPressing));
    public void SetRightStickHorizontalToMinus1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalToMinus1,isPressing));
    public void SetRightStickVerticalTo1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalTo1,isPressing));
    public void SetRightStickVerticalToMinus1(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalToMinus1,isPressing));
    public void SetLeftTriggerTo100(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftTriggerTo100,isPressing));
    public void SetRightTriggerTo100(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightTriggerTo100,isPressing));
    public void SetLeftStickHorizontalTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalTo75,isPressing));
    public void SetLeftStickHorizontalToMinus75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalToMinus75,isPressing));
    public void SetLeftStickVerticalTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalTo75,isPressing));
    public void SetLeftStickVerticalToMinus75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalToMinus75,isPressing));
    public void SetRightStickHorizontalTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalTo75,isPressing));
    public void SetRightStickHorizontalToMinus75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalToMinus75,isPressing));
    public void SetRightStickVerticalTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalTo75,isPressing));
    public void SetRightStickVerticalToMinus75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalToMinus75,isPressing));
    public void SetLeftTriggerTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftTriggerTo75,isPressing));
    public void SetRightTriggerTo75(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightTriggerTo75,isPressing));
    public void SetLeftStickHorizontalTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalTo50,isPressing));
    public void SetLeftStickHorizontalToMinus50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalToMinus50,isPressing));
    public void SetLeftStickVerticalTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalTo50,isPressing));
    public void SetLeftStickVerticalToMinus50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalToMinus50,isPressing));
    public void SetRightStickHorizontalTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalTo50,isPressing));
    public void SetRightStickHorizontalToMinus50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalToMinus50,isPressing));
    public void SetRightStickVerticalTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalTo50,isPressing));
    public void SetRightStickVerticalToMinus50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalToMinus50,isPressing));
    public void SetLeftTriggerTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftTriggerTo50,isPressing));
    public void SetRightTriggerTo50(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightTriggerTo50,isPressing));
    public void SetLeftStickHorizontalTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalTo25,isPressing));
    public void SetLeftStickHorizontalToMinus25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickHorizontalToMinus25,isPressing));
    public void SetLeftStickVerticalTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalTo25,isPressing));
    public void SetLeftStickVerticalToMinus25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftStickVerticalToMinus25,isPressing));
    public void SetRightStickHorizontalTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalTo25,isPressing));
    public void SetRightStickHorizontalToMinus25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickHorizontalToMinus25,isPressing));
    public void SetRightStickVerticalTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalTo25,isPressing));
    public void SetRightStickVerticalToMinus25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightStickVerticalToMinus25,isPressing));
    public void SetLeftTriggerTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetLeftTriggerTo25,isPressing));
    public void SetRightTriggerTo25(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.SetRightTriggerTo25,isPressing));
    public void ReleaseAllTouch(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.ReleaseAllTouch,isPressing));
    public void ReleaseAllTouchButMenu(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.ReleaseAllTouchButMenu,isPressing));
    public void ClearTimedCommand(bool isPressing)=> PushInteger(FetchInteger(EnumScratchToWarcraftGamepad.ClearTimedCommand,isPressing));
}
