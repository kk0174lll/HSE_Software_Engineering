using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork
{
    class Utils
    {
        private static readonly ConsoleColor DEFAULT = ConsoleColor.White;

        private delegate bool TryParseFunction<T>(string value, out T result);

        public static void PrintLnText(String text)
        {
            Utils.PrintText(text, true, ETextType.NORMAL);
        }

        public static void PrintText(String text)
        {
            Utils.PrintText(text, false, ETextType.NORMAL);
        }

        public static void PrintLnErrorText(String text)
        {
            Utils.PrintText(text, true, ETextType.ERRORR);
        }

        public static void PrintErrorText(String text)
        {
            Utils.PrintText(text, false, ETextType.ERRORR);
        }

        private static void PrintText(String text, Boolean newline, ETextType textType)
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

        public static int ReadInt(String variableName)
        {
            return ReadFromConsole<int>(variableName, int.TryParse);
        }

        public static double ReadDouble(String variableName)
        {
            return ReadFromConsole<double>(variableName, double.TryParse);
        }

        private static T ReadFromConsole<T>(String variableName, TryParseFunction<T> tryParse)
        {
            do
            {
                Utils.PrintText($"Please enter {variableName} = ", false, ETextType.NORMAL);
                String enteredText = Console.ReadLine();
                T result;
                if (tryParse(enteredText, out result))
                {
                    return result;
                }
                Utils.PrintText($"ERRORR: fail parse {enteredText}. Try again.", true, ETextType.ERRORR);
            } while (true);
        }

    }
}
