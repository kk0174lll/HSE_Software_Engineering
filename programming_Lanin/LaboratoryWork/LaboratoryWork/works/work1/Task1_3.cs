using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work1
{
    class Task1_3 : ATask
    {
        public Task1_3()
        {
            taskName = "v19. task 1. 3)";
        }
        static String calculate(int n, int m)
        {
            return $"n={n} m={m} --m>++n = {--m > ++n}";
        }

        protected override void executeTasck()
        {
            int n, m;
            n = Utils.readInt("n");
            m = Utils.readInt("m");
            Utils.printText($"{calculate(n, m)}", true, ETextType.NORMAL);

        }
    }
}
