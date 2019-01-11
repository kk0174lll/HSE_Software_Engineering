using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works.work01
{
    class Task1_4 : ATask
    {
        public Task1_4()
        {
            taskName = "v19. w01, task 1. 4)";
        }
        static String calculate(int x)
        {
            double radians = Math.Pow(x, 2) / 57.29;
            double atan = Math.Atan(radians);
            //если пользователь вводит радианы
            //double atan = Math.Atan(Math.Pow(x,2));
            return $"x={x} 7arctg(x^2)= {7 * atan}";
        }

        protected override void executeTasck()
        {
            int x;
            x = Utils.ReadInt("x");
            Utils.PrintLnText($"{calculate(x)}");

        }
    }
}
