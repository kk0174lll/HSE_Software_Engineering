using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.utils
{
    class ArrayUtils
    {
        public delegate int createElementFunction(String index);

        private static Random random = new Random(0);


        public static int ElementFromRandom(String index)
        {
            return random.Next(0, 100);
        }

        public static int ElementFromHand(String index)
        {
            return Utils.ReadInt($"array_{index}");
        }

        public static int[] CreateArray(ArrayUtils.createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number of array elements");
            if (n < 0)
            {
                Utils.PrintLnErrorText($"number of array elements must be > 0; create empty array");
                return new int[0];
            }
            int[] array = ArrayUtils.CreateArray(n, makeFunction);
            Utils.PrintLnText($"CreateArray successful: {ArrayUtils.PrintArray(array)}");
            return array;
        }

        public static int[,] CreateMatrixArray(ArrayUtils.createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number size N");
            int m = Utils.ReadInt($"number size M");
            if (n < 0 || m < 0)
            {
                Utils.PrintLnErrorText($"size must be > 0; create empty array");
                return new int[0, 0];
            }
            int[,] array = ArrayUtils.CreateArray(n, m, makeFunction);
            Utils.PrintLnText($"CreateArray successful: {ArrayUtils.PrintArray(array)}");
            return array;
        }

        public static int[] CreateArray(int n, ArrayUtils.createElementFunction makeFunction)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = makeFunction($"[{i}]");
            }
            return array;
        }

        public static int[,] CreateArray(int n, int m, ArrayUtils.createElementFunction makeFunction)
        {
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < m; i++)
                {
                    array[i, j] = makeFunction($"[{i},{j}]");
                }

            }
            return array;
        }

        public static String PrintArray(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int x in array)
            {
                sb.Append($"{x} ");
            }
            return sb.ToString();
        }

        public static String PrintArray(int[,] array)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sb.Append($"{array[i,j]} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static String PrintArray(int[][] arrays)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int[] array in arrays)
            {
                foreach (int element in array)
                {
                    sb.Append($"{element} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
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
