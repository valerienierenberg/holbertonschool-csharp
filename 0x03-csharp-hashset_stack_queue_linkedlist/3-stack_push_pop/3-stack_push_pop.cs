using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        if (aStack.Contains(search))
        {
            int indexOfSearch = aStack.ToArray().ToList().IndexOf(search);
            // Console.WriteLine(indexOfSearch);
            while (aStack.Count > indexOfSearch - 1)
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}


// Print if aStack contains a given item search
//      Format: Stack contains <search>: <True / False>
// If aStack contains the given item search, remove all items up to and including search; otherwise, leave aStack as is
// You can use .Pop() only once
// Add a new given item newItem to aStack
// Return aStack
