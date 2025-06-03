


/// <summary>
/// ~!@#$%^&*()_-+={}[]|\:;"'<>,.?/
/// https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
/// </summary>
[System.Serializable]
public class ScratchToWarcraftChar
{

    public string m_shortDescription;
    public char m_char;
    public int m_decimal;

    public ScratchToWarcraftChar(char character, int integerValue, string description)
    {
        m_shortDescription = description;
        m_char = character;
        m_decimal = integerValue;
    }

    public static void TryToParse(char character, out bool found, out ScratchToWarcraftChar valueFound)
    {
        found = false;
        valueFound = null;
        for (int i = 0; i < UTF8.Length; i++)
        {
            if (UTF8[i].m_char == character)
            {
                found = true;
                valueFound = UTF8[i];
                break;
            }
        }
    }
    public static void TryToParse(char character, out bool found, out int valueFound)
    {
        TryToParse(character, out found, out ScratchToWarcraftChar valueFoundScratch);
        if (found)
            valueFound = valueFoundScratch.m_decimal;
        else
            valueFound = 0;
    }

    public static void TryToParse(int integerValue, out bool found, out ScratchToWarcraftChar valueFound)
    {
        found = false;
        valueFound = null;
        for (int i = 0; i < UTF8.Length; i++)
        {
            if (UTF8[i].m_decimal == integerValue)
            {
                found = true;
                valueFound = UTF8[i];
                break;
            }
        }
    }
    public static void TryToParse(int integerValue, out bool found, out char valueFound)
    {
        TryToParse(integerValue, out found, out ScratchToWarcraftChar valueFoundScratch);
        if (found)
            valueFound = valueFoundScratch.m_char;
        else
            valueFound = ' ';

    }


