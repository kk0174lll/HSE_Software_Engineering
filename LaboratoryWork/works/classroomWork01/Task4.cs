using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.classroomWork01
{
    class Task4 : ATask
    {
        public Task4()
        {
            taskName = "v19. classroom work 01, task 4";
        }

        /// <summary>
        /// Дан массив. Переписать его элементы в другой массив такого же размера следующим 
        /// образом: сначала должны идти все отрицательные элементы, а затем все остальные.
        /// Использовать только один проход по исходному массиву.
        /// </summary>
        protected override void executeTasck()
        {
            int[] array = IntArrayUtils.CreateArray((e) => { return Utils.random.Next(-50, 51); });
            int[] newArray = new int[array.Length];
            int leftPosition = 0;
            int rightPosition = array.Length - 1;

            foreach (int currentElement in array)
            {
                if (currentElement >= 0)
                {
                    newArray[rightPosition] = currentElement;
                    rightPosition--;
                }
                else
                {
                    newArray[leftPosition] = currentElement;
                    leftPosition++;
                }
            }
            Utils.PrintLnText($"Array: {IntArrayUtils.PrintArray(newArray)}");
        }
    }
}
