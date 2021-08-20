using System;

///<summary>Matrix Math class</summary>
class MatrixMath
{
    ///<summary>Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] newMatrix = new double[2, 2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
        {
            return newMatrixDefault;
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
              for (int k = 0; j < 2; j++)  
                {
                    newMatrix[i, j] = Math.Round(newMatrix[i, j] + (matrix[i, k] * rotate[k, j]), 2);
                }
            }
        }
        return newMatrix;
    }
}
