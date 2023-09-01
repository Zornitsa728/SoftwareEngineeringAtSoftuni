using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder text = new StringBuilder();
Stack<string> changes = new();

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArgs[0];

    if (cmd == "1")
    {
        string arg = cmdArgs[1];
        changes.Push(text.ToString());
        text.Append(arg);
    }
    else if (cmd == "2")
    {
        int arg = int.Parse(cmdArgs[1]);
        changes.Push(text.ToString());
        text.Remove(text.Length - arg, arg);
    }
    else if (cmd == "3")
    {
        int arg = int.Parse(cmdArgs[1]);
        Console.WriteLine(text.ToString().ElementAt(arg-1));
    }
    else if (cmd == "4")
    {
        string oldText = changes.Pop();
        text.Clear();
        text.Append(oldText);
    }
}
