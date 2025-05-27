using UnityEngine;
public class Int1899Parser {



    public static void SetPlayerId(byte playerId1To18, int valueIn, out int valueOut)
    {
        RecoverValue999999(valueIn, out int value666666);
        RecoverTag99(valueIn, out byte tag99);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }
    public static void SetTag99(byte tag99, int valueIn, out int valueOut)
    {
        RecoverValue999999(valueIn, out int value666666);
        RecoverPlayerId(valueIn, out byte playerId1To18);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }
    public static void SetPlayerAndTag99(byte playerId1To18, byte tag99, int valueIn, out int valueOut)
    {
        RecoverValue999999(valueIn, out int value666666);
        valueOut = playerId1To18 * 100000000 + tag99 * 1000000 + value666666;
    }

    public static void RecoverPlayerId(int value, out byte playerId1To18)
    {
        value = (value / 10000000);
        if (value < 0)
            value = -value;
        playerId1To18 = (byte)(value % 18);
    }
    static void RecoverTag99(int value, out byte tag99)
    {
        int tagPart = (value / 1000000) % 100;
        if (tagPart<0) tagPart = -tagPart;
        tag99 = (byte)tagPart;
    }
    public static void RecoverValue999999(int value, out int value666666)
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
        int x = (int)(quaternion.x * 100000f);
        int y = (int)(quaternion.y * 100000f);
        int z = (int)(quaternion.z * 100000f);
        int w = (int)(quaternion.w * 100000f);

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
        position = new Vector3(
            (x2_999999 + x1_999_999 * 1000000f) / 1000f,
            (y2_999999 + y1_999_999 * 1000000f) / 1000f,
            (z2_999999 + z1_999_999 * 1000000f) / 1000f
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
        in float value, out int part999_999, out int part999999) {


        RoundFloatValue(value* 1000f, out double roundedValue);
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


        part999_999 += playerId1To18 * 100000000 + type99P1 * 1000000;
        part999999 += playerId1To18 * 100000000 + type99P2  * 1000000;

        if (sign)
        {
            part999_999 = -part999_999;
            part999999 = -part999999;
        }
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
