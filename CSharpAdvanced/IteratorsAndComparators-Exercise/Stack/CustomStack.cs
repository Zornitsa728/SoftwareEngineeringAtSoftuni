using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitailCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            items = new T[InitailCapacity];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;

            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("No elements");
            }

            T lastEl = items[Count - 1];

            Count--;

            return lastEl;
        }
        private void Resize()
        {
            T[] newArray = new T[Count * 2];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
