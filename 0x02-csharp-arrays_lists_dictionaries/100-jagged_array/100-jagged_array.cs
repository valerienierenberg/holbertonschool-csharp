using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray3 =
            {
                new int[] { 0, 1, 2, 3 },
                new int[] { 0, 1, 2, 3, 4, 5, 6 },
                new int[] { 0, 1 }
            };
            for (int i = 0; i < jaggedArray3.GetLength(0); i++)
            {
                foreach (int x in jaggedArray3[i])
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
