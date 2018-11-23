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

        const int maxElement = 100;
        const int arrayLength = 20;
        public Task1()
        {
            taskName = "v19. class room work 01, task 1";
        }

        /// <summary>
        /// Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами.
        /// </summary>
        protected override void executeTasck()
        {
            long mill = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            solution1(true);
            long timeExecute = DateTimeOffset.Now.ToUnixTimeMilliseconds() - mill;
            Utils.PrintLnText($"timeExecute: {timeExecute}");
            mill = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            solution2(true);
            timeExecute = DateTimeOffset.Now.ToUnixTimeMilliseconds() - mill;
            Utils.PrintLnText($"timeExecute: {timeExecute}");
            testTime();
        }

        private void testTime()
        {
            long avg1 = 0;
            long avg2 = 0;
            int countRun = 100000;
            long mill, timeExecute;
            for (int i = 0; i < countRun; i++)
            {
                mill = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                solution1(false);
                timeExecute = DateTimeOffset.Now.ToUnixTimeMilliseconds() - mill;
                avg1 += timeExecute;
                mill = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                solution2(false);
                timeExecute = DateTimeOffset.Now.ToUnixTimeMilliseconds() - mill;
                avg2 += timeExecute;
            }
            Utils.PrintLnText($"avg execute time solution1: {(double)avg1 / countRun}");
            Utils.PrintLnText($"avg execute time solution2: {(double)avg2 / countRun}");
        }

        private void solution1(bool print)
        {
            int newElement = Utils.random.Next(0, maxElement);
            int[] array = new int[arrayLength];
            int currenIndex = 1;
            array[0] = newElement;
            do
            {
                newElement = Utils.random.Next(0, maxElement);
                if (!IntArrayUtils.FindValue(array, newElement))
                {
                    array[currenIndex] = newElement;
                    currenIndex++;
                }
            } while (currenIndex < arrayLength);
            if (print)
            {
                Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(array)}");
            }
        }

        private void solution2(bool print)
        {
            bool[] boolArray = new bool[maxElement];
            int[] array = new int[arrayLength];
            int currenIndex = 0;
            int newElement;
            do
            {
                newElement = Utils.random.Next(0, maxElement);
                if (!boolArray[newElement])
                {
                    array[currenIndex] = newElement;
                    boolArray[newElement] = true;
                    currenIndex++;
                }
            } while (currenIndex < arrayLength);
            if (print)
            {
                Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(array)}");
            }

        }
    }
}
