using System;

///<summary>Vector Math class</summary>
class VectorMath
{
    ///<summary>Method that adds two vectors (2D or 3D) and returns the resulting vector</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
            double[] sumVector = new double[1] {-1};
            // If they are both 2D vectors
            if (vector1.Length == 2 && vector2.Length == 2)
            {
                // add each corresponding position's value and set it to the new vector's values
                sumVector = new double[2] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1])};
            }
            // If they are both 3D vectors
            else if (vector1.Length == 3 && vector2.Length == 3)
            {
                // add each corresponding position's value and set it to the new vector's values
                sumVector = new double[3] {(vector1[0] + vector2[0]), (vector1[1] + vector2[1]), (vector1[2] + vector2[2])};
            }
            return sumVector;
        }
}


