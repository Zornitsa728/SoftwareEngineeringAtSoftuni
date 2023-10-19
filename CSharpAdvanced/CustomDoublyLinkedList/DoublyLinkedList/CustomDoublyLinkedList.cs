using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        private class ListNode
        {
            public ListNode(T value)
            {
                Value = value;
            }

            public ListNode NextNode { get; set; }

            public ListNode PreviousNode { get; set; }
            public T Value { get; set; }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T nodeValue)
        {
            ListNode newNode = new (nodeValue);

            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.NextNode = head;
                head.PreviousNode = newNode;
                head = newNode;
            }

            this.Count++;
        }
        public void AddLast(T nodeValue)
        {
            ListNode newNode = new (nodeValue);

            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.PreviousNode = tail;
                tail.NextNode = newNode;
                tail = newNode;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T removedElement = head.Value;

            ListNode newHead = head.NextNode;

            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                newHead.PreviousNode = null;
                head = newHead;
            }

            Count--;

            return removedElement;
        }

        public T RemoveLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T removedElement = tail.Value;

            ListNode newTail = tail.PreviousNode;

            if (Count == 1)
            {
                tail = head = null;
            }
            else
            {
                newTail.NextNode = null;
                tail = newTail;
            }

            Count--;

            return removedElement;
        }

        public void ForEach(Action<T> action)
        {
            ListNode currNode = head;

            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            var currNode = head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = currNode.Value;
                currNode = currNode.NextNode;
            }

            return array;
        }
    }
}
