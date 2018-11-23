using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works
{
    abstract class ATask
    {
        protected String taskName;

        public void runTask()
        {
            Console.Clear();
            printTasckName();
            executeTasck();
            Console.ReadKey();
        }

        protected abstract void executeTasck();

        public void printTasckName()
        {
            Utils.PrintLnText(taskName);
        }

    }
}
