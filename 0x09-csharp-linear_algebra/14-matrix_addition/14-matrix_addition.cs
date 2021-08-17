using System;

///<summary>Matrix Math Class</summary>
class MatrixMath
{
    ///<summary>Method that adds two matrices and returns the resulting matrix</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] newMatrix;

        // .GetLength(0) for checking row length and .GetLength(1) for checking column height
        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            newMatrix = new double[2, 2];
        }

        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            newMatrix = new double[3, 3];
        }
        else
        {
            return newMatrixDefault;
        }
        for (int i = 0; i < (matrix1.GetLength(0)); i++)
        {
            for (int j = 0; j < (matrix1.GetLength(1)); j++)
            {
                newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return newMatrix;
    }
}

