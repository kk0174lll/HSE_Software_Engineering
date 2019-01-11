using System;
using System.Text;

namespace LaboratoryWork
{
    class BiDirList<T> : OneDirList<T>
    {


        protected override void Push(T item)
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
                element.prew = lastElement;
                lastElement = element;
            }
            count++;
        }

        public override void Add(int index, T item)
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
            if (index == 0)
            {
                element.next = firsElement;
                firsElement.prew = element;
                firsElement = element;
                count++;
                return;
            }
            var prevElement = GetByIndex(index - 1);
            var nextElement = prevElement.next;
            prevElement.next = element;
            element.prew = prevElement;
            element.next = nextElement;
            nextElement.prew = element;
            count++;
        }

        public override void Remove(int index)
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
                firsElement.prew = null;
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
            var nextElement = deleted.next;
            prevElement.next = nextElement;
            nextElement.prew = prevElement;
            count--;
        }

        public String PrintInverted()
        {
            var currElement = lastElement;
            StringBuilder sb = new StringBuilder();
            while (currElement != null)
            {
                sb.Append($"{currElement.value} ");
                currElement = currElement.prew;

            }
            return sb.ToString();
        }

    }
}
