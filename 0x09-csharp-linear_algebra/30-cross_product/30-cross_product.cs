using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
 
        double[] cross_P = {0, 0, 0};

        cross_P[0] = vector1[1] * vector2[2]
                     - vector1[2] * vector2[1];
        cross_P[1] = vector1[2] * vector2[0]
                     - vector1[0] * vector2[2];
        cross_P[2] = vector1[0] * vector2[1]
                     - vector1[1] * vector2[0];

        return cross_P;
    }
}
