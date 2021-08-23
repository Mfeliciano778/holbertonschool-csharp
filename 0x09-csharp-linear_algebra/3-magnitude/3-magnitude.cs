using System;

/// <summary> A class containing a public method called magnitude </summary>
class VectorMath
{
    /// <summary> To find the magnitude of a 2D or 3D vector </summary>
    /// <param name="vector">The vector</param>
    /// <returns>length of the vector, else -1</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return (-1);
        double res = 0.0;

        foreach (int number in vector)
            res += Math.Pow(number, 2.0);
        
        return (Math.Round(Math.Sqrt(res), 2));
    }
}
