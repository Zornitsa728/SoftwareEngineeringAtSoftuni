using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;

        private const int firstElIndex = 0;

        private int[] items;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public void Enqueue(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public int Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty");
            }

            int firstEl = items[firstElIndex];

            if (Count <= items.Length / 4)
            {
                int[] copy = new int[Count * 2];

                for (int i = 0; i < Count; i++)
                {
                    copy[i] = items[i];
                }

                items = copy;
            }

            ShiftLeft();
            Count--;

            return firstEl;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty");
            }

            return items[firstElIndex];
        }

        public void Clear()
        {
            items = new int[InitialCapacity];

            Count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
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

        private void ShiftLeft()
        {
            for (int i = firstElIndex; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[Count - 1] = default;
        }
    }
}
