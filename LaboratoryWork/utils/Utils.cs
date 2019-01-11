using System;

namespace LaboratoryWork
{
    class Utils
    {
        public static Random random = new Random(0);
        public static CharArrayUtils charArrayUtils = new CharArrayUtils();
        public static IntArrayUtils intArrayUtils = new IntArrayUtils();

        private static readonly ConsoleColor DEFAULT = ConsoleColor.White;

        public delegate bool TryParseFunction<T>(string value, out T result);

        public static void PrintLnText(string text)
        {
            Utils.PrintText(text, true, ETextType.NORMAL);
        }

        public static void PrintText(string text)
        {
            Utils.PrintText(text, false, ETextType.NORMAL);
        }

        public static void PrintLnErrorText(string text)
        {
            Utils.PrintText(text, true, ETextType.ERRORR);
        }

        public static void PrintErrorText(string text)
        {
            Utils.PrintText(text, false, ETextType.ERRORR);
        }

        private static void PrintText(string text, bool newline, ETextType textType)
        {
            switch (textType)
            {
                case ETextType.ERRORR: Console.ForegroundColor = ConsoleColor.Red; break;
                case ETextType.SUCCESS: Console.ForegroundColor = ConsoleColor.Green; break;
                default: Console.ForegroundColor = DEFAULT; break;
            }
            if (newline)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }

            Console.ForegroundColor = DEFAULT;
        }

        public static int ReadInt(string variableName)
        {
            return ReadFromConsole<int>(variableName, int.TryParse);
        }

        public static char ReadChar(string variableName)
        {
            return ReadFromConsole<char>(variableName, char.TryParse);
        }

        public static double ReadDouble(string variableName)
        {
            return ReadFromConsole<double>(variableName, double.TryParse);
        }

        public static string ReadString()
        {
            return ReadString("string");
        }

        public static string ReadString(string variableName)
        {
            do
            {
                Utils.PrintText($"Please enter {variableName}: ");
                string enteredText = Console.ReadLine();
                if (enteredText.Length == 0)
                {
                    Utils.PrintLnErrorText($"string is empty");
                }
                else
                {
                    return enteredText;
                }
            } while (true);
        }


        public static T ReadFromConsole<T>(string variableName, TryParseFunction<T> tryParse)
        {
            do
            {
                Utils.PrintText($"Please enter {variableName}: ");
                string enteredText = Console.ReadLine();
                T result;
                if (tryParse(enteredText, out result))
                {
                    return result;
                }
                Utils.PrintLnErrorText($"ERRORR: fail parse {enteredText}. Try again.");
            } while (true);
        }

        public static String StringValue(Object o)
        {
            return StringValue(o, "");
        }

        public static String StringValue(Object o, string defaultValue)
        {
            if (null == o)
            {
                return defaultValue;
            }
            if (o.GetType() == typeof(string))
            {
                String s = (String)o;
                return IsEmpty(s) ? defaultValue : s.Trim();
            }
            return o.ToString();
        }

        public static bool IsEmpty(String str)
        {
            return str == null || str.Length == 0 || str.Trim().Length == 0;
        }

    }
}
