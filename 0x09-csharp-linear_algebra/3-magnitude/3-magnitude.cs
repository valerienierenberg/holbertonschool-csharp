using System;

///<summary>Vector Math class</summary>
class VectorMath
{
    ///<summary>Method that returns the magnitude of a 2D or 3D vector</summary>
    public static double Magnitude(double[] vector)
    {
        // if 2D vector
        if (vector.Length == 2)
        {
            // magnitude of vector is equal to the square root of the sum of value1^2 and value2^2
            // (pythagorean theorm)
            double res = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
            // round result to two decimal places
            return Math.Round(res, 2);
        }
        // if 3D vector
        if (vector.Length == 3)
        {
            double res = (Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));
            return Math.Round(res, 2);
        }
        // if not a 2D or 3D vector, return -1
        else
        {
            return -1;
        }
    }
}
