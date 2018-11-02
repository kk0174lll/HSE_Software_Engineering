using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work03
{
    class Task1 : ATask
    {
        const decimal ep = 0.00000001m;
        const int n = 20;
        const double a = 0.1;
        const double b = 1;
        const double k = 10;

        public Task1()
        {
            taskName = "v19. w03, task 1";
        }

        protected override void executeTasck()
        {
            double y;
            decimal SN = 0, SE = 0;
            for (double x = a; x < b; x += (b - a) / k)
            {
                y = Math.Pow(Math.E, 2 * x);
                SN = CalcSN(x);
                SE = CalcSE(x);
                Utils.PrintLnText($"y = {y:0.000000}; SN = {SN:0.000000}; SE = {SE:0.000000}");
            }
        }

        private decimal CalcSN(double x)
        {
            long factorial = 1;
            decimal sn = 0;
            for (int i = 0; i < n; i++)
            {
                factorial = calcFact(factorial, i);
                sn += calcFormula(x, i, factorial);

            }
            return sn;
        }

        private decimal CalcSE(double x)
        {
            decimal sum = 0;
            decimal sumNext = 0;
            long factorial = 1;
            int i = 0;
            do
            {
                sum = sumNext;
                factorial = calcFact(factorial, i);
                sumNext += calcFormula(x, i, factorial);                
                i++;
            } while (sumNext - sum > ep);
            return sumNext;
        }

        /// <summary>
        /// S = 1 + 2x/1! + ... + (2x)^n/n!
        /// </summary>
        /// <param name="x">x=</param>
        /// <param name="i">n=</param>
        /// <param name="factorial"></param>
        /// <returns></returns>
        private decimal calcFormula(double x, int i, long factorial)
        {
            return (decimal)(Math.Pow(2 * x, i)) / factorial;
        }

        private long calcFact(long factorial, int i)
        {
            if (i == 0)
            {
                factorial = 1;
            }
            else
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
