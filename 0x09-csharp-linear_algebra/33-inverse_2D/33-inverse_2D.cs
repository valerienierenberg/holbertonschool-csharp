using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
{
    // assumes determinant is not 0
    // that is, the matrix does have an inverse
    int n = matrix.Length;
    double[][] result = MatrixCreate(n, n); // make a copy of matrix
    for (int i = 0; i < n; ++i)
    for (int j = 0; j < n; ++j)
        result[i][j] = matrix[i][j];

    double[][] lum; // combined lower & upper
    int[] perm;
    int toggle;
    toggle = MatrixDecompose(matrix, out lum, out perm);

    double[] b = new double[n];
    for (int i = 0; i < n; ++i)
    {
    for (int j = 0; j < n; ++j)
        if (i == perm[j])
        b[j] = 1.0;
        else
        b[j] = 0.0;

    double[] x = Helper(lum, b); // 
    for (int j = 0; j < n; ++j)
        result[j][i] = x[j];
    }
    return result;
}