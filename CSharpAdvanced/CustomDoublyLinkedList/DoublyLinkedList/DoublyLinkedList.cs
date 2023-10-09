using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private int count;
        public Node Head {  get; set; }

        public Node Tail { get; set; }

        public void AddFirst(int nodeValue)
        {
            Node newNode = new Node(nodeValue);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            
            this.count++;
        }
        public void AddLast(int nodeValue)
        {
            Node newNode = new Node(nodeValue);

            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            
            this.count++;
        }

        public int RemoveFirst()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            int firstEl = Head.Value;

            Head = Head.Next;

            if (this.Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                this.Tail = null;
            }

            this.count--;
            return firstEl;
        }

        public int RemoveLast()
        {
            if(Tail == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            int lastEl = Tail.Value;

            Tail = Tail.Previous;

            if (this.Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                this.Head = null;
            }

            this.count--;
            return lastEl;
        }

        public void FоrEach(Action<int> action)
        {
            Node currNode = Head;

            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.count];
            int index = 0;
            var currNode = this.Head;

            while (currNode != null)
            {
                array[index++] = currNode.Value;
                currNode = currNode.Next;
            }

            return array;
        }
    }
}
