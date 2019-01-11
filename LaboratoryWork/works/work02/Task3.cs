using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works.work02
{
    class Task3 : ATask
    {
        public Task3()
        {
            taskName = "v19. w02, task 3";
        }
        /// <summary>
        /// P = a*(a+1)*...*(a+n-1).
        /// </summary>
        protected override void executeTasck()
        {
            int a;
            int n;
            int p = 1;
            n = Utils.ReadInt("n");
            a = Utils.ReadInt("a");
            for (int i = 0; i < n; i++)
            {
                Utils.PrintText($"({a} + {i})");
                p *= a + i;
            }
            Utils.PrintLnText($" = {p}");
        }
    }
}
