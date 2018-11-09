using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work05
{
    class Menu
    {
        private IExecutor executor;
        public Menu(IExecutor executor)
        {
            this.executor = executor;
        }
        public const string CREATE_MSG = "Создать массив";
        public const string PRINT_MSG = "Напечатать массив";
        public const string HAND_CREATE_MSG = "Создать массив вручную";
        public const string RANDOM_CREATE_MSG = "Создать массив с помощью генератора ДСЧ";

        public void PrintMainMenu()
        {
            Utils.PrintLnText(" 1 - Работа с одномерными массивами");
            Utils.PrintLnText(" 2 - Работа с двумерными массивами");
            Utils.PrintLnText(" 3 - Работа с рваными массивами");
            Utils.PrintLnText(" 0 - Выход");
        }

        public void ActionFromMainMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: MenuUtils.MakeMenu(PrintArrayMenu, ActionFromArrayMenu); break;
                case 2: MenuUtils.MakeMenu(PrintMatrixMenu, ActionFromMatrixMenu); break;
                case 3: MenuUtils.MakeMenu(PrintRaggedMenu, ActionFromRaggedMenu); break;
                case 0: exit = true; break;
            }
        }

        private void PrintArrayMenu()
        {
            Utils.PrintLnText($" 1 - {CREATE_MSG}");
            Utils.PrintLnText($" 2 - {PRINT_MSG}");
            Utils.PrintLnText($" 3 - Добавить элемент с номером К");
            Utils.PrintLnText($" 0 - Назад");
        }

        public void ActionFromArrayMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: MenuUtils.MakeMenu(PrintCreateArrayMenu, ActionFromCreateArrayMenu); break;
                case 2: executor.PrintArray(); break;
                case 3: executor.AddElem(); break;
                case 0: exit = true; break;
            }
        }

        private void PrintCreateArrayMenu()
        {
            Utils.PrintLnText($" 1 - {HAND_CREATE_MSG}");
            Utils.PrintLnText($" 2 - {RANDOM_CREATE_MSG}");
            Utils.PrintLnText($" 0 - Назад");
        }

        public void ActionFromCreateArrayMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: executor.CreateArray(ArrayUtils.ElementFromHand); break;
                case 2: executor.CreateArray(ArrayUtils.ElementFromRandom); break;
                case 0: exit = true; break;
            }
        }



        private void PrintMatrixMenu()
        {
            Utils.PrintLnText($" 1 - {CREATE_MSG}");
            Utils.PrintLnText($" 2 - {PRINT_MSG}");
            Utils.PrintLnText($" 3 - Удалить строку, в которой находится наибольший элемент матрицы");
            Utils.PrintLnText($" 0 - Назад");
        }

        public void ActionFromMatrixMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: MenuUtils.MakeMenu(PrintCreateArrayMenu, ActionFromCreateMatrixMenu); break;
                case 2: executor.PrintMatrix(); break;
                case 3: executor.DeleteRow(); break;
                case 0: exit = true; break;
            }
        }

        public void ActionFromCreateMatrixMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: executor.CreateMatrix(ArrayUtils.ElementFromHand); break;
                case 2: executor.CreateMatrix(ArrayUtils.ElementFromRandom); break;
                case 0: exit = true; break;
            }
        }

        private void PrintRaggedMenu()
        {
            Utils.PrintLnText($" 1 - {CREATE_MSG}");
            Utils.PrintLnText($" 2 - {PRINT_MSG}");
            Utils.PrintLnText($" 3 - Добавить строку в начало массива");
            Utils.PrintLnText($" 0 - Назад");
        }

        public void ActionFromRaggedMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: MenuUtils.MakeMenu(PrintCreateArrayMenu, ActionFromCreateRaggedMenu); break;
                case 2: executor.PrintRaggedArray(); break;
                case 3: executor.AddRowToBeginning(); break;
                case 0: exit = true; break;
            }
        }

        public void ActionFromCreateRaggedMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: executor.CreateRaggedArray(ArrayUtils.ElementFromHand); break;
                case 2: executor.CreateRaggedArray(ArrayUtils.ElementFromRandom); break;
                case 0: exit = true; break;
            }
        }
    }
}
