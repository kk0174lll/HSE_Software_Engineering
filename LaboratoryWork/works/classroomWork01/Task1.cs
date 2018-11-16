using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.classroomWork01
{
    class Task1 : ATask
    {
        public Task1()
        {
            taskName = "v19. class room work 01, task 1";
        }

        /// <summary>
        /// Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами.
        /// </summary>
        protected override void executeTasck()
        {
            Random random = new Random(0);
            int arrayLength = 20;
            int newElement = random.Next(0, 100);
            int[] array = new int[arrayLength];
            int currenIndex = 1;
            array[0] = newElement;
            do
            {
                newElement = random.Next(0, 100);
                if (!ArrayUtils.FindValue(array, newElement))
                {
                    array[currenIndex] = newElement;
                    currenIndex++;
                }
            } while (currenIndex < arrayLength);
            Utils.PrintLnText($"Array: {ArrayUtils.PrintArray(array)}");
        }
    }
}
