using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public void Push(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int lastEl = items[Count - 1];
            Count--;

            if (Count <= items.Length / 4)
            {
                int[] copy = new int[Count * 2];

                for (int i = 0; i < Count; i++)
                {
                    copy[i] = items[i];
                }

                items = copy;
            }

            return lastEl;

        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            return items[Count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                int currItem = items[i];

                action(currItem);
            }
        }
        private void Resize()
        {
            int[] copy = new int[Count * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
