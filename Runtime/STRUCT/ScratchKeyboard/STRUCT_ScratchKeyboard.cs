

using System;
using JetBrains.Annotations;

/// <summary>
///https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
///https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
/// </summary>
public enum EnumScratchKeyboardWinHardware : ushort
{
    ReleaseAll = 0,
    VK_LBUTTON = 1,
    VK_RBUTTON = 2,
    VK_CANCEL = 3,
    VK_MBUTTON = 4,
    VK_XBUTTON1 = 5,
    VK_XBUTTON2 = 6,
    Undefined_7 = 7,
    VK_BACKSPACE = 8,          // Backspace
    VK_TAB = 9,

    Reserved_10 = 10,
    Reserved_11 = 11,
    VK_CLEAR = 12,
    VK_RETURN_ENTER = 13,       // Enter
    Reserved_14 = 14,
    Reserved_15 = 15,
    VK_SHIFT = 16,
    VK_CONTROL = 17,
    VK_MENU_ALT = 18,         // Alt
    VK_PAUSE = 19,

    VK_CAPITAL = 20,      // CapsLock
    VK_KANA = 21,         // IME Kana mode
    Undefined_22 = 22,
    VK_JUNJA = 23,        // IME Junja mode
    VK_FINAL = 24,        // IME final mode
    VK_KANJI = 25,        // IME Kanji mode
    Undefined_26 = 26,
    VK_ESCAPE = 27,
    VK_CONVERT = 28,      // IME convert
    VK_NONCONVERT = 29,   // IME non-convert

    VK_ACCEPT = 30,       // IME accept
    VK_MODECHANGE = 31,   // IME mode change
    VK_SPACE = 32,
    VK_PRIOR_PAGEUP = 33,        // PageUp
    VK_NEXT_PAGEDOWN = 34,         // PageDown
    VK_END = 35,
    VK_HOME = 36,
    VK_ARROW_LEFT = 37,         // ArrowLeft
    VK_ARROW_UP = 38,           // ArrowUp
    VK_ARROW_RIGHT = 39,        // ArrowRight
    VK_ARROW_DOWN = 40,         // ArrowDown
    VK_SELECT = 41,
    VK_PRINT = 42,
    VK_EXECUTE = 43,
    VK_SNAPSHOT = 44,     // PrintScreen
    VK_INSERT = 45,
    VK_DELETE = 46,
    VK_HELP = 47,
    VK_ALPHA_KEY0 = 48,            // Alpha0
    VK_ALPHA_KEY1 = 49,            // Alpha1

    VK_ALPHA_KEY2 = 50,
    VK_ALPHA_KEY3 = 51,
    VK_ALPHA_KEY4 = 52,
    VK_ALPHA_KEY5 = 53,
    VK_ALPHA_KEY6 = 54,
    VK_ALPHA_KEY7 = 55,
    VK_ALPHA_KEY8 = 56,
    VK_ALPHA_KEY9 = 57,
    Undefined_58 = 58,
    Undefined_59 = 59,

    Undefined_60 = 60,
    Undefined_61 = 61,
    Undefined_62 = 62,
    Undefined_63 = 63,
    Undefined_64 = 64,
    KeyA = 65,
    KeyB = 66,
    KeyC = 67,
    KeyD = 68,
    KeyE = 69,

    KeyF = 70,
    KeyG = 71,
    KeyH = 72,
    KeyI = 73,
    KeyJ = 74,
    KeyK = 75,
    KeyL = 76,
    KeyM = 77,
    KeyN = 78,
    KeyO = 79,

    KeyP = 80,
    KeyQ = 81,
    KeyR = 82,
    KeyS = 83,
    KeyT = 84,
    KeyU = 85,
    KeyV = 86,
    KeyW = 87,
    KeyX = 88,
    KeyY = 89,

    KeyZ = 90,
    VK_LWIN = 91,          // LeftWindows
    VK_RWIN = 92,          // RightWindows
    VK_APPS = 93,          // Applications
    Reserved_94 = 94,
    Reserved_95 = 95,
    VK_NUMPAD0 = 96,
    VK_NUMPAD1 = 97,
    VK_NUMPAD2 = 98,
    VK_NUMPAD3 = 99,

    VK_NUMPAD4 = 100,
    VK_NUMPAD5 = 101,
    VK_NUMPAD6 = 102,
    VK_NUMPAD7 = 103,
    VK_NUMPAD8 = 104,
    VK_NUMPAD9 = 105,
    VK_MULTIPLY = 106,     // NumpadMultiply
    VK_ADD = 107,          // NumpadAdd
    VK_SEPARATOR = 108,    // NumpadSeparator
    VK_SUBTRACT = 109,     // NumpadSubtract

    VK_DECIMAL = 110,      // NumpadDecimal
    VK_DIVIDE = 111,       // NumpadDivide
    VK_F1 = 112,
    VK_F2 = 113,
    VK_F3 = 114,
    VK_F4 = 115,
    VK_F5 = 116,
    VK_F6 = 117,
    VK_F7 = 118,
    VK_F8 = 119,

    VK_F9 = 120,
    VK_F10 = 121,
    VK_F11 = 122,
    VK_F12 = 123,
    VK_F13 = 124,
    VK_F14 = 125,
    VK_F15 = 126,
    VK_F16 = 127,
    VK_F17 = 128,
    VK_F18 = 129,

    VK_F19 = 130,
    VK_F20 = 131,
    VK_F21 = 132,
    VK_F22 = 133,
    VK_F23 = 134,
    VK_F24 = 135,
    Unassigned_136 = 136,
    Unassigned_137 = 137,
    Unassigned_138 = 138,
    Unassigned_139 = 139,

    Unassigned_140 = 140,
    Unassigned_141 = 141,
    Unassigned_142 = 142,
    Unassigned_143 = 143,
    VK_NUMLOCK = 144,
    VK_SCROLL = 145,       // ScrollLock
    OEM_146 = 146,
    OEM_147 = 147,
    OEM_148 = 148,
    OEM_149 = 149,

    OEM_150 = 150,
    Unassigned_151 = 151,
    Unassigned_152 = 152,
    Unassigned_153 = 153,
    Unassigned_154 = 154,
    Unassigned_155 = 155,
    Unassigned_156 = 156,
    Unassigned_157 = 157,
    Unassigned_158 = 158,
    Unassigned_159 = 159,

    VK_LSHIFT = 160,       // LeftShift
    VK_RSHIFT = 161,       // RightShift
    VK_LCONTROL = 162,     // LeftControl
    VK_RCONTROL = 163,     // RightControl
    VK_LMENU_ALT = 164,        // LeftAlt
    VK_RMENU_ALT = 165,        // RightAlt
    VK_BROWSER_BACK = 166,
    VK_BROWSER_FORWARD = 167,
    VK_BROWSER_REFRESH = 168,
    VK_BROWSER_STOP = 169,

