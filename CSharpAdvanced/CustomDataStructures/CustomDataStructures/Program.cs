using System;
using System.Collections.Generic;
using System.Threading.Channels;
using CustomDataStructures;

CustomList list = new CustomList();

for (int i = 1; i <= 10; i++)
{
    list.Add(i);
}

list.InsertAt(2, 88);

CustomStack stack = new CustomStack();

stack.Push(1);
stack.Push(2);
stack.Push(3);


stack.ForEach(i => Console.Write(i + " "));

CustomQueue queue = new CustomQueue();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

queue.Peek();

queue.Dequeue();

Console.WriteLine();
queue.ForEach(i => Console.Write(i + " "));