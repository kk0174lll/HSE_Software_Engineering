using System;

namespace LaboratoryWork.works.work07
{
    class Task2 : ATask
    {

        BiDirList<string> list = new BiDirList<string>();

        public Task2()
        {
            taskName = "v19. w07, task 2";

        }

        /// <summary>
        /// Bidirectional list
        /// </summary>
        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(PrintMenu, ActionFromMenu);
        }

        /// <summary>
        /// Add items with numbers 1, 3, 5, etc. to the list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private void AddToList()
        {
            if (list.length == 0)
            {
                throw new ArgumentException($"list is empty");
            }
            string value = Utils.ReadString($"value for add");
            int indexForInsert = 1;
            bool canInsert = true;
            do
            {
                list.Add(indexForInsert, value);
                indexForInsert += 2;
                if (indexForInsert > list.length)
                {
                    canInsert = false;
                }

            } while (canInsert);
        }

        private void DeleteByIndex()
        {
            int index = Utils.ReadInt($"index for delete");
            list.Remove(index);
        }

        private void AddByIndex()
        {
            int index = Utils.ReadInt($"index for add");
            string value = Utils.ReadString($"value for add");
            list.Add(index, value);
        }

        private void PrintMenu()
        {
            Utils.PrintLnText($" 1 - manual create list");
            Utils.PrintLnText($" 2 - print list");
            Utils.PrintLnText($" 3 - print inverted list");
            Utils.PrintLnText($" 4 - action for list");
            Utils.PrintLnText($" 5 - delete by index");
            Utils.PrintLnText($" 6 - add by index");
            Utils.PrintLnText($" 0 - exit");
        }

        private void ActionFromMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: list.Create((index) => { return Utils.ReadString(); }); break;
                case 2: Utils.PrintLnText($"List: {OneDirList<string>.PrintList(list)}"); break;
                case 3: Utils.PrintLnText($"List: {list.PrintInverted()}"); break;
                case 4: AddToList(); break;
                case 5: DeleteByIndex(); break;
                case 6: AddByIndex(); break;
                case 0: exit = true; break;
            }
        }


    }
}