    VK_BROWSER_SEARCH = 170,
    VK_BROWSER_FAVORITES = 171,
    VK_BROWSER_HOME = 172,
    VK_VOLUME_MUTE = 173,
    VK_VOLUME_DOWN = 174,
    VK_VOLUME_UP = 175,
    VK_MEDIA_NEXT_TRACK = 176,
    VK_MEDIA_PREV_TRACK = 177,
    VK_MEDIA_STOP = 178,
    VK_MEDIA_PLAY_PAUSE = 179,

    VK_LAUNCH_MAIL = 180,
    VK_LAUNCH_MEDIA_SELECT = 181,
    VK_LAUNCH_APP1 = 182,
    VK_LAUNCH_APP2 = 183,
    Reserved_184 = 184,
    Reserved_185 = 185,
    VK_OEM_1_COLON = 186,        // ;: for US
    VK_OEM_PLUS_EQUALS = 187,     // =+
    VK_OEM_COMMA_LESS_OPERATOR = 188,    // ,<
    VK_OEM_MINUS_DASH = 189,    // -_
    VK_OEM_PERIOD_BIGGER_OPERATOR = 190,   // .>

    VK_OEM_2 = 191,        // /? for US
    VK_OEM_3 = 192,        // `~ for US
    Reserved_193 = 193,
    Reserved_194 = 194,
    Reserved_195 = 195,
    Reserved_196 = 196,
    Reserved_197 = 197,
    Reserved_198 = 198,
    Reserved_199 = 199,

    Reserved_200 = 200,
    Reserved_201 = 201,
    Reserved_202 = 202,
    Reserved_203 = 203,
    Reserved_204 = 204,
    Reserved_205 = 205,
    Reserved_206 = 206,
    Reserved_207 = 207,
    Reserved_208 = 208,
    Reserved_209 = 209,

    Reserved_210 = 210,
    Reserved_211 = 211,
    Reserved_212 = 212,
    Reserved_213 = 213,
    Reserved_214 = 214,
    Reserved_215 = 215,
    Reserved_216 = 216,
    Reserved_217 = 217,
    Reserved_218 = 218,
    VK_OEM_4_BRACKET_LEFT = 219,        // [{ for US

    VK_OEM_5_OR_BACKSLASH = 220,        // \| for US
    VK_OEM_6_BRACKET_RIGHT = 221,        // ]} for US
    VK_OEM_7_QUOTE_MARK = 222,        // '" for US
    VK_OEM_8 = 223,
    Reserved_224 = 224,
    OEM_225 = 225,
    VK_OEM_102 = 226,      // <> or \| on RT 102-key keyboard
    OEM_227 = 227,
    OEM_228 = 228,
    VK_PROCESSKEY = 229,

    OEM_230 = 230,
    VK_PACKET = 231,
    Unassigned_232 = 232,
    OEM_233 = 233,
    OEM_234 = 234,
    OEM_235 = 235,
    OEM_236 = 236,
    OEM_237 = 237,
    OEM_238 = 238,
    OEM_239 = 239,

    OEM_240 = 240,
    OEM_241 = 241,
    OEM_242 = 242,
    OEM_243 = 243,
    OEM_244 = 244,
    OEM_245 = 245,
    VK_ATTN = 246,
    VK_CRSEL = 247,
    VK_EXSEL = 248,
    VK_EREOF = 249,

    VK_PLAY = 250,
    VK_ZOOM = 251,
    VK_NONAME = 252,
    VK_PA1 = 253,
    VK_OEM_CLEAR = 254,
    Reserved_255 = 255,
    ClearTimedCommand = 256,
}
public static class EnumScratchToWarcraftList {
    public static EnumScratchKeyboardWinHardware[] ALL_NUMPAD_0TO9 =
    {
        EnumScratchKeyboardWinHardware.VK_NUMPAD0,
        EnumScratchKeyboardWinHardware.VK_NUMPAD1,
        EnumScratchKeyboardWinHardware.VK_NUMPAD2,
        EnumScratchKeyboardWinHardware.VK_NUMPAD3,
        EnumScratchKeyboardWinHardware.VK_NUMPAD4,
        EnumScratchKeyboardWinHardware.VK_NUMPAD5,
        EnumScratchKeyboardWinHardware.VK_NUMPAD6,
        EnumScratchKeyboardWinHardware.VK_NUMPAD7,
        EnumScratchKeyboardWinHardware.VK_NUMPAD8,
        EnumScratchKeyboardWinHardware.VK_NUMPAD9
    }; 
    public static EnumScratchKeyboardWinHardware[] ALL_NUMPAD_MATH =
    {
        EnumScratchKeyboardWinHardware.VK_MULTIPLY,
        EnumScratchKeyboardWinHardware.VK_ADD,
        EnumScratchKeyboardWinHardware.VK_SEPARATOR,
        EnumScratchKeyboardWinHardware.VK_SUBTRACT,
        EnumScratchKeyboardWinHardware.VK_DECIMAL,
        EnumScratchKeyboardWinHardware.VK_DIVIDE
    };

    public static EnumScratchKeyboardWinHardware[] ALL_ALPHA_LETTERS = {
        EnumScratchKeyboardWinHardware.KeyA,
        EnumScratchKeyboardWinHardware.KeyB,
        EnumScratchKeyboardWinHardware.KeyC,
        EnumScratchKeyboardWinHardware.KeyD,
        EnumScratchKeyboardWinHardware.KeyE,
        EnumScratchKeyboardWinHardware.KeyF,
        EnumScratchKeyboardWinHardware.KeyG,
        EnumScratchKeyboardWinHardware.KeyH,
        EnumScratchKeyboardWinHardware.KeyI,
        EnumScratchKeyboardWinHardware.KeyJ,
        EnumScratchKeyboardWinHardware.KeyK,
        EnumScratchKeyboardWinHardware.KeyL,
        EnumScratchKeyboardWinHardware.KeyM,
        EnumScratchKeyboardWinHardware.KeyN,
        EnumScratchKeyboardWinHardware.KeyO,
        EnumScratchKeyboardWinHardware.KeyP,
        EnumScratchKeyboardWinHardware.KeyQ,
        EnumScratchKeyboardWinHardware.KeyR,
        EnumScratchKeyboardWinHardware.KeyS,
        EnumScratchKeyboardWinHardware.KeyT,
        EnumScratchKeyboardWinHardware.KeyU,
        EnumScratchKeyboardWinHardware.KeyV,
        EnumScratchKeyboardWinHardware.KeyW,
        EnumScratchKeyboardWinHardware.KeyX,
        EnumScratchKeyboardWinHardware.KeyY,
        EnumScratchKeyboardWinHardware.KeyZ };

