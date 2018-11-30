using LaboratoryWork1.works;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork
{
    /*19. Козлов Кирилл */
    class Program
    {

        static void Main(string[] args)
        {
            List<ATask> taskList = fillTaskList();
            bool exit = false;
            do
            {
                int i = 0;
                Console.Clear();
                foreach (ATask task in taskList)
                {
                    Utils.PrintLnText($"{i} - {task.getTasckName()}");
                    i++;
                }
                try
                {
                    int action = Utils.ReadInt("number of action");
                    if (action == 0)
                    {
                        exit = true;
                    }
                    else
                    {
                        taskList[action].runTask();
                    }
                }
                catch (Exception e)
                {
                    Utils.PrintLnErrorText($"something wrong ({e.Message}), try again");
                }
            } while (!exit);
        }

        private static List<ATask> fillTaskList() {
            List<ATask> taskList = new List<ATask>();
            taskList.Add(new LaboratoryWork1.works.work01.Task1_1());
            taskList.Add(new LaboratoryWork1.works.work01.Task1_2());
            taskList.Add(new LaboratoryWork1.works.work01.Task1_3());
            taskList.Add(new LaboratoryWork1.works.work01.Task1_4());
            taskList.Add(new LaboratoryWork1.works.work01.Task2_1());
            taskList.Add(new LaboratoryWork1.works.work01.Task3_1());
            taskList.Add(new LaboratoryWork1.works.work02.Task1());
            taskList.Add(new LaboratoryWork1.works.work02.Task2());
            taskList.Add(new LaboratoryWork1.works.work02.Task3());
            taskList.Add(new LaboratoryWork1.works.work03.Task1());
            taskList.Add(new LaboratoryWork1.works.work04.Task1());
            taskList.Add(new LaboratoryWork1.works.work05.Task1());
            taskList.Add(new LaboratoryWork1.works.classroomWork01.Task1());
            taskList.Add(new LaboratoryWork1.works.classroomWork01.Task2());
            taskList.Add(new LaboratoryWork1.works.classroomWork01.Task3());
            taskList.Add(new LaboratoryWork1.works.classroomWork01.Task4());
            taskList.Add(new LaboratoryWork1.works.work06.Task1());
            taskList.Add(new LaboratoryWork1.works.work06.Task2());
            return taskList;
        }


    }
}
