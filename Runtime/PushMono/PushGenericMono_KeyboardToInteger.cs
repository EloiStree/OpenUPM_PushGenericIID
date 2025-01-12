
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

public class PushGenericMono_KeyboardToInteger : MonoBehaviour {



    public UnityEvent<int> m_onIntegerPushed;
    public int m_lastPressed;
    public int m_lastReleased;


    public List<Key> m_keysPressable = new List<Key>();

    public List<KeyControl> m_controls = new List<KeyControl>();
    public List<KeyControlItem> m_controlsItem = new List<KeyControlItem>();
    public List<KeyToIntegerAction> m_keyToInteger = new List<KeyToIntegerAction>();
    public string m_lastTextInput="";
    public int m_controlsCount;


    public List<Key> m_notUsed;

    [System.Serializable]
    public class KeyControlItem {
        public Key m_key;
        public int scanCode;
        public bool isPressed;
    }


    [System.Serializable]
    public class KeyToIntegerAction {
        public Key m_key;
        public int m_pressInteger;
        public int m_releaseInteger;
        public bool isPressed;

        public KeyToIntegerAction(Key key, int pressInteger)
        {
            m_key = key;
            m_pressInteger = pressInteger;
            m_releaseInteger = pressInteger + 1000;
        }
    }

    public void GetKeysList(out List<Key> keysList)
    { 
        keysList= Enum.GetValues(typeof(Key)).Cast<Key>().ToList() ;        
    }

    public void GetKeyInInteger(out List<Key> keysInInteger) { 
    
        keysInInteger = new List<Key>();
        foreach (KeyToIntegerAction key in m_keyToInteger)
        {
            keysInInteger.Add(key.m_key);
        }
    }
    public void GetKeyNotInUse(List<Key> keys, out List<Key> noUsed) { 
    
        GetKeysList(out List<Key> keysList);
        //get keys that are not in the list
        keys = keysList.Except(keys).ToList();
        noUsed = keys;
    }


    private void Reset()
    {
        RefreshListOfKeyObserved();
        GetKeyInInteger(out List<Key> keysInInteger);
        GetKeyNotInUse(keysInInteger, out m_notUsed);
    }


    private void AddKey(Key key, int integerPress)
    {
        m_keyToInteger.Add(new KeyToIntegerAction(key, integerPress));
    }

    public void Awake()
    {
        if (Keyboard.current!=null)
        {           
            Keyboard.current.onTextInput += (ch) => m_lastTextInput = ch.ToString();
            m_controls= Keyboard.current.allKeys.ToList();
            m_controlsCount = m_controls.Count;
            
            foreach (KeyControl control in m_controls)
            {
                KeyControlItem item = new KeyControlItem();
                item.m_key = control.keyCode;
                item.scanCode = control.scanCode;
                item.isPressed = control.isPressed;
                m_controlsItem.Add(item);
                m_keyControl[(int)control.keyCode] = control;
            }

        }
        RefreshListOfKey();

        for (int i = 0; i < m_keyToInteger.Count; i++)
        {
            m_pressArray[(int)m_keyToInteger[i].m_key] = m_keyToInteger[i].m_pressInteger;
            m_releaseArray[(int)m_keyToInteger[i].m_key] = m_keyToInteger[i].m_releaseInteger;
        }

    }


    public List<Key> m_isPressed = new List<Key>();
    public List<Key> m_wasPressed = new List<Key>();
    public List<Key> m_newlyPressed = new List<Key>();
    public List<Key> m_newlyReleased = new List<Key>();


     KeyControl[] m_keyControl = new KeyControl[255];
     int[] m_pressArray = new int[255];
     int[] m_releaseArray = new int[255];
     bool[] m_currentState= new bool[255];
     bool[] m_previousState= new bool[255];


    private void OnEnable()
    {
        InputSystem.onEvent += OnInputEvent;
        GetKeysList(out m_keysPressable);
    }

    private void OnDisable()
    {
        InputSystem.onEvent -= OnInputEvent;
    }
    public void Update()
    {
        CheckForChanged();
    }

    private void OnInputEvent(InputEventPtr eventPtr, InputDevice device)
    {
        if (device is Keyboard && eventPtr.IsA<StateEvent>())
        {
            CheckForChanged();
        }
    }
    private void OnKeyPressPerformed(InputAction.CallbackContext context)
    {
        CheckForChanged();
    }
    public void CheckForChanged()
    {
        if (Keyboard.current != null)
        {
            RefreshListOfKey();
           
        }

    }

