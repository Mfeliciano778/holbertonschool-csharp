using System;

class VectorMath
{
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
