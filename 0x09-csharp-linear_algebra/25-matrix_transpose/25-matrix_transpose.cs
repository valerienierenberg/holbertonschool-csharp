using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] newMatrix = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                newMatrix[i, j] = matrix[j, i];
            }
        }
        return newMatrix;
    }
}
