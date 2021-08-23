using System;

/// <summary> A class containing a public method called Multiply </summary>
class VectorMath
{
    /// <summary> To multiply a vector and a scalar </summary>
    /// <param name="vector">The vector</param>
    /// <param name="scalar">The scalar</param>
    /// <returns>the resulting vector, else -1</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] err = {-1};

        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return (err);
        double[] sum = new double[vector.GetLength(0)];

         for(int index = 0; index < vector.GetLength(0); index++)
            sum[index] = vector[index] + scalar;
        return (sum);
    }
}
