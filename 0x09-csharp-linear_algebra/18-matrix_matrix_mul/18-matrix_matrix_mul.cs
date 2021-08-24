using System;

/// <summary> A class containing a public method called MultiplyScalar </summary>
class MatrixMath
{
    /// <summary> To find the scalar product of a matrix </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>matrix that is the result of the multiplication, else -1</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = { { -1 } };

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (err);

        double[,] sum = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    sum[i, j] += matrix1[i, k] * matrix2[k, j];
        
        return (sum);
    }
}
