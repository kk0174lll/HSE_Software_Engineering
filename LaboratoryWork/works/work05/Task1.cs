
using LaboratoryWork;
using LaboratoryWork1.utils;
using System;

namespace LaboratoryWork1.works.work05
{
    class Task1 : ATask, IExecutor
    {
        private Menu menu;

        private int[] array;
        private int[,] matrix;
        private int[][] raggedArray;

        public Task1()
        {
            taskName = "v19. w05, task 1";
            menu = new Menu(this);
        }

        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(menu.PrintMainMenu, menu.ActionFromMainMenu);
        }

        public void CreateArray(IntArrayUtils.createElementFunction makeFunction)
        {
            array = IntArrayUtils.CreateArray(makeFunction);
        }

        public void PrintArray()
        {
            Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(array)}");
        }

        /// <summary>
        /// Add item number K
        /// </summary>
        public void AddElem()
        {
            int kIndexn = Utils.ReadInt($"index of K element");
            if (kIndexn < 0 || kIndexn > array.Length)
            {
                throw new ArgumentException($"index of K must be beenwen 0 and {array.Length}");
            }
            int kValue = Utils.ReadInt($"value of K element");
            int[] newArray = new int[array.Length + 1];
            for (int i = 0, j = 0; i < array.Length + 1; i++)
            {
                if (i == kIndexn)
                {
                    newArray[i] = kValue;
                }
                else
                {
                    newArray[i] = array[j];
                    j++;
                }
            }
            array = newArray;
            Utils.PrintLnText($"UpdateArray successful: {IntArrayUtils.PrintArray(array)}");
        }

        public void CreateMatrix(IntArrayUtils.createElementFunction makeFunction)
        {
            matrix = IntArrayUtils.CreateMatrixArray(makeFunction);
        }

        public void PrintMatrix()
        {
            Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(matrix)}");
        }

        /// <summary>
        /// Delete the row containing the highest matrix element
        /// </summary>
        public void DeleteRow()
        {
            int maxElement = 0;
            int maxRowIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRowIndex = i;
                    }
                }
            }
            Utils.PrintLnText($"max element(first) = {maxElement}, and its row index= {maxRowIndex}");
            int[,] matrixNew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            for (int i = 0, newi = 0; i < matrix.GetLength(0); i++)
            {
                if (i == maxRowIndex)
                {
                    continue;
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixNew[newi, j] = matrix[i, j];
                }
                newi++;
            }
            matrix = matrixNew;
            Utils.PrintLnText($"UpdateArray successful: {IntArrayUtils.PrintArray(matrix)}");
        }

        public void CreateRaggedArray(IntArrayUtils.createElementFunction makeFunction)
        {
            raggedArray = IntArrayUtils.CreateRaggedArray(makeFunction);
        }

        public void PrintRaggedArray()
        {
            Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(raggedArray)}"); ;
        }

        /// <summary>
        /// Add a line to the beginning of the array
        /// </summary>
        public void AddRowToBeginning()
        {
            int[][] newRaggedArray = new int[raggedArray.Length + 1][];
            newRaggedArray[0] = IntArrayUtils.CreateArray(Utils.intArrayUtils.ElementFromRandom);
            for (int i = 0; i < raggedArray.Length; i++)
            {
                newRaggedArray[i + 1] = raggedArray[i];
            }
            raggedArray = newRaggedArray;
            Utils.PrintLnText($"UpdateArray successful: {IntArrayUtils.PrintArray(raggedArray)}");
        }
    }
}
