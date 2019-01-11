using System;
using System.Collections.Generic;


namespace LaboratoryWork.works.work07
{
    class AVLTree<T> : Tree<T> where T : IComparable
    {
        public void Create(UniArrayUtils<T>.createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number of list elements");
            if (n < 0)
            {
                Utils.PrintLnErrorText($"number of list elements must be > 0;");
            }
            CreateTree(n, makeFunction);
            Utils.PrintLnText("CreateTree successful:");
            PrintTree();
        }

        public void CreateTree(int n, UniArrayUtils<T>.createElementFunction makeFunction)
        {
            root = null;
            for (int i = 0; i < n; i++)
            {
                Add(makeFunction($"[{i}]"));
            }
        }

        public void Add(T item)
        {
            Nod<T> element = new Nod<T>(item);
            if (root == null)
            {
                root = element;
            }
            else
            {
                root = RecursiveInsert(root, element);
            }
        }

        private Nod<T> RecursiveInsert(Nod<T> current, Nod<T> n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            if (compare(n.value, current.value) < 0)
            {
                current.prew = RecursiveInsert(current.prew, n);
                return BalanceTree(current);
            }
            if (compare(n.value, current.value) > 0)
            {
                current.next = RecursiveInsert(current.next, n);
                return BalanceTree(current);
            }
            return current;
        }

        private Nod<T> BalanceTree(Nod<T> current)
        {
            int bFactor = BalanceFactor(current);
            if (bFactor > 1)
            {
                if (BalanceFactor(current.prew) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (bFactor < -1)
            {
                if (BalanceFactor(current.next) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }

        private int BalanceFactor(Nod<T> current)
        {
            int l = GetHeight(current.prew);
            int r = GetHeight(current.next);
            return l - r;
        }

        private Nod<T> RotateRR(Nod<T> parent)
        {
            Nod<T> pivot = parent.next;
            parent.next = pivot.prew;
            pivot.prew = parent;
            return pivot;
        }

        private Nod<T> RotateLL(Nod<T> parent)
        {
            Nod<T> pivot = parent.prew;
            parent.prew = pivot.next;
            pivot.next = parent;
            return pivot;
        }

        private Nod<T> RotateLR(Nod<T> parent)
        {
            Nod<T> pivot = parent.prew;
            parent.prew = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Nod<T> RotateRL(Nod<T> parent)
        {
            Nod<T> pivot = parent.next;
            parent.next = RotateLL(pivot);
            return RotateRR(parent);
        }

        public void ConverToSearchTreeAndPrint()
        {
            SearchTree<T> searchTree = new SearchTree<T>();
            List<T> elements = new List<T>();
            AddToList(root, elements);
            //elements.Sort();
            foreach (T element in elements)
            {
                searchTree.Add(element);
            }
            searchTree.PrintTree();
        }

    }
}
