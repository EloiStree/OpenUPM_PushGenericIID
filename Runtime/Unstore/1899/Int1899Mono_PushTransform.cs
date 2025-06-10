using System;
using UnityEngine;
public class Int1899Parser {



    public static void SetPlayerId(byte playerId1To18, int valueIn, out int valueOut)
    {
        GetValue999999(valueIn, out int value666666);
        GetTag99(valueIn, out byte tag99);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }
    public static void SetTag99(byte tag99, int valueIn, out int valueOut)
    {
        GetValue999999(valueIn, out int value666666);
        GetPlayerId(valueIn, out byte playerId1To18);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }
    public static void SetPlayerAndTag99(byte playerId1To18, byte tag99, int valueIn, out int valueOut)
    {
        GetValue999999(valueIn, out int value666666);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }

    public static void GetPlayerId(int value, out byte playerId1To18)
    {
        value = (value / 100000000);
        if (value < 0)
            value = -value;
        playerId1To18 = (byte)(value % 20);
    }
    public static void GetTag99(int value, out byte tag99)
    {
        int tagPart = (value / 1000000) % 100;
        if (tagPart<0) tagPart = -tagPart;
        tag99 = (byte)tagPart;
    }
    public static void GetValue999999(int value, out int value666666)
    {
        value666666 = value % 1000000;
    }

    public static void ToIntLongitudeLatitude(byte playerId1To18, in Vector2 coordinateGPS,
        out int longitude999999, out int latitude999999)
    {

        bool longSign = coordinateGPS.x < 0;
        bool latSign = coordinateGPS.y < 0;
        int longitude999999Part = (int)((System.Math.Abs((double)coordinateGPS.x) * 1000.0));
        int latitude999999Part = (int)((System.Math.Abs((double)coordinateGPS.y)  * 1000.0));


        // Convert longitude and latitude to 6 decimal places
        longitude999999 = playerId1To18 * 100000000 + 12000000 + longitude999999Part;
        latitude999999 = playerId1To18 * 100000000 + 13000000 + latitude999999Part;
        if (coordinateGPS.x < 0) longitude999999 = -longitude999999;
        if (coordinateGPS.y < 0) latitude999999 = -latitude999999;


    }


    public static void ToIntQuaternionRotation(byte playerId1To18, in Quaternion quaternion,
        out int x1_999999,
        out int y1_999999,
        out int z1_999999,
        out int w1_999999)
    {
        bool signX = quaternion.x < 0;
        bool signY = quaternion.y < 0;
        bool signZ = quaternion.z < 0;
        bool signW = quaternion.w < 0;

        int x = (int)(quaternion.x * 100000f);
        int y = (int)(quaternion.y * 100000f);
        int z = (int)(quaternion.z * 100000f);
        int w = (int)(quaternion.w * 100000f);
        if (x < 0) x = -x;
        if (y < 0) y = -y;
        if (z < 0) z = -z;
        if (w < 0) w = -w;


        x1_999999 = playerId1To18 * 100000000 + 8000000 + x;
        y1_999999 = playerId1To18 * 100000000 + 9000000 + y;
        z1_999999 = playerId1To18 * 100000000 + 10000000 + z;
        w1_999999 = playerId1To18 * 100000000 + 11000000 + w;

        if (quaternion.x < 0) x1_999999 = -x1_999999;
        if (quaternion.y < 0) y1_999999 = -y1_999999;
        if (quaternion.z < 0) z1_999999 = -z1_999999;
        if (quaternion.w < 0) w1_999999 = -w1_999999;

    }

    public static void ToIntEulerRotation(byte playerId1To18, in Vector3 eulerCompressed,
        out int eulerCompressedInt)
    {

        int x360 = MapAngle0To360To0To99(eulerCompressed.x);
        int y360 = MapAngle0To360To0To99(eulerCompressed.y);
        int z360 = MapAngle0To360To0To99(eulerCompressed.z);
        eulerCompressedInt = playerId1To18 * 100000000 + 7000000 + x360 * 10000 + y360 * 100 + z360;

    }
    public static void ToIntTransfromPosition(byte playerId1To18, in Vector3 position,
        out int x1_999_999, out int x2_999999,
        out int y1_999_999, out int y2_999999,
        out int z1_999_999, out int z2_999999
        )
    { 
        BuildFloatValueTo999999999_999( playerId1To18,1,2, position.x, out x1_999_999, out x2_999999);
        BuildFloatValueTo999999999_999( playerId1To18,3,4, position.y, out y1_999_999, out y2_999999);
        BuildFloatValueTo999999999_999( playerId1To18,5,6, position.z, out z1_999_999, out z2_999999);
    }

