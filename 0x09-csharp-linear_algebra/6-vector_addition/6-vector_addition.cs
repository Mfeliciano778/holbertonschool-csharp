using System;

/// <summary> A class containing a public method called Add </summary>
class VectorMath
{
    /// <summary> To find the sum of two 2D or 3D vectors </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>sum of the vectors, else -1</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] err = {-1};

        if (vector1.GetLength(0) != vector2.GetLength(0))
            return (err);
        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return (err);

        double[] sum = new double[vector1.GetLength(0)];

        for(int index = 0; index < vector1.GetLength(0); index++)
            sum[index] = vector1[index] + vector2[index];
        return (sum);
    }
}
