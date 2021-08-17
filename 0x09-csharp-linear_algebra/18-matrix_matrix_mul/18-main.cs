using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrixOne =  { { 1, 2 }, { 3, 4 } };
        double[,] matrixTwo =  { { 5, 6 }, { 2, 2 } };
        double[,] resMatrix;

        resMatrix = MatrixMath.Multiply(matrixOne, matrixTwo);

        for (int i = 0; i < resMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resMatrix.GetLength(1); j++)
            {
                Console.Write(resMatrix[i, j]);
                if (j != resMatrix.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
