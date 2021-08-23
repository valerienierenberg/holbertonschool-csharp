using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] newMatrix = new double[2, 2];
        double[,] shear = new double[2, 2] {{1, 0}, {0, 1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return newMatrixDefault;
        }

        if (direction == 'x')
        {
            shear[1, 0] = factor;
        }

        if (direction == 'y')
        {
            shear[0, 1] = factor;
        }
        else if (direction != 'x' && direction != 'y')
        {
            return newMatrixDefault;
        }
        else
        {
            return newMatrixDefault;
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
              for (int k = 0; j < 2; j++)  
                {
                    newMatrix[i, j] = newMatrix[i, j] + (matrix[i, k] * shear[k, j]);
                }
            }
        }
        return newMatrix;
    }
}
