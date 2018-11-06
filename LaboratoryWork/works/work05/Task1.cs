using LaboratoryWork;
using LaboratoryWork1.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1.works.work05
{
    class Task1 : ATask, IExecutor
    {
        private Menu menu;

        private int[] array;

        public Task1()
        {            
            taskName = "v19. w05, task 1";
            menu = new Menu(this);
        }

        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(menu.PrintMainMenu, menu.ActionFromMainMenu);
        }

        public void CreateArray(ArrayUtils.createElementFunction makeFunction)
        {
            array = ArrayUtils.CreateArray(makeFunction);
        }

        public void PrintArray()
        {
            Utils.PrintLnText($"Array: {ArrayUtils.PrintArray(array)}");
        }

        public void AddElem()
        {
            throw new NotImplementedException();
        }
    }
}
