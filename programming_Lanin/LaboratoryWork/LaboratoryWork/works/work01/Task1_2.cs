using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work01
{
    class Task1_2 : ATask
    {
        public Task1_2()
        {
            taskName = "v19. task 1. 2)";
        }
        static String calculate(int n, int m)
        {
            return $"n={n} m={m} ++m<n-- = {++m < n--}";
        }

        protected override void executeTasck()
        {
            int n, m;
            n = Utils.ReadInt("n");
            m = Utils.ReadInt("m");
            Utils.PrintLnText($"{calculate(n, m)}");

        }
    }
}
