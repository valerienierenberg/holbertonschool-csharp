using System;
// similar set up to task 3, because they both do not return vectors

class VectorMath
{
    ///<summary>Method that calculates dot product of either two 2D or two 3D vectors.</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // if 2D vectors
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            // dot product of 2D vectors is equal to (v1[0] * v2[0]) + (v1[1] + v2[1])
            double dotProd = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]));
            // round result to two decimal places
            return Math.Round(dotProd, 2);
        }
        // if 3D vectors
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            // dot product of 3D vectors is equal to (v1[0] * v2[0]) + (v1[1] + v2[1]) + (v1[2] * v2[2])
            double dotProd = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]));
            return Math.Round(dotProd, 2);
        }
        // if not a 2D or 3D vector, return -1
        else
        {
            return -1;
        }
    }
}
