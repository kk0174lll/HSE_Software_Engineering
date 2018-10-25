using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork
{
    class Utils
    {
        private static ConsoleColor DEFAULT = ConsoleColor.White;
        public static void printText(String text, Boolean newline, ETextType textType)
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

        public static int readInt(String variableName)
        {
            int result = 0;
            bool success = false;
            while (!success)
            {
                Utils.printText($"Please enter Int number {variableName}=", false, ETextType.NORMAL);
                String enteredText = Console.ReadLine();
                success = int.TryParse(enteredText, out result);
                if (!success)
                {
                    Utils.printText($"ERRORR: fail parse {enteredText} to int. Try again.", true, ETextType.ERRORR);
                }
            }
            return result;
        }

        public static double readDouble(String variableName)
        {
            double result = 0;
            bool success = false;
            while (!success)
            {
                Utils.printText($"Please enter double number {variableName}=", false, ETextType.NORMAL);
                String enteredText = Console.ReadLine();
                success = double.TryParse(enteredText, out result);
                if (!success)
                {
                    Utils.printText($"ERRORR: fail parse {enteredText} to double. Try again.", true, ETextType.ERRORR);
                }
            }
            return result;
        }
    }
}
