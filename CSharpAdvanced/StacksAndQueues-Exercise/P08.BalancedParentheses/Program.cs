using System;
using System.Collections.Generic;
using System.Linq;

string input = Console.ReadLine();
Stack<char> parenthes = new Stack<char>();
int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (parenthes.Any())
    {
        char currSymbol = input[i];
        char previousSymbol = parenthes.Peek();

        if (previousSymbol == '(' && currSymbol == ')')
        {
            parenthes.Pop();
            continue;
        }
        else if (previousSymbol == '{' && currSymbol == '}')
        {
            parenthes.Pop();
            continue;
        }
        else if (previousSymbol == '[' && currSymbol == ']')
        {
            parenthes.Pop();
            continue;
        }
        else if (previousSymbol == ' ' && currSymbol == ' ')
        {
            parenthes.Pop();
            continue;
        }
    }

    parenthes.Push(input[i]);
}

Console.WriteLine(!parenthes.Any() ? "YES" : "NO");
