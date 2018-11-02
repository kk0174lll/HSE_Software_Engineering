using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work04
{
    class Task1 : ATask
    {
        private delegate int createElementFunction(int index);
        private Random random = new Random(0);
        int[] array = new int[0];

        public Task1()
        {
            taskName = "v19. w04, task 1";
        }

        /// <summary>
        /// 1) Сформировать массив из n элементов с помощью датчика
        /// случайных чисел (n задается пользователем с клавиатуры).
        ///2) Распечатать массив.
        ///3) Выполнить удаление указанных элементов из массива.
        ///4) Выполнить добавление указанных элементов в массив.
        ///5) Выполнить перестановку элементов в массиве.
        ///6) Выполнить поиск указанных в массиве элементов и подсчитать
        ///количество сравнений, необходимых для поиска нужного элемента.
        ///7) Выполнить сортировку массива указанным методом.
        ///8) Выполнить поиск указанных элементов в отсортированном массиве и 
        ///подсчитать количество сравнений, необходимых для поиска нужного элемента.
        /// Удаление - Максимальный элемент
        /// Добавление - N элементов, начиная с номера К
        /// Перестановка - Четные элементы переставить в начало массива, нечетные - в конец
        /// Поиск - Элемент с заданным ключом(значением)
        /// Сортировка - Простой обмен

        /// </summary>
        protected override void executeTasck()
        {
            bool exit = false;
            do
            {
                PrintMenu();
                try
                {
                    exit = ActionFromMenu();
                }
                catch (Exception e)
                {
                    Utils.PrintLnErrorText($"something wrong, try again");
                }
            } while (!exit);
        }

        private int[] CreateArray(createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number of array elements");
            if (n < 0)
            {
                Utils.PrintLnErrorText($"number of array elements must be > 0; create empty array");
                return new int[0];
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = makeFunction(i);
            }
            Utils.PrintLnText($"CreateArray successful: {PrintArray(array)}");
            return array;
        }

        private int ElementFromRandom(int index)
        {
            return random.Next(0, 100);
        }

        private int ElementFromHand(int index)
        {
            return Utils.ReadInt($"array_{index}");
        }

        private String PrintArray(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int x in array)
            {
                sb.Append($"{x} ");
            }
            return sb.ToString();
        }

        private int[] DeleteFromArray(int[] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return new int[0];
            }
            int[] result = new int[array.Length - 1];

            int maxIndex = FindMaxElemIndex(array);
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != maxIndex)
                {
                    result[j] = array[i];
                    j++;
                }
            }
            Utils.PrintLnText($"DeleteFromArray successful; deleted element = {array[maxIndex]}");
            return result;
        }

        private int FindMaxElemIndex(int[] array)
        {
            int maxElement = 0;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private int[] UpdateArray(int[] array, createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number new array elements");
            int k = Utils.ReadInt($"position K for insert");
            if (k > array.Length || k < 0)
            {
                Utils.PrintLnErrorText($"position K beyond the array");
                return array;
            }
            int[] result = new int[array.Length + n];
            for (int i = 0, j = 0; i < result.Length; i++)
            {
                if (i >= k && i < k + n)
                {
                    result[i] = makeFunction(i);
                }
                else
                {
                    result[i] = array[j];
                    j++;
                }
            }
            Utils.PrintLnText($"UpdateArray successful: {PrintArray(result)}");
            return result;
        }

        /// <summary>
        /// Четные элементы переставить в начало массива, нечетные - в конец
        /// </summary>
        /// <param name="array">Входной массив</param>
        /// <returns>Обработанный массив</returns>
        private int[] Transposition(int[] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return array;
            }
            int[] result = new int[array.Length];
            int evenIndex = 0;
            int oddIndex = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result[evenIndex] = array[i];
                    evenIndex++;
                }
                else
                {
                    result[oddIndex] = array[i];
                    oddIndex--;
                }
            }
            Utils.PrintLnText($"Transposition successful: {PrintArray(result)}");
            return array;
        }

        private void FindValue(int[] array)
        {
            if (array.Length == 0)
            {
                Utils.PrintLnText($"array is empty");
                return;
            }
            int n = Utils.ReadInt($"value for find");
            int count = 0;
            int findIndex = 0;
            bool isFind = false;
            for (int i = 0; !isFind && i < array.Length; i++)
            {
                count++;
                if (array[i] == n)
                {
                    findIndex = i;
                    isFind = true;
                }
            }
            Utils.PrintLnText($"value {n} index = {findIndex}; compare count = {count}");
        }

        private void BinaryFindValue(int[] array)
        {
            int n = Utils.ReadInt($"value for find");
            if (array.Length == 0 || n < array[0] || n > array[array.Length - 1])
            {
                Utils.PrintLnText($"array do not has value {n}");
                return;
            }
            int count = 0;
            int findIndex = 0;
            int mid = 0;
            int first = 0;
            int last = array.Length;
            while (first < last)
            {
                mid = first + (last - first) / 2;
                if (n <= array[mid])
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
                count++;
            }
            count++;
            if (array[last] == n)
            {
                findIndex = last;
            }
            Utils.PrintLnText($"value {n} index = {findIndex}; compare count = {count}");
        }

        private int[] Sort(int[] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return array;
            }
            int tempValue = 0;
            int numberOfPairs = array.Length;
            bool swappedElements = true;
            do
            {
                numberOfPairs--;
                swappedElements = false;
                for (int i = 0; i < numberOfPairs; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tempValue = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tempValue;
                        swappedElements = true;
                    }
                }
            } while (swappedElements);
            Utils.PrintLnText($"Sort successful: {PrintArray(array)}");
            return array;
        }

        private void PrintMenu()
        {
            Utils.PrintLnText($" 1 - Создать массив вручную");
            Utils.PrintLnText($" 2 - Создать массив с помощью датчика случайных чисел");
            Utils.PrintLnText($" 3 - Печать массива");
            Utils.PrintLnText($" 4 - Удаление");
            Utils.PrintLnText($" 5 - Добавление(ручное)");
            Utils.PrintLnText($" 6 - Добавление(рандом)");
            Utils.PrintLnText($" 7 - Перестановка");
            Utils.PrintLnText($" 8 - Поиск");
            Utils.PrintLnText($" 9 - Сортировка");
            Utils.PrintLnText($" 10 - Двоичный Поиск");
            Utils.PrintLnText($" 0 - Выход");
        }

        private bool ActionFromMenu()
        {
            bool exit = false;
            int action = Utils.ReadInt($"number of action");
            switch (action)
            {
                case 1: array = CreateArray(ElementFromHand); break;
                case 2: array = CreateArray(ElementFromRandom); break;
                case 3: Utils.PrintLnText($"Array: {PrintArray(array)}"); break;
                case 4: array = DeleteFromArray(array); break;
                case 5: array = UpdateArray(array, ElementFromHand); break;
                case 6: array = UpdateArray(array, ElementFromRandom); break;
                case 7: array = Transposition(array); break;
                case 8: FindValue(array); break;
                case 9: array = Sort(array); break;
                case 10: BinaryFindValue(array); break;
                case 0: exit = true; break;
            }
            return exit;
        }
    }
}
