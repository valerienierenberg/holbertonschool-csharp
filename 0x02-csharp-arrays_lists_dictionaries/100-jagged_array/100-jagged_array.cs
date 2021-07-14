using System;
using System.Collections.Generic;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagArray = new int[3][];
            jagArray[0] = new int[] { 0, 1, 2, 3 };
            jagArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            jagArray[2] = new int[] { 0, 1 };
            for (int row = 0; row < jagArray.Length; row++)
            {
                for (int col = 0; col < jagArray[row].Length; col++)
                {
                    if (col == jagArray[row].Length - 1)
                    {
                        Console.WriteLine(jagArray[row][col]);
                    }
                    else
                    {
                        Console.Write("{0} ", jagArray[row][col]);
                    }
                }
            }
        }
    }
}
