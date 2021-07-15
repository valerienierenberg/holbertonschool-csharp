using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        if (aStack.Count == 0 || aStack == null)
        {
            Console.WriteLine("Stack is empty");
            break;
        }
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        if (aStack.Contains(search))
        {
            int indexOfSearch = aStack.ToArray().ToList().IndexOf(search);
            while (aStack.Count > indexOfSearch - 1)
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
