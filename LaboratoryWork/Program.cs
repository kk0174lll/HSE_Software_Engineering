using LaboratoryWork.works;
using System;
using System.Collections.Generic;

namespace LaboratoryWork
{
    /*19. Козлов Кирилл */
    class Program
    {

        static void Main(string[] args)
        {
            List<ATask> taskList = fillTaskList();
            MenuUtils.MakeMenu(() =>
            {
                int i = 1;
                Console.Clear();
                taskList.ForEach(task => Utils.PrintLnText($"{i++} - {task.getTasckName()}"));
                Utils.PrintLnText($" 0 - exit");
            }, (int action, ref bool exit) =>
            {
                if (action == 0)
                {
                    exit = true;
                }
                else
                {
                    taskList[--action].runTask();
                }
            });
        }

        private static List<ATask> fillTaskList()
        {
            List<ATask> taskList = new List<ATask>();
            taskList.Add(new LaboratoryWork.works.work01.Task1_1());
            taskList.Add(new LaboratoryWork.works.work01.Task1_2());
            taskList.Add(new LaboratoryWork.works.work01.Task1_3());
            taskList.Add(new LaboratoryWork.works.work01.Task1_4());
            taskList.Add(new LaboratoryWork.works.work01.Task2_1());
            taskList.Add(new LaboratoryWork.works.work01.Task3_1());
            taskList.Add(new LaboratoryWork.works.work02.Task1());
            taskList.Add(new LaboratoryWork.works.work02.Task2());
            taskList.Add(new LaboratoryWork.works.work02.Task3());
            taskList.Add(new LaboratoryWork.works.work03.Task1());
            taskList.Add(new LaboratoryWork.works.work04.Task1());
            taskList.Add(new LaboratoryWork.works.work05.Task1());
            taskList.Add(new LaboratoryWork.works.classroomWork01.Task1());
            taskList.Add(new LaboratoryWork.works.classroomWork01.Task2());
            taskList.Add(new LaboratoryWork.works.classroomWork01.Task3());
            taskList.Add(new LaboratoryWork.works.classroomWork01.Task4());
            taskList.Add(new LaboratoryWork.works.work06.Task1());
            taskList.Add(new LaboratoryWork.works.work06.Task2());
            taskList.Add(new LaboratoryWork.works.work07.Task1());
            taskList.Add(new LaboratoryWork.works.work07.Task2());
            taskList.Add(new LaboratoryWork.works.work07.Task3());
            return taskList;
        }


    }
}
