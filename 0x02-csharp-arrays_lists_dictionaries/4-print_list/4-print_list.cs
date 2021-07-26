using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        List<int> listy = new List<int>();  // size inside these parens??
        for (int i = 0; i < size; i++)
        {
            listy.Add(i);
            Console.Write(i);
            if (i == size - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
        return (listy);
    }
}