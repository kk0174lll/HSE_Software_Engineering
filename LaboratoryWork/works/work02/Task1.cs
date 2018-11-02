using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work02
{
    class Task1 : ATask
    {
        public Task1()
        {
            taskName = "v19. w02, task 1";
        }
        /// <summary>
        /// Дана последовательность из n целых чисел. Найти сумму четных элементов этой последовательности.
        /// </summary>
        protected override void executeTasck()
        {
            int n;
            int s = 0;
            n = Utils.ReadInt("n");
            for (int i = 0; i < n; i++)
            {
                int n_i = Utils.ReadInt($"n_{i}");
                if (n_i % 2 == 0)
                {
                    s += n_i;
                }
            }
            Utils.PrintLnText($"Сумму четных элементов = {s}");
        }
    }
}
