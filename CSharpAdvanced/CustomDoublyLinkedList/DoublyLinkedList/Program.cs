
namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddFirst(0);

            int[] ints = doublyLinkedList.ToArray();

        }
    }
}