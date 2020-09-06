using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class SimpleStack<T> : SimpleListProject.SimpleList<T> where T : IComparable
    {
        public void Push(T value) =>
            Add(value);

        public T Pop()
        {
            var ret = last;

            if (Count - 2 >= 0)
            {
                var secondToLast = GetItem(Count - 2);
                secondToLast.next = null;
                last = secondToLast;
            }

            Count--;

            return ret.data;
        }
    }
}
