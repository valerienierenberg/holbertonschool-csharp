using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] newMatrixDefault = new double[,] {{}};
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[j, i];
            }
        }
        return newMatrix;
    }
}
