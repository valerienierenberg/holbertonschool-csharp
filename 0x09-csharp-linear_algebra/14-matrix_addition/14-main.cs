using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrixOne2d =  { { 1, 2 }, { 3, 4 } };
        double[,] matrixTwo2d =  { { 5, 6 }, { 7, 8 } };
        double[,] matrixOne3d =  { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
        double[,] matrixTwo3d = { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
        double[,] res2d;
        double[,] res3d;

        res2d = MatrixMath.Add(matrixOne2d, matrixTwo2d);
        res3d = MatrixMath.Add(matrixOne3d, matrixTwo3d);

        for (int i = 0; i < res2d.GetLength(0); i++)
        {
            for (int j = 0; j < res2d.GetLength(1); j++)
            {
                Console.Write(res2d[i, j]);
                if (j != res2d.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < res3d.GetLength(0); i++)
        {
            for (int j = 0; j < res3d.GetLength(1); j++)
            {
                Console.Write(res3d[i, j]);
                if (j != res3d.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

    }
}
