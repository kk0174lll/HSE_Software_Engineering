using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            do
            {
                Utils.PrintText("Please enter string: ");
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
                Utils.PrintText($"Please enter {variableName} = ");
                string enteredText = Console.ReadLine();
                T result;
                if (tryParse(enteredText, out result))
                {
                    return result;
                }
                Utils.PrintLnErrorText($"ERRORR: fail parse {enteredText}. Try again.");
            } while (true);
        }

    }
}
