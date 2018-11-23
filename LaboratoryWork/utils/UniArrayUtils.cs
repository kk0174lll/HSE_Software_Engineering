using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.utils
{
    abstract class UniArrayUtils<T>
    {
        public delegate T createElementFunction(string index);

        public abstract T ElementFromRandom(string index);

        public abstract T ElementFromHand(string index);


        protected static T ElementFromHand(string index, Utils.TryParseFunction<T> tryParse)
        {
            return Utils.ReadFromConsole($"array_{index}", tryParse);
        }

        public static T[] CreateArray(createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number of array elements");
            if (n < 0)
            {
                Utils.PrintLnErrorText($"number of array elements must be > 0; create empty array");
                return new T[0];
            }
            T[] array = CreateArray(n, makeFunction);
            Utils.PrintLnText($"CreateArray successful: {PrintArray(array)}");
            return array;
        }

        public static T[,] CreateMatrixArray(createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number size N");
            int m = Utils.ReadInt($"number size M");
            if (n < 0 || m < 0)
            {
                Utils.PrintLnErrorText($"size must be > 0; create empty array");
                return new T[0, 0];
            }
            T[,] array = CreateArray(n, m, makeFunction);
            Utils.PrintLnText($"CreateArray successful: {PrintArray(array)}");
            return array;
        }

        public static T[][] CreateRaggedArray(createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number size N");
            if (n < 0)
            {
                throw new ArgumentException($"size N must be > 0");
            }
            T[][] array = new T[n][];
            for (int i = 0; i < n; i++)
            {
                int m = Utils.ReadInt($"number size M");
                if (m < 0)
                {
                    throw new ArgumentException($"size M must be > 0");
                }
                array[i] = CreateArray(m, makeFunction);
            }
            Utils.PrintLnText($"CreateArray successful: {PrintArray(array)}");
            return array;
        }

        public static T[] CreateArray(int n, createElementFunction makeFunction)
        {
            T[] array = new T[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = makeFunction($"[{i}]");
            }
            return array;
        }

        private static T[,] CreateArray(int n, int m, createElementFunction makeFunction)
        {
            T[,] array = new T[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = makeFunction($"[{i},{j}]");
                }

            }
            return array;
        }

        public static string PrintArray(T[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T x in array)
            {
                sb.Append($"{x} ");
            }
            return sb.ToString();
        }

        public static string PrintArray(T[,] array)
        {
            StringBuilder sb = new StringBuilder("\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sb.Append($"{array[i, j]} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static string PrintArray(T[][] arrays)
        {
            StringBuilder sb = new StringBuilder("\n");
            foreach (T[] array in arrays)
            {
                foreach (T element in array)
                {
                    sb.Append($"{element} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static T[] DeleteIndex(T[] array, int index)
        {
            T[] result = new T[array.Length - 1];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    result[j] = array[i];
                    j++;
                }
            }
            return result;
        }

        public static void BubleSort(ref int[] array)
        {
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
        }

        public static bool FindValue(int[] array, int n)
        {
            int findIndex, count;
            return FindValue(array, n, out findIndex, out count);
        }

        public static bool FindValue(int[] array, int n, out int findIndex, out int count)
        {
            count = 0;
            findIndex = 0;
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
            return isFind;

        }
    }
}
