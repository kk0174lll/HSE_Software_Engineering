﻿using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works.work01
{
    class Task1_3 : ATask
    {
        public Task1_3()
        {
            taskName = "v19. w01, task 1. 3)";
        }
        static String calculate(int n, int m)
        {
            return $"n={n} m={m} --m>++n = {--m > ++n}";
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
