using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = {1, 2, 3};
        double[] vector2 = {4, 5, 6};

        Console.WriteLine(VectorMath.CrossProduct(vector1, vector2));
    }
}
