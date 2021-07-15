using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();
        for (int i = size - 1; i >= 0; i--)
        {
            newList.AddFirst(i);
        }
        foreach (int value in newList)
        {
            Console.WriteLine(value.ToString());
        }
        return newList;
    }
}
