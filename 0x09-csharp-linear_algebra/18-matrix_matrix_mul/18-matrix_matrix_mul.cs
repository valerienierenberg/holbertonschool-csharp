using System;

///<summary>Matrix Math class</summary>
class MatrixMath
{
    ///<summary>Method that multiplies two matrices and returns the resulting matrix.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rA = matrix1.GetLength(0);
        int cA = matrix1.GetLength(1);
        int rB = matrix2.GetLength(0);
        int cB = matrix2.GetLength(1);
        double temp = 0;
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] kHasil = new double[rA, cB];

        if (cA != rB)
        {
            return newMatrixDefault;
        }
        else
        {
            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    kHasil[i, j] = temp;
                }
            }
        return kHasil;
        }
    }
}
