using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work06
{
    class Task2 : ATask
    {
        public Task2()
        {
            taskName = "v19. w06, task 2";
        }
        char[] wordSeparators = new char[7] { ',', '.', ' ', ';', ':', '!', '?' };
        /// <summary>
        /// 1. Ввести строку символов с клавиатуры. Строка состоит из слов, разделенных пробелами 
        /// (пробелов может быть несколько) и знаками препинания (, ;:). В строке может быть несколько предложений,
        /// в конце каждого предложения стоит знак препинания (.!?).
        /// 2. Выполнить обработку строки в соответствии с вариантом.
        /// 3. Результаты обработки вывести на печать.
        /// 
        /// Перевернуть каждое слово, номер которого совпадает с его длиной
        /// </summary>
        protected override void executeTasck()
        {
            Utils.PrintText($"result = {Process(Utils.ReadString())}");
        }

        private string Process(string enteredText)
        {
            int wordNumber = 0;
            bool isWord = false;
            StringBuilder currentWordBuilder = new StringBuilder();
            StringBuilder newStringBuilde = new StringBuilder();
            char currenChar;

            for (int i = 0; i < enteredText.Length; i++)
            {
                currenChar = enteredText[i];
                if (Array.Exists(wordSeparators, e => e == currenChar))
                {
                    if (isWord)
                    {
                        isWord = false;
                        appendWord(wordNumber, currentWordBuilder, newStringBuilde);
                    };
                    newStringBuilde.Append(currenChar);
                }
                else
                {
                    if (!isWord)
                    {
                        isWord = true;
                        wordNumber++;
                    }
                    currentWordBuilder.Append(currenChar);
                }
            }
            appendWord(wordNumber, currentWordBuilder, newStringBuilde);
            return newStringBuilde.ToString();
        }

        private void appendWord(int wordNumber, StringBuilder currentWordBuilder, StringBuilder newStringBuilde)
        {
            string currenString = currentWordBuilder.ToString();
            currentWordBuilder.Clear();
            if (wordNumber == currenString.Length)
            {
                newStringBuilde.Append(TurnString(currenString));
            }
            else
            {
                newStringBuilde.Append(currenString);
            }
        }


        private string TurnString(string toTurnStr)
        {
            StringBuilder sb = new StringBuilder(toTurnStr.Length);
            for (int i = toTurnStr.Length - 1; i >= 0; i--)
            {
                sb.Append(toTurnStr[i]);
            }
            return sb.ToString();
        }





    }
}
