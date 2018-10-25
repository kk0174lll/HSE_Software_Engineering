using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryWork;
using LaboratoryWork1.works;

namespace LaboratoryWork1.works.work1
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
            n = Utils.readInt("n");
            m = Utils.readInt("m");
            if (m - 1 == 0)
            {
                Utils.printText("Нельзя вычислить", true, ETextType.NORMAL);
            }
            else
            {
                Utils.printText($"{calculate(n, m)}", true, ETextType.NORMAL);
            }
        }


    }
}
