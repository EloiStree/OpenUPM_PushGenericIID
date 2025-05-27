using UnityEngine;

public class TDD_Int1899Mono : MonoBehaviour {



    public byte playerId1To18 = 18; // Player ID from 1 to 18
    
    
    byte m_type_01_x1 = 1;
    byte m_type_02_x2 = 2;
    byte m_type_03_y1 = 3;
    byte m_type_04_y2 = 4;
    byte m_type_05_z1 = 5;
    byte m_type_06_z2 = 6;
    byte m_type_07_eulerCompressed = 7;
    byte m_type_08_quaternionX = 8;
    byte m_type_09_quaternionY = 9;
    byte m_type_10_quaternionZ = 10;
    byte m_type_11_quaternionW = 11;
    byte m_type_12_gpsLongitude = 12;
    byte m_type_13_gpsLatitude = 13;

    byte m_type_20_joystick9Trigger = 20;
    byte m_type_21_joystick999LeftXY = 21;
    byte m_type_22_joystick999RightXY = 22;
    byte m_type_23_joystick666LeftX = 23;
    byte m_type_24_joystick666LeftY = 24;
    byte m_type_25_joystick666RightX = 25;
    byte m_type_26_joystick666RightY = 26;

    byte m_type_41_velocityLiftoffSpeedX = 41;
    byte m_type_42_velocityLiftoffSpeedY = 42;
    byte m_type_43_velocityLiftoffSpeedZ = 43;
    byte m_type_44_rotationLiftoffYaw = 44;
    byte m_type_45_rotationLiftoffPitch = 45;
    byte m_type_46_rotationLiftoffRoll = 46;

    byte m_type_50_batteryPercent = 50;
    byte m_type_51_batteryVoltage = 51;

    byte m_type_90_localIntPtrHandlePart1 = 90;
    byte m_type_91_localIntPtrHandlePart2 = 91;
    byte m_type_92_localIPV4Part1 = 92;
    byte m_type_93_localIPV4Part2 = 93;
    byte m_type_94_localIPV4InputPort = 94;


    public Vector3 m_positionToInt;

   public int x1_999_999;
   public int x2_999999;
   public int y1_999_999;
   public int y2_999999;
   public int z1_999_999;
   public int z2_999999;

    public Vector3 m_euler;
    public int m_eulerCompressedToInt;

    public Vector4 m_rotation;
    public int x1_999999;
    public int y1_999999;
    public int z1_999999;
    public int w1_999999;


    public Vector2 m_gps;
    public int m_gpsLongitude;
    public int m_gpsLatitude;
    [Header("From int")]

    public Vector3 m_positionFromInt;
    public Vector3 m_eulerFromtInt;

    private void OnValidate()
    {
        Int1899Parser.ToIntTransfromPosition(18, m_positionToInt,
            out x1_999_999, out x2_999999,
            out y1_999_999, out y2_999999,
            out z1_999_999, out z2_999999
        );
        Int1899Parser.FromIntTranformPosition(
            x1_999_999, x2_999999,
            y1_999_999, y2_999999,
            z1_999_999, z2_999999,
            out m_positionFromInt
            
        );

        Int1899Parser.ToIntEulerRotation(playerId1To18, m_euler, out m_eulerCompressedToInt);

        Quaternion rot = new Quaternion(m_rotation.x, m_rotation.y, m_rotation.z, m_rotation.w);
        Int1899Parser.ToIntQuaternionRotation(playerId1To18, rot,
            out x1_999999, out y1_999999, out z1_999999, out w1_999999);

        Int1899Parser.ToIntLongitudeLatitude(playerId1To18, m_gps,
            out m_gpsLongitude, out m_gpsLatitude);

    }
}
