using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work05
{
    class Task1 : ATask
    {
        
        public Task1()
        {
            taskName = "v19. w05, task 1";
        }

        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(PrintMainMenu, ActionFromMainMenu);
        }

        private void PrintMainMenu()
        {
            Utils.PrintLnText(" 1 - Работа с одномерными массивами");
            Utils.PrintLnText(" 2 - Работа с двумерными массивами");
            Utils.PrintLnText(" 3 - Работа с рваными массивами");
            Utils.PrintLnText(" 0 - Выход");
        }

        private bool ActionFromMainMenu()
        {
            bool exit = false;
            int action = Utils.ReadInt("number of action");
            switch (action)
            {
                case 1: MenuUtils.MakeMenu(PrintArrayMenu, ActionFromMainMenu); break;
                case 2: MenuUtils.MakeMenu(PrintMatrixMenu, ActionFromMainMenu); break;
                case 3: MenuUtils.MakeMenu(PrintRaggedMenu, ActionFromMainMenu); break;                
                case 0: exit = true; break;
            }
            return exit;
        }

        private void PrintArrayMenu()
        {
            Utils.PrintLnText($" 1 - {ArrayUtils.HAND_CREATE_MSG}");
            Utils.PrintLnText($" 2 - Работа с двумерными массивами");
            Utils.PrintLnText($" 3 - Работа с рваными массивами");
            Utils.PrintLnText($" 0 - Выход");
        }

        private void PrintMatrixMenu()
        {
            Utils.PrintLnText($" 1 - {ArrayUtils.HAND_CREATE_MSG}");
            Utils.PrintLnText($" 2 - Работа с двумерными массивами");
            Utils.PrintLnText($" 3 - Работа с рваными массивами");
            Utils.PrintLnText($" 0 - Выход");
        }

        private void PrintRaggedMenu()
        {
            Utils.PrintLnText($" 1 - {ArrayUtils.HAND_CREATE_MSG}");
            Utils.PrintLnText($" 2 - Работа с двумерными массивами");
            Utils.PrintLnText($" 3 - Работа с рваными массивами");
            Utils.PrintLnText($" 0 - Выход");
        }

    }
}
