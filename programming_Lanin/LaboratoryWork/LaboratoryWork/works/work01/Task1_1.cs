using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryWork;
using LaboratoryWork1.works;

namespace LaboratoryWork1.works.work01
{
    class Task1_1 : ATask
    {
        public Task1_1()
        {
            taskName = "v19. task 1. 1)";
        }

        static String calculate(int n, int m)
        {
            int result = (n++ / --m);
            return $"n={n} m={m} (n++/--m)++ = {result++}";
        }

        protected override void executeTasck()
        {
            int n, m;
            n = Utils.ReadInt("n");
            m = Utils.ReadInt("m");
            if (m - 1 == 0)
            {
                Utils.PrintLnText("Нельзя вычислить");
            }
            else
            {
                Utils.PrintLnText($"{calculate(n, m)}");
            }
        }


    }
}
