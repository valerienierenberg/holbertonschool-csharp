using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] twodim = new int [5,5] {{0,0,0,0,0}, {0,0,0,0,0}, {0,0,1,0,0}, {0,0,0,0,0}, {0,0,0,0,0}};
            int rowLength = twodim.GetLength(0);
            int colLength = twodim.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (j == colLength - 1)
                    {
                        Console.Write(string.Format("{0}", twodim[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", twodim[i, j]));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}