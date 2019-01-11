

using LaboratoryWork1.works.work07;
using System;
using System.Collections.Generic;

namespace LaboratoryWork.works.work07
{
    class Tree<T> where T : IComparable
    {
        protected Nod<T> root;


        public void PrintTree()
        {
            BTreePrinter<T>.Print(root, 0, 5);
        }

        public int GetHeight()
        {
            return GetHeight(root);
        }

        protected int GetHeight(Nod<T> current)
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.prew);
                int r = GetHeight(current.next);
                int m = l > r ? l : r;
                height = m + 1;
            }
            return height;
        }

        protected int compare(T v1, T v2)
        {
            return Comparer<T>.Default.Compare(v1, v2);
        }



        protected void AddToList(Nod<T> nod, List<T> list)
        {

            if (nod != null)
            {
                list.Add(nod.value);
                AddToList(nod.prew, list);
                AddToList(nod.next, list);
            }
        }

        

    }
}
