using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            for (a = 0; a <= 9; a++)
            {
                for (b = a + 1; b <= 9; b++)
                {
                    Console.Write(a.ToString() + b.ToString());
                    if (a == 8 && b == 9)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}