using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrixOne2d =  { { 1, 2 }, { 3, 4 } };
        double[,] matrixOne3d =  { { -13, 10, 8 }, { 2, 0, 14 }, { -4, -5, 2 } };
        double scalar = 4;
        double[,] res2d;
        double[,] res3d;

        res2d = MatrixMath.MultiplyScalar(matrixOne2d, scalar);
        res3d = MatrixMath.MultiplyScalar(matrixOne3d, scalar);

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