    public static void FromIntTranformPosition(
        in int x1_999_999, in int x2_999999,
        in int y1_999_999, in int y2_999999,
        in int z1_999_999, in int z2_999999,
        out Vector3 position)
    {
        GetValue999999(x1_999_999, out int fx1_999_999);
        GetValue999999(x2_999999, out int fx2_999999);
        GetValue999999(y1_999_999, out int fy1_999_999);
        GetValue999999(y2_999999, out int fy2_999999);
        GetValue999999(z1_999_999, out int fz1_999_999);
        GetValue999999(z2_999999, out int fz2_999999);

        position = new Vector3(
            (fx1_999_999 + fx2_999999  * 1000000f) / 10000f,
            (fy1_999_999 + fy2_999999  * 1000000f) / 10000f,
            (fz1_999_999 + fz2_999999  * 1000000f) / 10000f
        );
    }

    public static void RoundFloatValue(in float value ,out double roundedValue)
    {
        // Round the float value to 3 decimal places
        roundedValue = System.Math.Round(value, 3);
    }
    public static void BuildFloatValueTo999999999_999(
        in byte playerId1To18,
        in byte type99P1,
        in byte type99P2,
        in float value, out int part999_999, out int part999999)
    {


        RoundFloatValue(value * 10000f, out double roundedValue);
        double valueAsDouble = roundedValue;
        bool sign = valueAsDouble < 0;

        if (sign) valueAsDouble = -valueAsDouble;

        part999_999 = (int)(valueAsDouble % 1000000.0);
        part999999 = (int)(valueAsDouble / 1000000.0);

        if (valueAsDouble <= 9999999) { }
        else if (valueAsDouble <= 99999999) { part999_999 = (part999_999 / 10) * 10; }
        else if (valueAsDouble <= 999999999) { part999_999 = (part999_999 / 100) * 100; }
        else if (valueAsDouble <= 9999999999) { part999_999 = (part999_999 / 1000) * 1000; }
        else if (valueAsDouble <= 99999999999) { part999_999 = (part999_999 / 10000) * 10000; }
        else if (valueAsDouble <= 999999999999) { part999_999 = (part999_999 / 100000) * 100000; }
        else if (valueAsDouble <= 9999999999999) { part999_999 = (part999_999 / 1000000) * 1000000; }
    

        TagIntegerWithPlayerAndType(ref part999_999, playerId1To18, type99P1);
        TagIntegerWithPlayerAndType(ref part999999, playerId1To18, type99P2);

    }

    // Maps an angle in [0, 360) to an integer in [0, 99]
    public static int MapAngle0To360To0To99(float angle)
    {
        // Ensure angle is in [0, 360)
        float normalized = angle % 360f;
        if (normalized < 0) normalized += 360f;
        // Map to [0, 99] (inclusive)
        return (int)(normalized / 360f * 100f);
    }

    public static void ToIntJoystickAndTrigger999999(out int percent9, 
        byte playerId1To16,
        byte typeTag99,
        float leftJoystickXPercent11,
        float leftJoystickYPercent11,
        float rightJoystickXPercent11,
        float rightJoystickYPercent11,
        float leftTrigger,
        float rightTrigger)
    {
        int leftX9 = PercentFloatTo9(leftJoystickXPercent11);
        int leftY9 = PercentFloatTo9(leftJoystickYPercent11);
        int rightX9 = PercentFloatTo9(rightJoystickXPercent11);
        int rightY9 = PercentFloatTo9(rightJoystickYPercent11);
        int leftTrigger9 = PercentFloatTo9(leftTrigger);
        int rightTrigger9 = PercentFloatTo9(rightTrigger);

        percent9 = leftX9 * 100000
                   + leftY9 * 10000
                   + rightX9 * 1000
                   + rightY9 * 100
                   + leftTrigger9 * 10
                   + rightTrigger9;

        TagIntegerWithPlayerAndType(ref percent9, playerId1To16, typeTag99);


    }
    public static void ToIntFloatToPercent11To999999(
        out int percent999999,
        byte playerId1To16,
        byte typeTag99,
        float percentValue11)
    {

        int value = PercentFloat11To999999(percentValue11);
        TagIntegerWithPlayerAndType(ref value, playerId1To16, typeTag99);
        percent999999 = value;
    }

