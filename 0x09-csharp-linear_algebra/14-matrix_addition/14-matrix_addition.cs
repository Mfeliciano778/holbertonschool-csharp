using System;

/// <summary> A class containing a public method called Add </summary>
class MatrixMath
{
    /// <summary> To find the dot product of two matrix </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>the dot product, else -1</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = { { -1 } };

        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
            return (err);
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return (err);
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            return (err);

        double[,] sum = new double[matrix2.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i,j] = matrix1[i,j] + matrix2[i,j];

        return (sum);
    }
}
