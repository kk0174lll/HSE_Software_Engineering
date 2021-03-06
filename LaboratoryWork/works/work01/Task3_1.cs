﻿using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works.work01
{
    class Task3_1 : ATask
    {

        public Task3_1()
        {
            taskName = "v19. w01, task 3";
        }       


        static String calculate(double a, double b)
        {
            Decimal step1 = (Decimal)Math.Pow(a + b, 2);
            Decimal step2 = (Decimal)Math.Pow(a, 2)+ 2 * (Decimal)a * (Decimal)b;
            Decimal step3 = (Decimal)Math.Pow(b, 2);
            Decimal result = (step1 - step2) / step3;
            return $"x={a} y={b} result = {result}";
        }

        protected override void executeTasck()
        {
            double a, b;
            a = Utils.ReadDouble("a");
            b = Utils.ReadDouble("b");
            if (a == 0)
            {
                Utils.PrintLnText("Нельзя вычислить");
            }
            else
            {
                Utils.PrintLnText($"{calculate(a, b)}");
            }
            
        }
    }
}