    public static EnumScratchKeyboardWinHardware[] ALL_ALPHA_NUMBERS = {
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY0,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY1,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY2,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY3,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY4,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY5,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY6,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY7,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY8,
        EnumScratchKeyboardWinHardware.VK_ALPHA_KEY9 };

    public static EnumScratchKeyboardWinHardware[] ALL_CONTROLSHIFTALT = {
        EnumScratchKeyboardWinHardware.VK_SHIFT,
        EnumScratchKeyboardWinHardware.VK_LSHIFT,
        EnumScratchKeyboardWinHardware.VK_RSHIFT,
        EnumScratchKeyboardWinHardware.VK_CONTROL,
        EnumScratchKeyboardWinHardware.VK_LCONTROL,
        EnumScratchKeyboardWinHardware.VK_RCONTROL,
        EnumScratchKeyboardWinHardware.VK_MENU_ALT,
        EnumScratchKeyboardWinHardware.VK_LMENU_ALT,
        EnumScratchKeyboardWinHardware.VK_RMENU_ALT,        
    };
}

/// <summary>
///https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
///https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
/// </summary>
[System.Serializable]
public struct STRUCT_ScratchKeyboard
{
    public bool m_001_VK_LBUTTON;
    public bool m_002_VK_RBUTTON;
    public bool m_003_VK_CANCEL;
    public bool m_004_VK_MBUTTON;
    public bool m_005_VK_XBUTTON1;
    public bool m_006_VK_XBUTTON2;
    public bool m_007_Undefined;
    public bool m_008_VK_BACK;          // Backspace
    public bool m_009_VK_TAB;

    public bool m_010_Reserved;
    public bool m_011_Reserved;
    public bool m_012_VK_CLEAR;
    public bool m_013_VK_RETURN;        // Enter
    public bool m_014_Reserved;
    public bool m_015_Reserved;
    public bool m_016_VK_SHIFT;
    public bool m_017_VK_CONTROL;
    public bool m_018_VK_MENU;          // Alt
    public bool m_019_VK_PAUSE;

    public bool m_020_VK_CAPITAL;       // CapsLock
    public bool m_021_VK_KANA;          // IME Kana mode
    public bool m_022_Undefined;
    public bool m_023_VK_JUNJA;         // IME Junja mode
    public bool m_024_VK_FINAL;         // IME final mode
    public bool m_025_VK_KANJI;         // IME Kanji mode
    public bool m_026_Undefined;
    public bool m_027_VK_ESCAPE;
    public bool m_028_VK_CONVERT;       // IME convert
    public bool m_029_VK_NONCONVERT;    // IME non-convert

    public bool m_030_VK_ACCEPT;        // IME accept
    public bool m_031_VK_MODECHANGE;    // IME mode change
    public bool m_032_VK_SPACE;
    public bool m_033_VK_PRIOR;         // PageUp
    public bool m_034_VK_NEXT;          // PageDown
    public bool m_035_VK_END;
    public bool m_036_VK_HOME;
    public bool m_037_VK_LEFT;          // ArrowLeft
    public bool m_038_VK_UP;            // ArrowUp
    public bool m_039_VK_RIGHT;         // ArrowRight

    public bool m_040_VK_DOWN;          // ArrowDown
    public bool m_041_VK_SELECT;
    public bool m_042_VK_PRINT;
    public bool m_043_VK_EXECUTE;
    public bool m_044_VK_SNAPSHOT;      // PrintScreen
    public bool m_045_VK_INSERT;
    public bool m_046_VK_DELETE;
    public bool m_047_VK_HELP;
    public bool m_048_0;                // Alpha0
    public bool m_049_1;                // Alpha1

    public bool m_050_2;
    public bool m_051_3;
    public bool m_052_4;
    public bool m_053_5;
    public bool m_054_6;
    public bool m_055_7;
    public bool m_056_8;
    public bool m_057_9;
    public bool m_058_Undefined;
    public bool m_059_Undefined;

    public bool m_060_Undefined;
    public bool m_061_Undefined;
    public bool m_062_Undefined;
    public bool m_063_Undefined;
    public bool m_064_Undefined;
    public bool m_065_A;
    public bool m_066_B;
    public bool m_067_C;
    public bool m_068_D;
    public bool m_069_E;

    public bool m_070_F;
    public bool m_071_G;
    public bool m_072_H;
    public bool m_073_I;
    public bool m_074_J;
    public bool m_075_K;
    public bool m_076_L;
    public bool m_077_M;
    public bool m_078_N;
    public bool m_079_O;

    public bool m_080_P;
    public bool m_081_Q;
    public bool m_082_R;
    public bool m_083_S;
    public bool m_084_T;
    public bool m_085_U;
    public bool m_086_V;
    public bool m_087_W;
    public bool m_088_X;
    public bool m_089_Y;

    public bool m_090_Z;
    public bool m_091_VK_LWIN;          // LeftWindows
    public bool m_092_VK_RWIN;          // RightWindows
    public bool m_093_VK_APPS;          // Applications
    public bool m_094_Reserved;
    public bool m_095_Reserved;
    public bool m_096_VK_NUMPAD0;
    public bool m_097_VK_NUMPAD1;
    public bool m_098_VK_NUMPAD2;
    public bool m_099_VK_NUMPAD3;

    public bool m_100_VK_NUMPAD4;
    public bool m_101_VK_NUMPAD5;
    public bool m_102_VK_NUMPAD6;
    public bool m_103_VK_NUMPAD7;
    public bool m_104_VK_NUMPAD8;
    public bool m_105_VK_NUMPAD9;
    public bool m_106_VK_MULTIPLY;      // NumpadMultiply
    public bool m_107_VK_ADD;           // NumpadAdd
    public bool m_108_VK_SEPARATOR;     // NumpadSeparator
    public bool m_109_VK_SUBTRACT;      // NumpadSubtract

    public bool m_110_VK_DECIMAL;       // NumpadDecimal
    public bool m_111_VK_DIVIDE;        // NumpadDivide
    public bool m_112_VK_F1;
    public bool m_113_VK_F2;
    public bool m_114_VK_F3;
    public bool m_115_VK_F4;
    public bool m_116_VK_F5;
    public bool m_117_VK_F6;
    public bool m_118_VK_F7;
    public bool m_119_VK_F8;

    public bool m_120_VK_F9;
    public bool m_121_VK_F10;
    public bool m_122_VK_F11;
    public bool m_123_VK_F12;
    public bool m_124_VK_F13;
    public bool m_125_VK_F14;
    public bool m_126_VK_F15;
    public bool m_127_VK_F16;
    public bool m_128_VK_F17;
    public bool m_129_VK_F18;

