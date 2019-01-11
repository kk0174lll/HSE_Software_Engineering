using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork
{
    class OneDirList<T> : IEnumerable<T>, IEnumerator<T>
    {
        protected Nod<T> firsElement;
        protected Nod<T> currentElement;
        protected Nod<T> lastElement;
        protected int count;

        public int length { get { return count; } }

        public T Current => currentElement.value;

        object IEnumerator.Current => currentElement.value;

        protected virtual void Push(T item)
        {
            Nod<T> element = new Nod<T>(item);
            if (count == 0)
            {
                firsElement = element;
                lastElement = element;
            }
            else
            {
                lastElement.next = element;
                lastElement = element;
            }
            count++;
        }

        public virtual void Add(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentException($"incorect index");
            }
            if (count == 0 || index == count)
            {
                Push(item);
                return;
            }
            Nod<T> element = new Nod<T>(item);
            if (index == 0) {
                element.next = firsElement;
                firsElement = element;
                count++;
                return;
            }
            var prevElement = GetByIndex(index - 1);
            var nextElement = prevElement.next;            
            prevElement.next = element;
            element.next = nextElement;
            count++;
        }

        public Nod<T> GetByIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentException($"incorect index");
            }
            int currentIndex = 0;
            var element = firsElement;
            for (int i = 1; i <= index; i++)
            {
                element = element.next;
                currentIndex++;
            }
            return element;
        }

        public void Create(UniArrayUtils<T>.createElementFunction makeFunction)
        {
            int n = Utils.ReadInt($"number of list elements");
            if (n < 0)
            {
                Utils.PrintLnErrorText($"number of list elements must be > 0;");
            }
            CreateList(n, makeFunction);
            Utils.PrintLnText($"CreateList successful: {PrintList(this)}");
        }

        public void CreateList(int n, UniArrayUtils<T>.createElementFunction makeFunction)
        {
            firsElement = null;
            currentElement = null;
            count = 0;
            for (int i = 0; i < n; i++)
            {
                Push(makeFunction($"[{i}]"));
            }
        }

        public static string PrintList(IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T x in list)
            {
                sb.Append($"{x} ");
            }
            return sb.ToString();
        }


        public virtual void Remove(int index)
        {
            if (count == 0)
            {
                throw new ArgumentException($"list is empty");
            }
            if (index < 0 || index >= count)
            {
                throw new ArgumentException($"incorect index");
            }
            if (count == 1)
            {
                firsElement = null;
                currentElement = null;
                lastElement = null;
                count = 0;
                return;
            }
            if (index == 0)
            {
                firsElement = firsElement.next;
                count--;
                return;
            }
            if (index == count - 1)
            {
                var currentElement = GetByIndex(index - 1);
                currentElement.next = null;
                lastElement = currentElement;
                count--;
                return;
            }
            var prevElement = GetByIndex(index - 1);
            var deleted = prevElement.next;
            prevElement.next = deleted.next;
            count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            Nod<T> next;
            if (currentElement == null)
            {
                next = firsElement;
            }
            else
            {
                next = currentElement.next;
            }
            if (next == null)
            {
                Reset();
                return false;
            }
            else
            {
                currentElement = next;
                return true;
            }
        }

        public void Reset()
        {
            currentElement = null;
        }
    }
}
