using System;

namespace MyMath
{
    ///<summary>Matrix Class</summary>
    public class Matrix
    {
        ///<summary>Divide method</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int [,] newMatrix = matrix;
            int rowLength = newMatrix.GetLength(0);
            int colLength = newMatrix.GetLength(1);
            if (matrix == null)
            {
                return null;
            }
            try
            {
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        newMatrix[i, j] /= num;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return (newMatrix);
        }
    }
}
