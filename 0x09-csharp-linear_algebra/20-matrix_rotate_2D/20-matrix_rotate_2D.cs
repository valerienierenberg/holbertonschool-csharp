using System;

///<summary>Matrix Math class</summary>
class MatrixMath
{
    ///<summary>Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        double[,] newMatrix = new double[2, 2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double[,] default = new double[,] {{-1}};

        if (row != 2 || column != 2)
        {
           return default;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matrix3[i, j] = Math.Round(matrix3[i, j] + (matrix[i, k] * rotate[k, j]), 2);
                }
            }
        }
        return newMatrix;
    }
}