    public static ScratchToWarcraftChar[] UTF8 = new ScratchToWarcraftChar[] {
        new ScratchToWarcraftChar(' ', 4032, "SPACE"),
        new ScratchToWarcraftChar('!', 4033, "EXCLAMATION MARK                                         "),
        new ScratchToWarcraftChar('"', 4034, "QUOTATION MARK                                           "),
        new ScratchToWarcraftChar('#', 4035, "NUMBER SIGN                                              "),
        new ScratchToWarcraftChar('$', 4036, "DOLLAR SIGN                                              "),
        new ScratchToWarcraftChar('%', 4037, "PERCENT SIGN                                             "),
        new ScratchToWarcraftChar('&', 4038, "AMPERSAND                                               "),
        new ScratchToWarcraftChar('\'', 4039, "APOSTROPHE                                              "),
        new ScratchToWarcraftChar('(', 4040, "LEFT PARENTHESIS                                        "),
        new ScratchToWarcraftChar(')', 4041, "RIGHT PARENTHESIS                                       "),
        new ScratchToWarcraftChar('*', 4042, "ASTERISK                                                "),
        new ScratchToWarcraftChar('+', 4043, "PLUS SIGN                                               "),
        new ScratchToWarcraftChar(',', 4044, "COMMA                                                   "),
        new ScratchToWarcraftChar('-', 4045, "HYPHEN-MINUS                                            "),
        new ScratchToWarcraftChar('.', 4046, "FULL STOP                                               "),
        new ScratchToWarcraftChar('/', 4047, "SOLIDUS                                                 "),
        new ScratchToWarcraftChar('0', 4048, "DIGIT ZERO                                              "),
        new ScratchToWarcraftChar('1', 4049, "DIGIT ONE                                               "),
        new ScratchToWarcraftChar('2', 4050, "DIGIT TWO                                               "),
        new ScratchToWarcraftChar('3', 4051, "DIGIT THREE                                             "),
        new ScratchToWarcraftChar('4', 4052, "DIGIT FOUR                                              "),
        new ScratchToWarcraftChar('5', 4053, "DIGIT FIVE                                              "),
        new ScratchToWarcraftChar('6', 4054, "DIGIT SIX                                               "),
        new ScratchToWarcraftChar('7', 4055, "DIGIT SEVEN                                             "),
        new ScratchToWarcraftChar('8', 4056, "DIGIT EIGHT                                             "),
        new ScratchToWarcraftChar('9', 4057, "DIGIT NINE                                              "),
        new ScratchToWarcraftChar(':', 4058, "COLON                                                   "),
        new ScratchToWarcraftChar(';', 4059, "SEMICOLON                                               "),
        new ScratchToWarcraftChar('<', 4060, "LESS-THAN SIGN                                          "),
        new ScratchToWarcraftChar('=', 4061, "EQUALS SIGN                                             "),
        new ScratchToWarcraftChar('>', 4062, "GREATER-THAN SIGN                                       "),
        new ScratchToWarcraftChar('?', 4063, "QUESTION MARK                                           "),
        new ScratchToWarcraftChar('@', 4064, "COMMERCIAL AT                                           "),
        new ScratchToWarcraftChar('A', 4065, "LATIN CAPITAL LETTER A                                  "),
        new ScratchToWarcraftChar('B', 4066, "LATIN CAPITAL LETTER B                                  "),
        new ScratchToWarcraftChar('C', 4067, "LATIN CAPITAL LETTER C                                  "),
        new ScratchToWarcraftChar('D', 4068, "LATIN CAPITAL LETTER D                                  "),
        new ScratchToWarcraftChar('E', 4069, "LATIN CAPITAL LETTER E                                  "),
        new ScratchToWarcraftChar('F', 4070, "LATIN CAPITAL LETTER F                                  "),
        new ScratchToWarcraftChar('G', 4071, "LATIN CAPITAL LETTER G                                  "),
        new ScratchToWarcraftChar('H', 4072, "LATIN CAPITAL LETTER H                                  "),
        new ScratchToWarcraftChar('I', 4073, "LATIN CAPITAL LETTER I                                  "),
        new ScratchToWarcraftChar('J', 4074, "LATIN CAPITAL LETTER J                                  "),
        new ScratchToWarcraftChar('K', 4075, "LATIN CAPITAL LETTER K                                  "),
        new ScratchToWarcraftChar('L', 4076, "LATIN CAPITAL LETTER L                                  "),
        new ScratchToWarcraftChar('M', 4077, "LATIN CAPITAL LETTER M                                  "),
        new ScratchToWarcraftChar('N', 4078, "LATIN CAPITAL LETTER N                                  "),
        new ScratchToWarcraftChar('O', 4079, "LATIN CAPITAL LETTER O                                  "),
        new ScratchToWarcraftChar('P', 4080, "LATIN CAPITAL LETTER P                                  "),
        new ScratchToWarcraftChar('Q', 4081, "LATIN CAPITAL LETTER Q                                  "),
        new ScratchToWarcraftChar('R', 4082, "LATIN CAPITAL LETTER R                                  "),
        new ScratchToWarcraftChar('S', 4083, "LATIN CAPITAL LETTER S                                  "),
        new ScratchToWarcraftChar('T', 4084, "LATIN CAPITAL LETTER T                                  "),
        new ScratchToWarcraftChar('U', 4085, "LATIN CAPITAL LETTER U                                  "),
        new ScratchToWarcraftChar('V', 4086, "LATIN CAPITAL LETTER V                                  "),
        new ScratchToWarcraftChar('W', 4087, "LATIN CAPITAL LETTER W                                  "),
        new ScratchToWarcraftChar('X', 4088, "LATIN CAPITAL LETTER X                                  "),
        new ScratchToWarcraftChar('Y', 4089, "LATIN CAPITAL LETTER Y                                  "),
        new ScratchToWarcraftChar('Z', 4090, "LATIN CAPITAL LETTER Z                                  "),
        new ScratchToWarcraftChar('[', 4091, "LEFT SQUARE BRACKET                                     "),
        new ScratchToWarcraftChar('\\', 4092, "REVERSE SOLIDUS                                         "),
        new ScratchToWarcraftChar(']', 4093, "RIGHT SQUARE BRACKET                                    "),
        new ScratchToWarcraftChar('^', 4094, "CIRCUMFLEX ACCENT                                       "),
        new ScratchToWarcraftChar('_', 4095, "LOW LINE                                                "),
        new ScratchToWarcraftChar('`', 4096, "GRAVE ACCENT                                            "),
        new ScratchToWarcraftChar('a', 4097, "LATIN SMALL LETTER A                                    "),
        new ScratchToWarcraftChar('b', 4098, "LATIN SMALL LETTER B                                    "),
        new ScratchToWarcraftChar('c', 4099, "LATIN SMALL LETTER C                                    "),
        new ScratchToWarcraftChar('d', 4100, "LATIN SMALL LETTER D                                    "),
        new ScratchToWarcraftChar('e', 4101, "LATIN SMALL LETTER E                                    "),
        new ScratchToWarcraftChar('f', 4102, "LATIN SMALL LETTER F                                    "),
        new ScratchToWarcraftChar('g', 4103, "LATIN SMALL LETTER G                                    "),
        new ScratchToWarcraftChar('h', 4104, "LATIN SMALL LETTER H                                    "),
        new ScratchToWarcraftChar('i', 4105, "LATIN SMALL LETTER I                                    "),
        new ScratchToWarcraftChar('j', 4106, "LATIN SMALL LETTER J                                    "),
        new ScratchToWarcraftChar('k', 4107, "LATIN SMALL LETTER K                                    "),
        new ScratchToWarcraftChar('l', 4108, "LATIN SMALL LETTER L                                    "),
        new ScratchToWarcraftChar('m', 4109, "LATIN SMALL LETTER M                                    "),
        new ScratchToWarcraftChar('n', 4110, "LATIN SMALL LETTER N                                    "),
        new ScratchToWarcraftChar('o', 4111, "LATIN SMALL LETTER O                                    "),
        new ScratchToWarcraftChar('p', 4112, "LATIN SMALL LETTER P                                    "),
        new ScratchToWarcraftChar('q', 4113, "LATIN SMALL LETTER Q                                    "),
        new ScratchToWarcraftChar('r', 4114, "LATIN SMALL LETTER R                                    "),
        new ScratchToWarcraftChar('s', 4115, "LATIN SMALL LETTER S                                    "),
        new ScratchToWarcraftChar('t', 4116, "LATIN SMALL LETTER T                                    "),
        new ScratchToWarcraftChar('u', 4117, "LATIN SMALL LETTER U                                    "),
        new ScratchToWarcraftChar('v', 4118, "LATIN SMALL LETTER V                                    "),
        new ScratchToWarcraftChar('w', 4119, "LATIN SMALL LETTER W                                    "),
        new ScratchToWarcraftChar('x', 4120, "LATIN SMALL LETTER X                                    "),
        new ScratchToWarcraftChar('y', 4121, "LATIN SMALL LETTER Y                                    "),
        new ScratchToWarcraftChar('z', 4122, "LATIN SMALL LETTER Z                                    "),
        new ScratchToWarcraftChar('{', 4123, "LEFT CURLY BRACKET                                      "),
        new ScratchToWarcraftChar('|', 4124, "VERTICAL LINE                                           "),
        new ScratchToWarcraftChar('}', 4125, "RIGHT CURLY BRACKET                                     "),
        new ScratchToWarcraftChar('~', 4126, "TILDE                                                   "),
        new ScratchToWarcraftChar(' ', 4160, "NO-BREAK SPACE                                              "),
        new ScratchToWarcraftChar('¡', 4161, "INVERTED EXCLAMATION MARK                               "),
        new ScratchToWarcraftChar('¢', 4162, "CENT SIGN                                               "),
        new ScratchToWarcraftChar('£', 4163, "POUND SIGN                                              "),
        new ScratchToWarcraftChar('¤', 4164, "CURRENCY SIGN                                           "),
        new ScratchToWarcraftChar('¥', 4165, "YEN SIGN                                                "),
        new ScratchToWarcraftChar('¦', 4166, "BROKEN BAR                                              "),
        new ScratchToWarcraftChar('§', 4167, "SECTION SIGN                                            "),
        new ScratchToWarcraftChar('¨', 4168, "DIAERESIS                                               "),
        new ScratchToWarcraftChar('©', 4169, "COPYRIGHT SIGN                                          "),
        new ScratchToWarcraftChar('ª', 4170, "FEMININE ORDINAL INDICATOR                              "),
        new ScratchToWarcraftChar('«', 4171, "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK               "),
        new ScratchToWarcraftChar('¬', 4172, "NOT SIGN                                                "),
        new ScratchToWarcraftChar(' ', 4173, "SOFT HYPHEN                                                 "),
        new ScratchToWarcraftChar('®', 4174, "REGISTERED SIGN                                         "),
        new ScratchToWarcraftChar('¯', 4175, "MACRON                                                  "),
        new ScratchToWarcraftChar('°', 4176, "DEGREE SIGN                                             "),
        new ScratchToWarcraftChar('±', 4177, "PLUS-MINUS SIGN                                         "),
        new ScratchToWarcraftChar('²', 4178, "SUPERSCRIPT TWO                                         "),
        new ScratchToWarcraftChar('³', 4179, "SUPERSCRIPT THREE                                       "),
        new ScratchToWarcraftChar('´', 4180, "ACUTE ACCENT                                            "),
        new ScratchToWarcraftChar('µ', 4181, "MICRO SIGN                                              "),
        new ScratchToWarcraftChar('¶', 4182, "PILCROW SIGN                                            "),
        new ScratchToWarcraftChar('·', 4183, "MIDDLE DOT                                              "),
        new ScratchToWarcraftChar('¸', 4184, "CEDILLA                                                 "),
        new ScratchToWarcraftChar('¹', 4185, "SUPERSCRIPT ONE                                         "),
        new ScratchToWarcraftChar('º', 4186, "MASCULINE ORDINAL INDICATOR                             "),
        new ScratchToWarcraftChar('»', 4187, "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK              "),
        new ScratchToWarcraftChar('¼', 4188, "VULGAR FRACTION ONE QUARTER                             "),
        new ScratchToWarcraftChar('½', 4189, "VULGAR FRACTION ONE HALF                                "),
        new ScratchToWarcraftChar('¾', 4190, "VULGAR FRACTION THREE QUARTERS                          "),
        new ScratchToWarcraftChar('¿', 4191, "INVERTED QUESTION MARK                                  "),
        new ScratchToWarcraftChar('À', 4192, "LATIN CAPITAL LETTER A WITH GRAVE                       "),
        new ScratchToWarcraftChar('Á', 4193, "LATIN CAPITAL LETTER A WITH ACUTE                       "),
        new ScratchToWarcraftChar('Â', 4194, "LATIN CAPITAL LETTER A WITH CIRCUMFLEX                  "),
        new ScratchToWarcraftChar('Ã', 4195, "LATIN CAPITAL LETTER A WITH TILDE                       "),
        new ScratchToWarcraftChar('Ä', 4196, "LATIN CAPITAL LETTER A WITH DIAERESIS                   "),
        new ScratchToWarcraftChar('Å', 4197, "LATIN CAPITAL LETTER A WITH RING ABOVE                  "),
        new ScratchToWarcraftChar('Æ', 4198, "LATIN CAPITAL LETTER AE                                 "),
        new ScratchToWarcraftChar('Ç', 4199, "LATIN CAPITAL LETTER C WITH CEDILLA                     "),
        new ScratchToWarcraftChar('È', 4200, "LATIN CAPITAL LETTER E WITH GRAVE                       "),
        new ScratchToWarcraftChar('É', 4201, "LATIN CAPITAL LETTER E WITH ACUTE                       "),
        new ScratchToWarcraftChar('Ê', 4202, "LATIN CAPITAL LETTER E WITH CIRCUMFLEX                  "),
        new ScratchToWarcraftChar('Ë', 4203, "LATIN CAPITAL LETTER E WITH DIAERESIS                   "),
        new ScratchToWarcraftChar('Ì', 4204, "LATIN CAPITAL LETTER I WITH GRAVE                       "),
        new ScratchToWarcraftChar('Í', 4205, "LATIN CAPITAL LETTER I WITH ACUTE                       "),
        new ScratchToWarcraftChar('Î', 4206, "LATIN CAPITAL LETTER I WITH CIRCUMFLEX                  "),
        new ScratchToWarcraftChar('Ï', 4207, "LATIN CAPITAL LETTER I WITH DIAERESIS                   "),
        new ScratchToWarcraftChar('Ð', 4208, "LATIN CAPITAL LETTER ETH                                "),
        new ScratchToWarcraftChar('Ñ', 4209, "LATIN CAPITAL LETTER N WITH TILDE                       "),
        new ScratchToWarcraftChar('Ò', 4210, "LATIN CAPITAL LETTER O WITH GRAVE                       "),
        new ScratchToWarcraftChar('Ó', 4211, "LATIN CAPITAL LETTER O WITH ACUTE                       "),
        new ScratchToWarcraftChar('Ô', 4212, "LATIN CAPITAL LETTER O WITH CIRCUMFLEX                  "),
        new ScratchToWarcraftChar('Õ', 4213, "LATIN CAPITAL LETTER O WITH TILDE                       "),
        new ScratchToWarcraftChar('Ö', 4214, "LATIN CAPITAL LETTER O WITH DIAERESIS                   "),
        new ScratchToWarcraftChar('×', 4215, "MULTIPLICATION SIGN                                     "),
        new ScratchToWarcraftChar('Ø', 4216, "LATIN CAPITAL LETTER O WITH STROKE                      "),
        new ScratchToWarcraftChar('Ù', 4217, "LATIN CAPITAL LETTER U WITH GRAVE                       "),
        new ScratchToWarcraftChar('Ú', 4218, "LATIN CAPITAL LETTER U WITH ACUTE                       "),
        new ScratchToWarcraftChar('Û', 4219, "LATIN CAPITAL LETTER U WITH CIRCUMFLEX                  "),
        new ScratchToWarcraftChar('Ü', 4220, "LATIN CAPITAL LETTER U WITH DIAERESIS                   "),
        new ScratchToWarcraftChar('Ý', 4221, "LATIN CAPITAL LETTER Y WITH ACUTE                       "),
        new ScratchToWarcraftChar('Þ', 4222, "LATIN CAPITAL LETTER THORN                              "),
        new ScratchToWarcraftChar('ß', 4223, "LATIN SMALL LETTER SHARP S                              "),
        new ScratchToWarcraftChar('à', 4224, "LATIN SMALL LETTER A WITH GRAVE                         "),
        new ScratchToWarcraftChar('á', 4225, "LATIN SMALL LETTER A WITH ACUTE                         "),
        new ScratchToWarcraftChar('â', 4226, "LATIN SMALL LETTER A WITH CIRCUMFLEX                    "),
        new ScratchToWarcraftChar('ã', 4227, "LATIN SMALL LETTER A WITH TILDE                         "),
        new ScratchToWarcraftChar('ä', 4228, "LATIN SMALL LETTER A WITH DIAERESIS                     "),
        new ScratchToWarcraftChar('å', 4229, "LATIN SMALL LETTER A WITH RING ABOVE                    "),
        new ScratchToWarcraftChar('æ', 4230, "LATIN SMALL LETTER AE                                   "),
        new ScratchToWarcraftChar('ç', 4231, "LATIN SMALL LETTER C WITH CEDILLA                       "),
        new ScratchToWarcraftChar('è', 4232, "LATIN SMALL LETTER E WITH GRAVE                         "),
        new ScratchToWarcraftChar('é', 4233, "LATIN SMALL LETTER E WITH ACUTE                         "),
        new ScratchToWarcraftChar('ê', 4234, "LATIN SMALL LETTER E WITH CIRCUMFLEX                    "),
        new ScratchToWarcraftChar('ë', 4235, "LATIN SMALL LETTER E WITH DIAERESIS                     "),
        new ScratchToWarcraftChar('ì', 4236, "LATIN SMALL LETTER I WITH GRAVE                         "),
        new ScratchToWarcraftChar('í', 4237, "LATIN SMALL LETTER I WITH ACUTE                         "),
        new ScratchToWarcraftChar('î', 4238, "LATIN SMALL LETTER I WITH CIRCUMFLEX                    "),
        new ScratchToWarcraftChar('ï', 4239, "LATIN SMALL LETTER I WITH DIAERESIS                     "),
        new ScratchToWarcraftChar('ð', 4240, "LATIN SMALL LETTER ETH                                  "),
        new ScratchToWarcraftChar('ñ', 4241, "LATIN SMALL LETTER N WITH TILDE                         "),
        new ScratchToWarcraftChar('ò', 4242, "LATIN SMALL LETTER O WITH GRAVE                         "),
        new ScratchToWarcraftChar('ó', 4243, "LATIN SMALL LETTER O WITH ACUTE                         "),
        new ScratchToWarcraftChar('ô', 4244, "LATIN SMALL LETTER O WITH CIRCUMFLEX                    "),
        new ScratchToWarcraftChar('õ', 4245, "LATIN SMALL LETTER O WITH TILDE                         "),
        new ScratchToWarcraftChar('ö', 4246, "LATIN SMALL LETTER O WITH DIAERESIS                     "),
        new ScratchToWarcraftChar('÷', 4247, "DIVISION SIGN                                           "),
        new ScratchToWarcraftChar('ø', 4248, "LATIN SMALL LETTER O WITH STROKE                        "),
        new ScratchToWarcraftChar('ù', 4249, "LATIN SMALL LETTER U WITH GRAVE                         "),
        new ScratchToWarcraftChar('ú', 4250, "LATIN SMALL LETTER U WITH ACUTE                         "),
        new ScratchToWarcraftChar('û', 4251, "LATIN SMALL LETTER U WITH CIRCUMFLEX                    "),
        new ScratchToWarcraftChar('ü', 4252, "LATIN SMALL LETTER U WITH DIAERESIS                     "),
        new ScratchToWarcraftChar('ý', 4253, "LATIN SMALL LETTER Y WITH ACUTE                         "),
        new ScratchToWarcraftChar('þ', 4254, "LATIN SMALL LETTER THORN                                "),
        new ScratchToWarcraftChar('ÿ', 4255, "LATIN SMALL LETTER Y WITH DIAERESISChar	Decimal	Short Description")
    };
   
}
