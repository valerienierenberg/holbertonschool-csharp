using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int n = matrix.Length;
        double[,] newMatrixDefault = new double[,] {{-1}};
        double[,] result = new double[2, 2];

        int[] perm;
        int toggle;
//        double[][] lum = MatrixDecompose(matrix, out perm,
//            out toggle);
//        if (lum == null)
//            throw new Exception("Unable to compute inverse");

        double[] b = new double[n];
        for (int i = 0; i < n; ++i)
    {
            for (int j = 0; j < n; ++j)
    {
                if (i == perm[j])
                    b[j] = 1.0;
                else
                    b[j] = 0.0;
            }

            double[] x = HelperSolve(lum, b);

            for (int j = 0; j < n; ++j)
        result[j][i] = x[j];
        }
        return result;
    }


    static double[] HelperSolve(double[][] luMatrix, double[] b)
    {
        // before calling this helper, permute b using the perm array
        // from MatrixDecompose that generated luMatrix
        int n = luMatrix.Length;
        double[] x = new double[n];
        b.CopyTo(x, 0);

        for (int i = 1; i < n; ++i)
        {
            double sum = x[i];
            for (int j = 0; j < i; ++j)
                sum -= luMatrix[i][j] * x[j];
            x[i] = sum;
        }

        x[n - 1] /= luMatrix[n - 1][n - 1];
        for (int i = n - 2; i >= 0; --i)
        {
            double sum = x[i];
            for (int j = i + 1; j < n; ++j)
                sum -= luMatrix[i][j] * x[j];
            x[i] = sum / luMatrix[i][i];
        }

        return x;
    }
}