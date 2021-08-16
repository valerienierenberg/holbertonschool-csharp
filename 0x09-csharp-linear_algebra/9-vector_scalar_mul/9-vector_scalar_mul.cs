using System;

class VectorMath
{
    ///<summary>Method that multiplies a vector (2D or 3D) by a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] scaledVector = new double[1] {-1};
        if (vector.Length == 2)
        {
            scaledVector = new double[2] {(vector[0] * scalar), (vector[1] * scalar)};
        }
        else if (vector.Length == 3)
        {
            scaledVector = new double[3] {(vector[0] * scalar), (vector[1] * scalar), (vector[2] * scalar)};
        }
        return scaledVector;
    }
}
