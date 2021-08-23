using System;

/// <summary> A class containing a public method called DotProduct </summary>
class VectorMath
{
    /// <summary> To find the dot product of two vectors </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>the dot product, else -1</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return (-1);
        if (vector1.GetLength(0) != vector2.GetLength(0))
            return (-1);
        double[] sumMatrix = new double[vector1.GetLength(0)];
        double dot = 0.0;

        for(int index = 0; index < vector1.GetLength(0); index++)
           sumMatrix[index] = vector1[index] * vector2[index];

        foreach(int num in sumMatrix)
            dot += num;

        return (dot);
    }
}
