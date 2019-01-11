using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works.work02
{
    class Task2 : ATask
    {
        public Task2()
        {
            taskName = "v19. w02, task 2";
        }
        /// <summary>
        /// Дана последовательность целых чисел, за которой следует 0. Найти номер
        /// максимального элемента в этой последовательности.
        /// </summary>
        protected override void executeTasck()
        {
            int i = 0, n = 0;
            int indexOfMax = 0;
            int maxElement = 0;
            Utils.PrintLnText("Признаком окончания последовательности является 0.");
            do
            {
                n = Utils.ReadInt($"n_{i}");
                if (n > maxElement)
                {
                    maxElement = n;
                    indexOfMax = i;
                }
                i++;
            } while (n != 0);
            Utils.PrintLnText($"Номер максимального элемента в этой последовательности = {indexOfMax}");
        }
    }
}