    public static void ToIntFloatToPercent01To999999(
       out int percent999999,
       byte playerId1To16,
       byte typeTag99,
       float percentValue11)
    {

        int value = PercentFloat01To999999(percentValue11);
        TagIntegerWithPlayerAndType(ref value, playerId1To16, typeTag99);
        percent999999 = value;
    }



    private static int PercentFloatTo9(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1f, 1f);
        if (percent11 == 0f) return 0;
        percent11 = (percent11 + 1f) / 2f; // Maps -1 to 0, 0 to 1, and 1 to 2
        percent11 = Mathf.Clamp(percent11, 0f, 1f); // Ensure it's in [0, 1]
        percent11 =1+ percent11 * 8f; // Scale to [1, 8]
        if (percent11 < 1) percent11 = 1; // Ensure minimum value is 1
        if (percent11 > 9) percent11 = 9; // Ensure maximum value is 9
        return (int)Mathf.Round(percent11);
    }

    public static int PercentFloat11To999999(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1f, 1f);
        if (percent11 == 0f) return 0;
        percent11 = (percent11 + 1f) / 2f; // Maps -1 to 0, 0 to 1, and 1 to 2
        percent11 = Mathf.Clamp(percent11, 0f, 1f); // Ensure it's in [0, 1]
        percent11 = percent11 * 999999f; // Scale to [1, 999999]
        if (percent11 < 1) percent11 = 1; // Ensure minimum value is 1
        if (percent11 > 999999) percent11 = 999999; // Ensure maximum value is 999999
        return (int)Mathf.Round(percent11);
    }

    public static int PercentFloat01To999999(float percent01)
    {
        percent01 = Mathf.Clamp(percent01, 0f, 1f);
        if (percent01 == 0f) return 0;
        percent01 = percent01 * 999999f; // Scale to [1, 999999]
        if (percent01 < 1) percent01 = 1; // Ensure minimum value is 1
        if (percent01 > 999999) percent01 = 999999; // Ensure maximum value is 999999
        return (int)Mathf.Round(percent01);
    }

    public static int PercentFloatTo999(float percent11)
    {
        percent11 = Mathf.Clamp(percent11, -1f, 1f);
        if (percent11 == 0f) return 0;
        percent11 = (percent11 + 1f) / 2f; // Maps -1 to 0, 0 to 1, and 1 to 2
        percent11 = Mathf.Clamp(percent11, 0f, 1f); // Ensure it's in [0, 1]
        percent11 = 1f + percent11 * 998f; // Scale to [1, 999]
        if (percent11 < 1) percent11 = 1; // Ensure minimum value is 1
        if (percent11 > 999) percent11 = 999; // Ensure maximum value is 999
        return (int)Mathf.Round(percent11);
    }

  

    public static void TagIntegerWithPlayerAndType(
        ref int intToTag,
        byte playerIdFrom0To20Max,
        byte typeOfDataFrom0To99max)
    {

        bool negativeValue = intToTag < 0;
        int value = intToTag % 1000000;

        if (negativeValue)
        {
            value = -value;
        }


        if (playerIdFrom0To20Max > 19)
        {
            playerIdFrom0To20Max = 19; // Clamp to max player ID
        }
        else if (playerIdFrom0To20Max < 0)
        {
            playerIdFrom0To20Max = 0; // Clamp to min player ID
        }

        if (typeOfDataFrom0To99max > 99)
        {
            typeOfDataFrom0To99max = 99; // Clamp to max tag
        }
        else if (typeOfDataFrom0To99max < 0)
        {
            typeOfDataFrom0To99max = 0; // Clamp to min tag
        }
;
        intToTag = playerIdFrom0To20Max * 100000000 + typeOfDataFrom0To99max * 1000000 + value;
        if (negativeValue)
        {
            intToTag = -intToTag;
        }

    }

    public static void ToIntFloatToDoublePercent999(
        out int buildInt999,
        byte player1To16,
        byte tag99,
        float percentValue)
    {
        buildInt999 = PercentToInt999( percentValue);
        TagIntegerWithPlayerAndType(ref buildInt999, player1To16, tag99);

    }

    public static int PercentToInt999( float percentValue)
    {
        if (percentValue == 0f) return 0; // Handle zero case directly

        int buildInt999;
        percentValue = Mathf.Clamp(percentValue, -1f, 1f); // Ensure it's in [-1, 1]
        percentValue = (percentValue + 1f) / 2f; // Maps [-1, 1] to [0, 1]
        percentValue = Mathf.Clamp(percentValue, 0f, 1f); // Ensure it's in [0, 1]
        percentValue = 1f + percentValue * 998f; // Scale to [1, 999]
        buildInt999 = (int)Mathf.Round(percentValue);
        if (buildInt999 < 1) buildInt999 = 1; // Ensure minimum value is 1
        if (buildInt999 > 999) buildInt999 = 999; // Ensure maximum value is 999
        return buildInt999;
    }

    public static void ToIntFloatToDoublePercent999999(
        out int buildInt999999,
        byte player1To16,
        byte tag99,
        float percentLeftPart,
        float percentRightPart)
    {
        int leftPart = PercentToInt999(percentLeftPart);
        int rightPart = PercentToInt999(percentRightPart);
        buildInt999999 = leftPart * 1000 + rightPart;
        TagIntegerWithPlayerAndType(ref buildInt999999, player1To16, tag99);
    }

    internal static int ToIntScratchToWarcraftCommand(
        byte player1To16,
        byte tag99,
        bool pressingAction,
        EnumScratchToWarcraftGamepad action)
    {
        int value = (int)action;
        if (pressingAction)
        {
            value += 1000; // Offset for pressing actions
        }
        TagIntegerWithPlayerAndType(ref value, player1To16, tag99);
        return value;
    }

    public static void FromIntTranformEuler(in int intEulerValue, out Vector3 euler)
    {
        float x360 = (intEulerValue / 10000) % 100 /100f;
        float y360 = (intEulerValue / 100) % 100 / 100f;
        float z360 = intEulerValue % 100 / 100f;
        euler = new Vector3(
            x360 * 360f,
            y360 * 360f,
            z360 * 360f
        );
    }

    public static void FromIntTranformQuaternion(
        in int qX,
        in int qY,
        in int qZ,
        in int qW,
        out Quaternion rotation)
    {
        float x =Mathf.Abs((qX % 1000000) / 100000f);
        float y =Mathf.Abs((qY % 1000000) / 100000f);
        float z =Mathf.Abs((qZ % 1000000) / 100000f);
        float w =Mathf.Abs((qW % 1000000) / 100000f);
        if (qX < 0) x = -x;
        if (qY < 0) y = -y;
        if (qZ < 0) z = -z;
        if (qW < 0) w = -w;
        rotation = new Quaternion(x, y, z, w);
    }

    public static int ToIntScale(float scale)
    {
        return Mathf.RoundToInt(scale * 1000f);
    }

    public static float FromIntToScale(int scaleAsInt999999)
    {
        GetValue999999(scaleAsInt999999, out int scaleAsInt999999Part);
        float scale = scaleAsInt999999Part / 1000f;
        if (scale < 0) scale = -scale;
        return scale;
    }
}
public class Int1899Mono_PushTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // 18 01 X1 666,666
        // 18 02 X2 666666000000
        // 18 03 Y1 666,666
        // 18 04 Y2 666666000000
        // 18 05 Z1 666,666
        // 18 06 Z2 666666000000
        // 18 07 Euleur Compressed 998877
        // 18 08 Quaternion X 0.666666
        // 18 09 Quaternion Y 0.666666
        // 18 10 Quaternion Z 0.666666
        // 18 11 Quaternion W 0.666666
        // 18 12 GPS Longitude 509999
        // 18 13 GPS Latitude 509999
        // 18 20 Joystick 9 Trigger 99 99 99 Lxy Rxy Tlr
        // 18 21 Joystick 999 Left X Y
        // 18 22 Joystick 999 Right X Y
        // 18 23 Joystick 666666 Left X 
        // 18 24 Joystick 666666 Left Y
        // 18 25 Joystick 666666 Right X
        // 18 26 Joystick 666666 Right Y

        // 18 41 Velocity Liftoff Speed m/s x
        // 18 42 Velocity Liftoff Speed m/s y
        // 18 43 Velocity Liftoff Speed m/s z
        // 18 44 Rotation Liftoff Yaw m/s
        // 18 45 Rotation Liftoff Pitch m/s
        // 18 46 Rotation Liftoff Roll m/s

        // 18 50 Battery Percent 999999
        // 18 51 Battery Voltage 9,99999

        // 18 70 Local IntPtr Handle part 1
        // 18 71 Local IntPtr Handle part 2
        // 18 72 Local IPV4 part 1 255255
        // 18 73 Local IPV4 part 2 255255
        // 18 74 Local IPV4 IID PORT IN  999999


    }

}