    public bool m_130_VK_F19;
    public bool m_131_VK_F20;
    public bool m_132_VK_F21;
    public bool m_133_VK_F22;
    public bool m_134_VK_F23;
    public bool m_135_VK_F24;
    public bool m_136_Unassigned;
    public bool m_137_Unassigned;
    public bool m_138_Unassigned;
    public bool m_139_Unassigned;

    public bool m_140_Unassigned;
    public bool m_141_Unassigned;
    public bool m_142_Unassigned;
    public bool m_143_Unassigned;
    public bool m_144_VK_NUMLOCK;
    public bool m_145_VK_SCROLL;        // ScrollLock
    public bool m_146_OEM_1;
    public bool m_147_OEM_2;
    public bool m_148_OEM_3;
    public bool m_149_OEM_4;

    public bool m_150_OEM_5;
    public bool m_151_Unassigned;
    public bool m_152_Unassigned;
    public bool m_153_Unassigned;
    public bool m_154_Unassigned;
    public bool m_155_Unassigned;
    public bool m_156_Unassigned;
    public bool m_157_Unassigned;
    public bool m_158_Unassigned;
    public bool m_159_Unassigned;

    public bool m_160_VK_LSHIFT;        // LeftShift
    public bool m_161_VK_RSHIFT;        // RightShift
    public bool m_162_VK_LCONTROL;      // LeftControl
    public bool m_163_VK_RCONTROL;      // RightControl
    public bool m_164_VK_LMENU;         // LeftAlt
    public bool m_165_VK_RMENU;         // RightAlt
    public bool m_166_VK_BROWSER_BACK;
    public bool m_167_VK_BROWSER_FORWARD;
    public bool m_168_VK_BROWSER_REFRESH;
    public bool m_169_VK_BROWSER_STOP;

    public bool m_170_VK_BROWSER_SEARCH;
    public bool m_171_VK_BROWSER_FAVORITES;
    public bool m_172_VK_BROWSER_HOME;
    public bool m_173_VK_VOLUME_MUTE;
    public bool m_174_VK_VOLUME_DOWN;
    public bool m_175_VK_VOLUME_UP;
    public bool m_176_VK_MEDIA_NEXT_TRACK;
    public bool m_177_VK_MEDIA_PREV_TRACK;
    public bool m_178_VK_MEDIA_STOP;
    public bool m_179_VK_MEDIA_PLAY_PAUSE;

    public bool m_180_VK_LAUNCH_MAIL;
    public bool m_181_VK_LAUNCH_MEDIA_SELECT;
    public bool m_182_VK_LAUNCH_APP1;
    public bool m_183_VK_LAUNCH_APP2;
    public bool m_184_Reserved;
    public bool m_185_Reserved;
    public bool m_186_VK_OEM_1;         // ;: for US
    public bool m_187_VK_OEM_PLUS;      // =+
    public bool m_188_VK_OEM_COMMA;     // ,<
    public bool m_189_VK_OEM_MINUS;     // -_
    public bool m_190_VK_OEM_PERIOD;    // .>

    public bool m_191_VK_OEM_2;         // /? for US
    public bool m_192_VK_OEM_3;         // `~ for US
    public bool m_193_Reserved;
    public bool m_194_Reserved;
    public bool m_195_Reserved;
    public bool m_196_Reserved;
    public bool m_197_Reserved;
    public bool m_198_Reserved;
    public bool m_199_Reserved;

    public bool m_200_Reserved;
    public bool m_201_Reserved;
    public bool m_202_Reserved;
    public bool m_203_Reserved;
    public bool m_204_Reserved;
    public bool m_205_Reserved;
    public bool m_206_Reserved;
    public bool m_207_Reserved;
    public bool m_208_Reserved;
    public bool m_209_Reserved;

    public bool m_210_Reserved;
    public bool m_211_Reserved;
    public bool m_212_Reserved;
    public bool m_213_Reserved;
    public bool m_214_Reserved;
    public bool m_215_Reserved;
    public bool m_216_Reserved;
    public bool m_217_Reserved;
    public bool m_218_Reserved;
    public bool m_219_VK_OEM_4;         // [{ for US

    public bool m_220_VK_OEM_5;         // \| for US
    public bool m_221_VK_OEM_6;         // ]} for US
    public bool m_222_VK_OEM_7;         // '" for US
    public bool m_223_VK_OEM_8;
    public bool m_224_Reserved;
    public bool m_225_OEM_9;
    public bool m_226_VK_OEM_102;       // <> or \| on RT 102-key keyboard
    public bool m_227_OEM_10;
    public bool m_228_OEM_11;
    public bool m_229_VK_PROCESSKEY;

    public bool m_230_OEM_12;
    public bool m_231_VK_PACKET;
    public bool m_232_Unassigned;
    public bool m_233_OEM_13;
    public bool m_234_OEM_14;
    public bool m_235_OEM_15;
    public bool m_236_OEM_16;
    public bool m_237_OEM_17;
    public bool m_238_OEM_18;
    public bool m_239_OEM_19;

    public bool m_240_OEM_20;
    public bool m_241_OEM_21;
    public bool m_242_OEM_22;
    public bool m_243_OEM_23;
    public bool m_244_OEM_24;
    public bool m_245_OEM_25;
    public bool m_246_VK_ATTN;
    public bool m_247_VK_CRSEL;
    public bool m_248_VK_EXSEL;
    public bool m_249_VK_EREOF;

    public bool m_250_VK_PLAY;
    public bool m_251_VK_ZOOM;
    public bool m_252_VK_NONAME;
    public bool m_253_VK_PA1;
    public bool m_254_VK_OEM_CLEAR;
    public bool m_255_Reserved;


    public void SetKey(EnumScratchKeyboardWinHardware key, bool value)
    {
       
        int enumValue = (int)key;
        SetKey(enumValue, value);

    }