    private void RefreshListOfKey()
    {
        m_newlyPressed.Clear();
        m_newlyReleased.Clear();
        foreach (Key key in m_keysPressable)
        { 
            KeyControl b = m_keyControl[(int)key];
            if(b==null)
                continue;
            bool isPressed = b.isPressed;
            m_previousState[(int)key]= m_currentState[(int)key];
            m_currentState[(int)key] = isPressed;

            if (m_currentState[(int)key] != m_previousState[(int)key])
            {
                if (isPressed)
                {
                    m_newlyPressed.Add(key);
                }
                else
                {
                    m_newlyReleased.Add(key);
                }
            }

        }
        foreach (Key key in m_newlyPressed)
        {
            int value = m_pressArray[(int)key];
            m_lastPressed = value;
            m_onIntegerPushed.Invoke(value);
        }
        foreach (Key key in m_newlyReleased)
        {
            int value = m_releaseArray[(int)key];
            m_lastReleased = value;
            m_onIntegerPushed.Invoke(value);
        }


    }






    private void RefreshListOfKeyObserved()
    {
        m_keyToInteger.Clear();

        AddKey(Key.Backspace, 1008);
        AddKey(Key.Tab, 1009);
        AddKey(Key.Enter, 1013);
        AddKey(Key.LeftShift, 1016);
        AddKey(Key.LeftCtrl, 1017);
        AddKey(Key.LeftAlt, 1018);
        AddKey(Key.Pause, 1019);
        AddKey(Key.CapsLock, 1020);
        AddKey(Key.Escape, 1027);
        AddKey(Key.Space, 1032);
        AddKey(Key.PageUp, 1033);
        AddKey(Key.PageDown, 1034);
        AddKey(Key.End, 1035);
        AddKey(Key.Home, 1036);
        AddKey(Key.LeftArrow, 1037);
        AddKey(Key.UpArrow, 1038);
        AddKey(Key.RightArrow, 1039);
        AddKey(Key.DownArrow, 1040);
        //Select 1041
        AddKey(Key.PrintScreen, 1042);
        //AddKey(Key.Execute, 1043);
        AddKey(Key.PrintScreen, 1044);
        AddKey(Key.Insert, 1045);
        AddKey(Key.Delete, 1046);
        AddKey(Key.Digit0, 1048);
        AddKey(Key.Digit1, 1049);
        AddKey(Key.Digit2, 1050);
        AddKey(Key.Digit3, 1051);
        AddKey(Key.Digit4, 1052);
        AddKey(Key.Digit5, 1053);
        AddKey(Key.Digit6, 1054);
        AddKey(Key.Digit7, 1055);
        AddKey(Key.Digit8, 1056);
        AddKey(Key.Digit9, 1057);
        AddKey(Key.A, 1065);
        AddKey(Key.B, 1066);
        AddKey(Key.C, 1067);
        AddKey(Key.D, 1068);
        AddKey(Key.E, 1069);
        AddKey(Key.F, 1070);
        AddKey(Key.G, 1071);
        AddKey(Key.H, 1072);
        AddKey(Key.I, 1073);
        AddKey(Key.J, 1074);
        AddKey(Key.K, 1075);
        AddKey(Key.L, 1076);
        AddKey(Key.M, 1077);
        AddKey(Key.N, 1078);
        AddKey(Key.O, 1079);
        AddKey(Key.P, 1080);
        AddKey(Key.Q, 1081);
        AddKey(Key.R, 1082);
        AddKey(Key.S, 1083);
        AddKey(Key.T, 1084);
        AddKey(Key.U, 1085);
        AddKey(Key.V, 1086);
        AddKey(Key.W, 1087);
        AddKey(Key.X, 1088);
        AddKey(Key.Y, 1089);
        AddKey(Key.Z, 1090);
        AddKey(Key.LeftWindows, 1091);
        AddKey(Key.RightWindows, 1092);
        //AddKey(Key.ContextMenu, 1093);
        //AddKey(Key.Sleep, 1095);
        AddKey(Key.Numpad0, 1096);
        AddKey(Key.Numpad1, 1097);
        AddKey(Key.Numpad2, 1098);
        AddKey(Key.Numpad3, 1099);
        AddKey(Key.Numpad4, 1100);
        AddKey(Key.Numpad5, 1101);
        AddKey(Key.Numpad6, 1102);
        AddKey(Key.Numpad7, 1103);
        AddKey(Key.Numpad8, 1104);
        AddKey(Key.Numpad9, 1105);
        AddKey(Key.NumpadMultiply, 1106);
        AddKey(Key.NumpadPlus, 1107);
        AddKey(Key.NumpadPeriod, 1108);
        AddKey(Key.NumpadMinus, 1109);
        AddKey(Key.NumpadPeriod, 1110);
        AddKey(Key.NumpadDivide, 1111);
        AddKey(Key.NumpadEnter, 1013);
        AddKey(Key.F1, 1112);
        AddKey(Key.F2, 1113);
        AddKey(Key.F3, 1114);
        AddKey(Key.F4, 1115);
        AddKey(Key.F5, 1116);
        AddKey(Key.F6, 1117);
        AddKey(Key.F7, 1118);
        AddKey(Key.F8, 1119);
        AddKey(Key.F9, 1120);
        AddKey(Key.F10, 1121);
        AddKey(Key.F11, 1122);
        AddKey(Key.F12, 1123);
        //AddKey(Key.F13, 1124);
        //AddKey(Key.F14, 1125);
        //AddKey(Key.F15, 1126);
        //AddKey(Key.F16, 1127);
        //AddKey(Key.F17, 1128);
        //AddKey(Key.F18, 1129);
        //AddKey(Key.F19, 1130);
        //AddKey(Key.F20, 1131);
        //AddKey(Key.F21, 1132);
        //AddKey(Key.F22, 1133);
        //AddKey(Key.F23, 1134);
        //AddKey(Key.F24, 1135);
        AddKey(Key.NumLock, 1144);
        AddKey(Key.ScrollLock, 1145);
        AddKey(Key.LeftShift, 1160);
        AddKey(Key.RightShift, 1161);
        AddKey(Key.LeftCtrl, 1162);
        AddKey(Key.RightCtrl, 1163);
        AddKey(Key.LeftAlt, 1164);
        AddKey(Key.RightAlt, 1165);
        //AddKey(Key.BrowserBack, 1166);
        //AddKey(Key.BrowserForward, 1167);
        //AddKey(Key.BrowserRefresh, 1168);
        //AddKey(Key.BrowserStop, 1169);
        //AddKey(Key.BrowserSearch, 1170);
        //AddKey(Key.BrowserFavorites, 1171);
        //AddKey(Key.BrowserHome, 1172);
        //AddKey(Key.VolumeMute, 1173);
        //AddKey(Key.VolumeDown, 1174);
        //AddKey(Key.VolumeUp, 1175);
        //AddKey(Key.MediaNextTrack, 1176);
        //AddKey(Key.MediaPreviousTrack, 1177);
        //AddKey(Key.MediaStop, 1178);
        //AddKey(Key.MediaPlayPause, 1179);
        //AddKey(Key.LaunchMail, 1180);
        //AddKey(Key.SelectMedia, 1181);
        //AddKey(Key.LaunchApplication1, 1182);
        //AddKey(Key.LaunchApplication2, 1183);

        // VALIDE
        AddKey(Key.OEM1, 1186); // 0xBA  V  




        //https://github.com/EloiStree/2024_08_29_ScratchToWarcraft/blob/main/README.md
        //https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
        // AddKey(Key.Backquote, 1222); //oem7 ???
        //VK_OEM_1    0xBA    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the ;: key
        //AddKey(Key.Semicolon, 1186);
        //AddKey(Key.RightBracket, 1186); //oem6

        ////VK_OEM_PLUS 0xBB    For any country / region, the + key
        //AddKey(Key.Slash, 1191); //oem2
        ////VK_OEM_COMMA    0xBC    For any country / region, the , key
        //AddKey(Key.Comma, 1188);
        ////VK_OEM_MINUS    0xBD    For any country / region, the - key
        //AddKey(Key.Minus, 1219);
        //AddKey(Key.Equals, 1189); 
        ////VK_OEM_PERIOD   0xBE    For any country / region, the.key
        //AddKey(Key.Period, 1190);
        ////VK_OEM_2    0xBF    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the /? key
        //AddKey(Key.OEM2, 1191);
        ////VK_OEM_3    0xC0    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the `~key
        //AddKey(Key.OEM3, 1192);
        //AddKey(Key.Quote, 1192); //oem7
        ////- 0xC1 - DA Reserved
        ////VK_OEM_4    0xDB    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the[{
        //AddKey(Key.OEM4, 1219);
        ////                    key
        ////VK_OEM_5    0xDC    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the \\| key
        //AddKey(Key.OEM5, 1220);
        //AddKey(Key.Backslash, 1220); //oem5
        ////VK_OEM_6    0xDD    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the ]}
        //AddKey(Key.LeftBracket, 1219); //oem4
        ////        key
        ////VK_OEM_7    0xDE    Used for miscellaneous characters; it can vary by keyboard.For the US standard keyboard, the '" key
        ////VK_OEM_8    0xDF    Used for miscellaneous characters; it can vary by keyboard.

        //AddKey(Key.Backslash, 1223); //oem8
        //AddKey(Key.OEM102, 1226); //oem102
        //AddKey(Key.OEM1, 1191);
        //AddKey(Key.Slash, 1190); //?
        //AddKey(Key.OemPlus, 1187);
        //AddKey(Key.Oem6, 1221);
        //AddKey(Key.Oem7, 1222);
        //AddKey(Key.Oem8, 1223);
        //AddKey(Key.Oem102, 1226);
        //AddKey(Key.ProcessKey, 1229);
        //AddKey(Key.Packet, 1231);
        //AddKey(Key.Attn, 1246);
        //AddKey(Key.CrSel, 1247);
        //AddKey(Key.ExSel, 1248);
        //AddKey(Key.EraseEof, 1249);
        //AddKey(Key.Play, 1250);
        //AddKey(Key.Zoom, 1251);
        //AddKey(Key.Pa1, 1253);



    }
}
