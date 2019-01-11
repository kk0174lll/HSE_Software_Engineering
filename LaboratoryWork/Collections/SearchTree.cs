using System;


namespace LaboratoryWork
{
    class SearchTree<T> : Tree<T> where T : IComparable
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

        public void Add(T value)
        {
            if (root == null)
            {
                root = new Nod<T>(value);
                return;
            }
            Nod<T> p = root;
            Nod<T> r = null;

            while (p != null)
            {
                r = p;
                if (compare(value, p.value) == 0)
                {
                    return;
                }
                else
                {
                    if (compare(value, p.value) < 0)
                    {
                        p = p.prew;
                    }
                    else
                    {
                        p = p.next;
                    }
                }

            }

            Nod<T> newPoint = new Nod<T>(value);
            if (compare(value, r.value) < 0)
            {
                r.prew = newPoint;
            }
            else
            {
                r.next = newPoint;
            }

        }
    }
}