    public void SetKey(int key, bool value)
    {
        if (key < 0 || key > 255)
            return;
        switch (key)
        {
            case 1: m_001_VK_LBUTTON = value; break;
            case 2: m_002_VK_RBUTTON = value; break;
            case 3: m_003_VK_CANCEL = value; break;
            case 4: m_004_VK_MBUTTON = value; break;
            case 5: m_005_VK_XBUTTON1 = value; break;
            case 6: m_006_VK_XBUTTON2 = value; break;
            case 7: m_007_Undefined = value; break;
            case 8: m_008_VK_BACK = value; break;
            case 9: m_009_VK_TAB = value; break;
            case 10: m_010_Reserved = value; break;
            case 11: m_011_Reserved = value; break;
            case 12: m_012_VK_CLEAR = value; break;
            case 13: m_013_VK_RETURN = value; break;
            case 14: m_014_Reserved = value; break;
            case 15: m_015_Reserved = value; break;
            case 16: m_016_VK_SHIFT = value; break;
            case 17: m_017_VK_CONTROL = value; break;
            case 18: m_018_VK_MENU = value; break;
            case 19: m_019_VK_PAUSE = value; break;
            case 20: m_020_VK_CAPITAL = value; break;
            case 21: m_021_VK_KANA = value; break;
            case 22: m_022_Undefined = value; break;
            case 23: m_023_VK_JUNJA = value; break;
            case 24: m_024_VK_FINAL = value; break;
            case 25: m_025_VK_KANJI = value; break;
            case 26: m_026_Undefined = value; break;
            case 27: m_027_VK_ESCAPE = value; break;
            case 28: m_028_VK_CONVERT = value; break;
            case 29: m_029_VK_NONCONVERT = value; break;
            case 30: m_030_VK_ACCEPT = value; break;
            case 31: m_031_VK_MODECHANGE = value; break;
            case 32: m_032_VK_SPACE = value; break;
            case 33: m_033_VK_PRIOR = value; break;
            case 34: m_034_VK_NEXT = value; break;
            case 35: m_035_VK_END = value; break;
            case 36: m_036_VK_HOME = value; break;
            case 37: m_037_VK_LEFT = value; break;
            case 38: m_038_VK_UP = value; break;
            case 39: m_039_VK_RIGHT = value; break;
            case 40: m_040_VK_DOWN = value; break;
            case 41: m_041_VK_SELECT = value; break;
            case 42: m_042_VK_PRINT = value; break;
            case 43: m_043_VK_EXECUTE = value; break;
            case 44: m_044_VK_SNAPSHOT = value; break;
            case 45: m_045_VK_INSERT = value; break;
            case 46: m_046_VK_DELETE = value; break;
            case 47: m_047_VK_HELP = value; break;
            case 48: m_048_0 = value; break;
            case 49: m_049_1 = value; break;
            case 50: m_050_2 = value; break;
            case 51: m_051_3 = value; break;
            case 52: m_052_4 = value; break;
            case 53: m_053_5 = value; break;
            case 54: m_054_6 = value; break;
            case 55: m_055_7 = value; break;
            case 56: m_056_8 = value; break;
            case 57: m_057_9 = value; break;
            case 58: m_058_Undefined = value; break;
            case 59: m_059_Undefined = value; break;
            case 60: m_060_Undefined = value; break;
            case 61: m_061_Undefined = value; break;
            case 62: m_062_Undefined = value; break;
            case 63: m_063_Undefined = value; break;
            case 64: m_064_Undefined = value; break;
            case 65: m_065_A = value; break;
            case 66: m_066_B = value; break;
            case 67: m_067_C = value; break;
            case 68: m_068_D = value; break;
            case 69: m_069_E = value; break;
            case 70: m_070_F = value; break;
            case 71: m_071_G = value; break;
            case 72: m_072_H = value; break;
            case 73: m_073_I = value; break;
            case 74: m_074_J = value; break;
            case 75: m_075_K = value; break;
            case 76: m_076_L = value; break;
            case 77: m_077_M = value; break;
            case 78: m_078_N = value; break;
            case 79: m_079_O = value; break;
            case 80: m_080_P = value; break;
            case 81: m_081_Q = value; break;
            case 82: m_082_R = value; break;
            case 83: m_083_S = value; break;
            case 84: m_084_T = value; break;
            case 85: m_085_U = value; break;
            case 86: m_086_V = value; break;
            case 87: m_087_W = value; break;
            case 88: m_088_X = value; break;
            case 89: m_089_Y = value; break;
            case 90: m_090_Z = value; break;
            case 91: m_091_VK_LWIN = value; break;
            case 92: m_092_VK_RWIN = value; break;
            case 93: m_093_VK_APPS = value; break;
            case 94: m_094_Reserved = value; break;
            case 95: m_095_Reserved = value; break;
            case 96: m_096_VK_NUMPAD0 = value; break;
            case 97: m_097_VK_NUMPAD1 = value; break;
            case 98: m_098_VK_NUMPAD2 = value; break;
            case 99: m_099_VK_NUMPAD3 = value; break;
            case 100: m_100_VK_NUMPAD4 = value; break;
            case 101: m_101_VK_NUMPAD5 = value; break;
            case 102: m_102_VK_NUMPAD6 = value; break;
            case 103: m_103_VK_NUMPAD7 = value; break;
            case 104: m_104_VK_NUMPAD8 = value; break;
            case 105: m_105_VK_NUMPAD9 = value; break;
            case 106: m_106_VK_MULTIPLY = value; break;
            case 107: m_107_VK_ADD = value; break;
            case 108: m_108_VK_SEPARATOR = value; break;
            case 109: m_109_VK_SUBTRACT = value; break;
            case 110: m_110_VK_DECIMAL = value; break;
            case 111: m_111_VK_DIVIDE = value; break;
            case 112: m_112_VK_F1 = value; break;
            case 113: m_113_VK_F2 = value; break;
            case 114: m_114_VK_F3 = value; break;
            case 115: m_115_VK_F4 = value; break;
            case 116: m_116_VK_F5 = value; break;
            case 117: m_117_VK_F6 = value; break;
            case 118: m_118_VK_F7 = value; break;
            case 119: m_119_VK_F8 = value; break;
            case 120: m_120_VK_F9 = value; break;
            case 121: m_121_VK_F10 = value; break;
            case 122: m_122_VK_F11 = value; break;
            case 123: m_123_VK_F12 = value; break;
            case 124: m_124_VK_F13 = value; break;
            case 125: m_125_VK_F14 = value; break;
            case 126: m_126_VK_F15 = value; break;
            case 127: m_127_VK_F16 = value; break;
            case 128: m_128_VK_F17 = value; break;
            case 129: m_129_VK_F18 = value; break;
            case 130: m_130_VK_F19 = value; break;
            case 131: m_131_VK_F20 = value; break;
            case 132: m_132_VK_F21 = value; break;
            case 133: m_133_VK_F22 = value; break;
            case 134: m_134_VK_F23 = value; break;
            case 135: m_135_VK_F24 = value; break;
            case 136: m_136_Unassigned = value; break;
            case 137: m_137_Unassigned = value; break;
            case 138: m_138_Unassigned = value; break;
            case 139: m_139_Unassigned = value; break;
            case 140: m_140_Unassigned = value; break;
            case 141: m_141_Unassigned = value; break;
            case 142: m_142_Unassigned = value; break;
            case 143: m_143_Unassigned = value; break;
            case 144: m_144_VK_NUMLOCK = value; break;
            case 145: m_145_VK_SCROLL = value; break;
            case 146: m_146_OEM_1 = value; break;
            case 147: m_147_OEM_2 = value; break;
            case 148: m_148_OEM_3 = value; break;
            case 149: m_149_OEM_4 = value; break;
            case 150: m_150_OEM_5 = value; break;
            case 151: m_151_Unassigned = value; break;
            case 152: m_152_Unassigned = value; break;
            case 153: m_153_Unassigned = value; break;
            case 154: m_154_Unassigned = value; break;
            case 155: m_155_Unassigned = value; break;
            case 156: m_156_Unassigned = value; break;
            case 157: m_157_Unassigned = value; break;
            case 158: m_158_Unassigned = value; break;
            case 159: m_159_Unassigned = value; break;
            case 160: m_160_VK_LSHIFT = value; break;
            case 161: m_161_VK_RSHIFT = value; break;
            case 162: m_162_VK_LCONTROL = value; break;
            case 163: m_163_VK_RCONTROL = value; break;
            case 164: m_164_VK_LMENU = value; break;
            case 165: m_165_VK_RMENU = value; break;
            case 166: m_166_VK_BROWSER_BACK = value; break;
            case 167: m_167_VK_BROWSER_FORWARD = value; break;
            case 168: m_168_VK_BROWSER_REFRESH = value; break;
            case 169: m_169_VK_BROWSER_STOP = value; break;
            case 170: m_170_VK_BROWSER_SEARCH = value; break;
            case 171: m_171_VK_BROWSER_FAVORITES = value; break;
            case 172: m_172_VK_BROWSER_HOME = value; break;
            case 173: m_173_VK_VOLUME_MUTE = value; break;
            case 174: m_174_VK_VOLUME_DOWN = value; break;
            case 175: m_175_VK_VOLUME_UP = value; break;
            case 176: m_176_VK_MEDIA_NEXT_TRACK = value; break;
            case 177: m_177_VK_MEDIA_PREV_TRACK = value; break;
            case 178: m_178_VK_MEDIA_STOP = value; break;
            case 179: m_179_VK_MEDIA_PLAY_PAUSE = value; break;
            case 180: m_180_VK_LAUNCH_MAIL = value; break;
            case 181: m_181_VK_LAUNCH_MEDIA_SELECT = value; break;
            case 182: m_182_VK_LAUNCH_APP1 = value; break;
            case 183: m_183_VK_LAUNCH_APP2 = value; break;
            case 184: m_184_Reserved = value; break;
            case 185: m_185_Reserved = value; break;
            case 186: m_186_VK_OEM_1 = value; break;
            case 187: m_187_VK_OEM_PLUS = value; break;
            case 188: m_188_VK_OEM_COMMA = value; break;
            case 189: m_189_VK_OEM_MINUS = value; break;
            case 190: m_190_VK_OEM_PERIOD = value; break;
            case 191: m_191_VK_OEM_2 = value; break;
            case 192: m_192_VK_OEM_3 = value; break;
            case 193: m_193_Reserved = value; break;
            case 194: m_194_Reserved = value; break;
            case 195: m_195_Reserved = value; break;
            case 196: m_196_Reserved = value; break;
            case 197: m_197_Reserved = value; break;
            case 198: m_198_Reserved = value; break;
            case 199: m_199_Reserved = value; break;
            case 200: m_200_Reserved = value; break;
            case 201: m_201_Reserved = value; break;
            case 202: m_202_Reserved = value; break;
            case 203: m_203_Reserved = value; break;
            case 204: m_204_Reserved = value; break;
            case 205: m_205_Reserved = value; break;
            case 206: m_206_Reserved = value; break;
            case 207: m_207_Reserved = value; break;
            case 208: m_208_Reserved = value; break;
            case 209: m_209_Reserved = value; break;
            case 210: m_210_Reserved = value; break;
            case 211: m_211_Reserved = value; break;
            case 212: m_212_Reserved = value; break;
            case 213: m_213_Reserved = value; break;
            case 214: m_214_Reserved = value; break;
            case 215: m_215_Reserved = value; break;
            case 216: m_216_Reserved = value; break;
            case 217: m_217_Reserved = value; break;
            case 218: m_218_Reserved = value; break;
            case 219: m_219_VK_OEM_4 = value; break;
            case 220: m_220_VK_OEM_5 = value; break;
            case 221: m_221_VK_OEM_6 = value; break;
            case 222: m_222_VK_OEM_7 = value; break;
            case 223: m_223_VK_OEM_8 = value; break;
            case 224: m_224_Reserved = value; break;
            case 225: m_225_OEM_9 = value; break;
            case 226: m_226_VK_OEM_102 = value; break;
            case 227: m_227_OEM_10 = value; break;
            case 228: m_228_OEM_11 = value; break;
            case 229: m_229_VK_PROCESSKEY = value; break;
            case 230: m_230_OEM_12 = value; break;
            case 231: m_231_VK_PACKET = value; break;
            case 232: m_232_Unassigned = value; break;
            case 233: m_233_OEM_13 = value; break;
            case 234: m_234_OEM_14 = value; break;
            case 235: m_235_OEM_15 = value; break;
            case 236: m_236_OEM_16 = value; break;
            case 237: m_237_OEM_17 = value; break;
            case 238: m_238_OEM_18 = value; break;
            case 239: m_239_OEM_19 = value; break;
            case 240: m_240_OEM_20 = value; break;
            case 241: m_241_OEM_21 = value; break;
            case 242: m_242_OEM_22 = value; break;
            case 243: m_243_OEM_23 = value; break;
            case 244: m_244_OEM_24 = value; break;
            case 245: m_245_OEM_25 = value; break;
            case 246: m_246_VK_ATTN = value; break;
            case 247: m_247_VK_CRSEL = value; break;
            case 248: m_248_VK_EXSEL = value; break;
            case 249: m_249_VK_EREOF = value; break;
            case 250: m_250_VK_PLAY = value; break;
            case 251: m_251_VK_ZOOM = value; break;
            case 252: m_252_VK_NONAME = value; break;
            case 253: m_253_VK_PA1 = value; break;
            case 254: m_254_VK_OEM_CLEAR = value; break;
        }
    }


