using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work06
{
    class Task1 : ATask
    {
        char[] array = new char[0];
        char[] vowels = new char[6] { 'A', 'E', 'I', 'O', 'U', 'Y' };

        public Task1()
        {
            taskName = "v19. w06, task 1";

        }
        /// <summary>
        /// Создать динамический массив (Одномерный) из элементов заданного типа (char). При заполнении массива использовать 2 способа (ручной и с помощью ДСЧ).
        //2. Массив вывести на печать.
        //3. Выполнить операции с массивом, указанные в варианте (Удалить из массива последнюю гласную букву.),
        // используя, по возможности, методы класса Array.
        //4. Результаты обработки вывести на печать.
        /// </summary>
        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(PrintMenu, ActionFromMenu);
        }

        /// <summary>
        /// Удалить из массива последнюю гласную букву.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private char[] DeleteFromArray(char[] array)
        {
            if (array == null || array.Length == 1)
            {
                throw new ArgumentException("array is empty");
            }
            int vowelIndex = SearchLastVowelIndex(array);
            if (vowelIndex == -1)
            {
                Utils.PrintLnText("array does not contain vowels");
                return array;
            }
            char[] result = CharArrayUtils.DeleteIndex(array, vowelIndex);

            Utils.PrintLnText($"DeleteFromArray successful; deleted element = {array[vowelIndex]}");
            return result;
        }

        /// <summary>
        /// search last vowel index, return -1 if array does not contain vowels
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int SearchLastVowelIndex(char[] array)
        {
            int vowelIndex = -1;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (Array.Exists(vowels, e => Char.ToLower(e) == Char.ToLower(array[i])))
                {
                    vowelIndex = i;
                    break;
                }
            }
            return vowelIndex;
        }

        private void PrintMenu()
        {
            Utils.PrintLnText($" 1 - Создать массив вручную");
            Utils.PrintLnText($" 2 - Создать массив с помощью датчика случайных чисел");
            Utils.PrintLnText($" 3 - Печать массива");
            Utils.PrintLnText($" 4 - Удаление");
            Utils.PrintLnText($" 0 - Выход");
        }

        private void ActionFromMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: array = CharArrayUtils.CreateArray(Utils.charArrayUtils.ElementFromHand); break;
                case 2: array = CharArrayUtils.CreateArray(Utils.charArrayUtils.ElementFromRandom); break;
                case 3: Utils.PrintLnText($"Array: {CharArrayUtils.PrintArray(array)}"); break;
                case 4: array = DeleteFromArray(array); break;
                case 0: exit = true; break;
            }
        }
    }

}
