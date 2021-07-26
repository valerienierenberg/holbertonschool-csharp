using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int [,] twodim = myMatrix;
        int rowLength = twodim.GetLength(0);
        int colLength = twodim.GetLength(1);
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                twodim[i, j] *= twodim[i, j];
            }
        }
        return (twodim);
    }
}