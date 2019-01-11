using System;


namespace LaboratoryWork.works.work07
{
    class Task3 : ATask
    {

        AVLTree<char> avlTree = new AVLTree<char>();
        SearchTree<char> searchTree = new SearchTree<char>();

        public Task3()
        {
            taskName = "v19. w07, task 3";

        }

        /// <summary>
        /// Tree
        /// </summary>
        protected override void executeTasck()
        {
            MenuUtils.MakeMenu(PrintMenu, ActionFromMenu);
        }

        /// <summary>
        /// Find the height of the tree.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private void GetHeight()
        {
            Utils.PrintLnText($"Height of tree: {avlTree.GetHeight()}");
        }


        private void AddToAvlTree()
        {
            char value = Utils.ReadChar($"value for add");
            avlTree.Add(value);
        }

        private void AddToSearchTree()
        {
            char value = Utils.ReadChar($"value for add");
            searchTree.Add(value);
        }

        private void PrintMenu()
        {
            Utils.PrintLnText($" 1 - manual create AVL tree");
            Utils.PrintLnText($" 2 - random create AVL tree");
            Utils.PrintLnText($" 3 - print AVL tree");
            Utils.PrintLnText($" 4 - get height AVL tree");
            Utils.PrintLnText($" 5 - add element to AVL tree");
            Utils.PrintLnText($" 6 - conver to AVL tree to search tree and print");
            Utils.PrintLnText($" 7 - manual create search tree");
            Utils.PrintLnText($" 8 - random create search tree");
            Utils.PrintLnText($" 9 - print search tree");
            Utils.PrintLnText($" 10 - add element to search tree");
            Utils.PrintLnText($" 0 - exit");
        }

        private void ActionFromMenu(int action, ref bool exit)
        {
            switch (action)
            {
                case 1: avlTree.Create(Utils.charArrayUtils.ElementFromHand); break;
                case 2: avlTree.Create(Utils.charArrayUtils.ElementFromRandom); break;
                case 3: avlTree.PrintTree(); break;
                case 4: GetHeight(); break;
                case 5: AddToAvlTree(); break;
                case 6: avlTree.ConverToSearchTreeAndPrint(); break;
                case 7: searchTree.Create(Utils.charArrayUtils.ElementFromHand); break;
                case 8: searchTree.Create(Utils.charArrayUtils.ElementFromRandom); break;
                case 9: searchTree.PrintTree(); break;
                case 10: AddToSearchTree(); break;
                case 0: exit = true; break;
            }
        }


    }
}
