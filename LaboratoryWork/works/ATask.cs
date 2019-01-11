using LaboratoryWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork.works
{
    abstract class ATask
    {
        protected String taskName;

        public void runTask()
        {
            Console.Clear();
            printTasckName();
            executeTasck();
            Utils.PrintText("Press any key to exit from Task");
            Console.ReadKey();
        }

        protected abstract void executeTasck();

        public void printTasckName()
        {
            Utils.PrintLnText(taskName);
        }
        public string getTasckName()
        {
            return taskName;
        }
    }
}
