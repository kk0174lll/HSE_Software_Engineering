using System;


namespace LaboratoryWork.works.work07
{
    class Task1 : ATask
    {
        OneDirList<int> list = new OneDirList<int>();

        public Task1()
        {
            taskName = "v19. w07, task 1";
        }

        /// <summary>
        /// unidirectional list
        /// </summary>
        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(PrintMenu, ActionFromMenu);
        }

        /// <summary>
        /// Remove from list the first element with an even information field.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private void DeleteFromList()
        {
            if (list == null || list.length == 0)
            {
                throw new ArgumentException("list is empty");
            }
            int index = 0;
            int evenIndex = -1;
            int deletedValue = 0;
            foreach (int value in list)
            {
                if (value % 2 == 0)
                {
                    deletedValue = value;
                    evenIndex = index;
                    break;
                }
                index++;
            }
            if (evenIndex == -1)
            {
                Utils.PrintLnText("list hasn't even element");
                return;
            }
            list.Remove(evenIndex);
            Utils.PrintLnText($"DeleteFromList successful; deleted element = {deletedValue}; index= {evenIndex}");

        }

        private void DeleteByIndex()
        {
            int index = Utils.ReadInt($"index for delete");
            list.Remove(index);
        }

        private void AddByIndex()
        {
            int index = Utils.ReadInt($"index for add");
            int value = Utils.ReadInt($"value for add");
            list.Add(index, value);
        }

        private void PrintMenu()
        {
            Utils.PrintLnText($" 1 - manual create list");
            Utils.PrintLnText($" 2 - random create list");
            Utils.PrintLnText($" 3 - print list");
            Utils.PrintLnText($" 4 - action for list");
            Utils.PrintLnText($" 5 - delete by index");
            Utils.PrintLnText($" 6 - add by index");
            Utils.PrintLnText($" 0 - exit");
        }

        private void ActionFromMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: list.Create(Utils.intArrayUtils.ElementFromHand); break;
                case 2: list.Create(Utils.intArrayUtils.ElementFromRandom); break;
                case 3: Utils.PrintLnText($"List: {OneDirList<int>.PrintList(list)}"); break;
                case 4: DeleteFromList(); break;
                case 5: DeleteByIndex(); break;
                case 6: AddByIndex(); break;
                case 0: exit = true; break;
            }
        }
    }
}