    public void GetKey(EnumScratchKeyboardWinHardware key, out bool value)
    {
        int enumValue = (int)key;
        GetKey(enumValue, out value);
    }

    public void GetKey(int key, out bool value)
    {
        if (key < 0 || key > 255)
        {
            value = false;
            return;
        }
        switch (key)
        {
            case 1: value = m_001_VK_LBUTTON; break;
            case 2: value = m_002_VK_RBUTTON; break;
            case 3: value = m_003_VK_CANCEL; break;
            case 4: value = m_004_VK_MBUTTON; break;
            case 5: value = m_005_VK_XBUTTON1; break;
            case 6: value = m_006_VK_XBUTTON2; break;
            case 7: value = m_007_Undefined; break;
            case 8: value = m_008_VK_BACK; break;
            case 9: value = m_009_VK_TAB; break;
            case 10: value = m_010_Reserved; break;
            case 11: value = m_011_Reserved; break;
            case 12: value = m_012_VK_CLEAR; break;
            case 13: value = m_013_VK_RETURN; break;
            case 14: value = m_014_Reserved; break;
            case 15: value = m_015_Reserved; break;
            case 16: value = m_016_VK_SHIFT; break;
            case 17: value = m_017_VK_CONTROL; break;
            case 18: value = m_018_VK_MENU; break;
            case 19: value = m_019_VK_PAUSE; break;
            case 20: value = m_020_VK_CAPITAL; break;
            case 21: value = m_021_VK_KANA; break;
            case 22: value = m_022_Undefined; break;
            case 23: value = m_023_VK_JUNJA; break;
            case 24: value = m_024_VK_FINAL; break;
            case 25: value = m_025_VK_KANJI; break;
            case 26: value = m_026_Undefined; break;
            case 27: value = m_027_VK_ESCAPE; break;
            case 28: value = m_028_VK_CONVERT; break;
            case 29: value = m_029_VK_NONCONVERT; break;
            case 30: value = m_030_VK_ACCEPT; break;
            case 31: value = m_031_VK_MODECHANGE; break;
            case 32: value = m_032_VK_SPACE; break;
            case 33: value = m_033_VK_PRIOR; break;
            case 34: value = m_034_VK_NEXT; break;
            case 35: value = m_035_VK_END; break;
            case 36: value = m_036_VK_HOME; break;
            case 37: value = m_037_VK_LEFT; break;
            case 38: value = m_038_VK_UP; break;
            case 39: value = m_039_VK_RIGHT; break;
            case 40: value = m_040_VK_DOWN; break;
            case 41: value = m_041_VK_SELECT; break;
            case 42: value = m_042_VK_PRINT; break;
            case 43: value = m_043_VK_EXECUTE; break;
            case 44: value = m_044_VK_SNAPSHOT; break;
            case 45: value = m_045_VK_INSERT; break;
            case 46: value = m_046_VK_DELETE; break;
            case 47: value = m_047_VK_HELP; break;
            case 48: value = m_048_0; break;
            case 49: value = m_049_1; break;
            case 50: value = m_050_2; break;
            case 51: value = m_051_3; break;
            case 52: value = m_052_4; break;
            case 53: value = m_053_5; break;
            case 54: value = m_054_6; break;
            case 55: value = m_055_7; break;
            case 56: value = m_056_8; break;
            case 57: value = m_057_9; break;
            case 58: value = m_058_Undefined; break;
            case 59: value = m_059_Undefined; break;
            case 60: value = m_060_Undefined; break;
            case 61: value = m_061_Undefined; break;
            case 62: value = m_062_Undefined; break;
            case 63: value = m_063_Undefined; break;
            case 64: value = m_064_Undefined; break;
            case 65: value = m_065_A; break;
            case 66: value = m_066_B; break;
            case 67: value = m_067_C; break;
            case 68: value = m_068_D; break;
            case 69: value = m_069_E; break;
            case 70: value = m_070_F; break;
            case 71: value = m_071_G; break;
            case 72: value = m_072_H; break;
            case 73: value = m_073_I; break;
            case 74: value = m_074_J; break;
            case 75: value = m_075_K; break;
            case 76: value = m_076_L; break;
            case 77: value = m_077_M; break;
            case 78: value = m_078_N; break;
            case 79: value = m_079_O; break;
            case 80: value = m_080_P; break;
            case 81: value = m_081_Q; break;
            case 82: value = m_082_R; break;
            case 83: value = m_083_S; break;
            case 84: value = m_084_T; break;
            case 85: value = m_085_U; break;
            case 86: value = m_086_V; break;
            case 87: value = m_087_W; break;
            case 88: value = m_088_X; break;
            case 89: value = m_089_Y; break;
            case 90: value = m_090_Z; break;
            case 91: value = m_091_VK_LWIN; break;
            case 92: value = m_092_VK_RWIN; break;
            case 93: value = m_093_VK_APPS; break;
            case 94: value = m_094_Reserved; break;
            case 95: value = m_095_Reserved; break;
            case 96: value = m_096_VK_NUMPAD0; break;
            case 97: value = m_097_VK_NUMPAD1; break;
            case 98: value = m_098_VK_NUMPAD2; break;
            case 99: value = m_099_VK_NUMPAD3; break;
            case 100: value = m_100_VK_NUMPAD4; break;
            case 101: value = m_101_VK_NUMPAD5; break;
            case 102: value = m_102_VK_NUMPAD6; break;
            case 103: value = m_103_VK_NUMPAD7; break;
            case 104: value = m_104_VK_NUMPAD8; break;
            case 105: value = m_105_VK_NUMPAD9; break;
            case 106: value = m_106_VK_MULTIPLY; break;
            case 107: value = m_107_VK_ADD; break;
            case 108: value = m_108_VK_SEPARATOR; break;
            case 109: value = m_109_VK_SUBTRACT; break;
            case 110: value = m_110_VK_DECIMAL; break;
            case 111: value = m_111_VK_DIVIDE; break;
            case 112: value = m_112_VK_F1; break;
            case 113: value = m_113_VK_F2; break;
            case 114: value = m_114_VK_F3; break;
            case 115: value = m_115_VK_F4; break;
            case 116: value = m_116_VK_F5; break;
            case 117: value = m_117_VK_F6; break;
            case 118: value = m_118_VK_F7; break;
            case 119: value = m_119_VK_F8; break;
            case 120: value = m_120_VK_F9; break;
            case 121: value = m_121_VK_F10; break;
            case 122: value = m_122_VK_F11; break;
            case 123: value = m_123_VK_F12; break;
            case 124: value = m_124_VK_F13; break;
            case 125: value = m_125_VK_F14; break;
            case 126: value = m_126_VK_F15; break;
            case 127: value = m_127_VK_F16; break;
            case 128: value = m_128_VK_F17; break;
            case 129: value = m_129_VK_F18; break;
            case 130: value = m_130_VK_F19; break;
            case 131: value = m_131_VK_F20; break;
            case 132: value = m_132_VK_F21; break;
            case 133: value = m_133_VK_F22; break;
            case 134: value = m_134_VK_F23; break;
            case 135: value = m_135_VK_F24; break;
            case 136: value = m_136_Unassigned; break;
            case 137: value = m_137_Unassigned; break;
            case 138: value = m_138_Unassigned; break;
            case 139: value = m_139_Unassigned; break;
            case 140: value = m_140_Unassigned; break;
            case 141: value = m_141_Unassigned; break;
            case 142: value = m_142_Unassigned; break;
            case 143: value = m_143_Unassigned; break;
            case 144: value = m_144_VK_NUMLOCK; break;
            case 145: value = m_145_VK_SCROLL; break;
            case 146: value = m_146_OEM_1; break;
            case 147: value = m_147_OEM_2; break;
            case 148: value = m_148_OEM_3; break;
            case 149: value = m_149_OEM_4; break;
            case 150: value = m_150_OEM_5; break;
            case 151: value = m_151_Unassigned; break;
            case 152: value = m_152_Unassigned; break;
            case 153: value = m_153_Unassigned; break;
            case 154: value = m_154_Unassigned; break;
            case 155: value = m_155_Unassigned; break;
            case 156: value = m_156_Unassigned; break;
            case 157: value = m_157_Unassigned; break;
            case 158: value = m_158_Unassigned; break;
            case 159: value = m_159_Unassigned; break;
            case 160: value = m_160_VK_LSHIFT; break;
            case 161: value = m_161_VK_RSHIFT; break;
            case 162: value = m_162_VK_LCONTROL; break;
            case 163: value = m_163_VK_RCONTROL; break;
            case 164: value = m_164_VK_LMENU; break;
            case 165: value = m_165_VK_RMENU; break;
            case 166: value = m_166_VK_BROWSER_BACK; break;
            case 167: value = m_167_VK_BROWSER_FORWARD; break;
            case 168: value = m_168_VK_BROWSER_REFRESH; break;
            case 169: value = m_169_VK_BROWSER_STOP; break;
            case 170: value = m_170_VK_BROWSER_SEARCH; break;
            case 171: value = m_171_VK_BROWSER_FAVORITES; break;
            case 172: value = m_172_VK_BROWSER_HOME; break;
            case 173: value = m_173_VK_VOLUME_MUTE; break;
            case 174: value = m_174_VK_VOLUME_DOWN; break;
            case 175: value = m_175_VK_VOLUME_UP; break;
            case 176: value = m_176_VK_MEDIA_NEXT_TRACK; break;
            case 177: value = m_177_VK_MEDIA_PREV_TRACK; break;
            case 178: value = m_178_VK_MEDIA_STOP; break;
            case 179: value = m_179_VK_MEDIA_PLAY_PAUSE; break;
            case 180: value = m_180_VK_LAUNCH_MAIL; break;
            case 181: value = m_181_VK_LAUNCH_MEDIA_SELECT; break;
            case 182: value = m_182_VK_LAUNCH_APP1; break;
            case 183: value = m_183_VK_LAUNCH_APP2; break;
            case 184: value = m_184_Reserved; break;
            case 185: value = m_185_Reserved; break;
            case 186: value = m_186_VK_OEM_1; break;
            case 187: value = m_187_VK_OEM_PLUS; break;
            case 188: value = m_188_VK_OEM_COMMA; break;
            case 189: value = m_189_VK_OEM_MINUS; break;
            case 190: value = m_190_VK_OEM_PERIOD; break;
            case 191: value = m_191_VK_OEM_2; break;
            case 192: value = m_192_VK_OEM_3; break;
            case 193: value = m_193_Reserved; break;
            case 194: value = m_194_Reserved; break;
            case 195: value = m_195_Reserved; break;
            case 196: value = m_196_Reserved; break;
            case 197: value = m_197_Reserved; break;
            case 198: value = m_198_Reserved; break;
            case 199: value = m_199_Reserved; break;
            case 200: value = m_200_Reserved; break;
            case 201: value = m_201_Reserved; break;
            case 202: value = m_202_Reserved; break;
            case 203: value = m_203_Reserved; break;
            case 204: value = m_204_Reserved; break;
            case 205: value = m_205_Reserved; break;
            case 206: value = m_206_Reserved; break;
            case 207: value = m_207_Reserved; break;
            case 208: value = m_208_Reserved; break;
            case 209: value = m_209_Reserved; break;
            case 210: value = m_210_Reserved; break;
            case 211: value = m_211_Reserved; break;
            case 212: value = m_212_Reserved; break;
            case 213: value = m_213_Reserved; break;
            case 214: value = m_214_Reserved; break;
            case 215: value = m_215_Reserved; break;
            case 216: value = m_216_Reserved; break;
            case 217: value = m_217_Reserved; break;
            case 218: value = m_218_Reserved; break;
            case 219: value = m_219_VK_OEM_4; break;
            case 220: value = m_220_VK_OEM_5; break;
            case 221: value = m_221_VK_OEM_6; break;
            case 222: value = m_222_VK_OEM_7; break;
            case 223: value = m_223_VK_OEM_8; break;
            case 224: value = m_224_Reserved; break;
            case 225: value = m_225_OEM_9; break;
            case 226: value = m_226_VK_OEM_102; break;
            case 227: value = m_227_OEM_10; break;
            case 228: value = m_228_OEM_11; break;
            case 229: value = m_229_VK_PROCESSKEY; break;
            case 230: value = m_230_OEM_12; break;
            case 231: value = m_231_VK_PACKET; break;
            case 232: value = m_232_Unassigned; break;
            case 233: value = m_233_OEM_13; break;
            case 234: value = m_234_OEM_14; break;
            case 235: value = m_235_OEM_15; break;
            case 236: value = m_236_OEM_16; break;
            case 237: value = m_237_OEM_17; break;
            case 238: value = m_238_OEM_18; break;
            case 239: value = m_239_OEM_19; break;
            case 240: value = m_240_OEM_20; break;
            case 241: value = m_241_OEM_21; break;
            case 242: value = m_242_OEM_22; break;
            case 243: value = m_243_OEM_23; break;
            case 244: value = m_244_OEM_24; break;
            case 245: value = m_245_OEM_25; break;
            case 246: value = m_246_VK_ATTN; break;
            case 247: value = m_247_VK_CRSEL; break;
            case 248: value = m_248_VK_EXSEL; break;
            case 249: value = m_249_VK_EREOF; break;
            case 250: value = m_250_VK_PLAY; break;
            case 251: value = m_251_VK_ZOOM; break;
            case 252: value = m_252_VK_NONAME; break;
            case 253: value = m_253_VK_PA1; break;
            case 254: value = m_254_VK_OEM_CLEAR; break;
            default: value = false; break;
        }
    }

    public void SetKey(EnumScratchKeyboardWinHardware key, bool setValueAsPress, out bool changed)
    {
        SetKey((int)key, setValueAsPress, out changed);
    }
    public void SetKey(int key, bool setValueAsPress, out bool changedOfValue)
    {
        GetKey(key, out bool previousValue);
        changedOfValue = previousValue != setValueAsPress;
        if (changedOfValue)
        {
            SetKey(key, setValueAsPress);
        }
        
    }
}