using System;

class MatrixMath
{
    ///<summary>Method that multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] newMatrix;

        // .GetLength(0) for checking row length and .GetLength(1) for checking column height
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            newMatrix = new double[2, 2];
        }

        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            newMatrix = new double[3, 3];
        }
        else
        {
            return newMatrixDefault;
        }
        for (int i = 0; i < (matrix.GetLength(0)); i++)
        {
            for (int j = 0; j < (matrix.GetLength(1)); j++)
            {
                newMatrix[i, j] = matrix[i, j] * scalar;
            }
        }
        return newMatrix;
    }
}
