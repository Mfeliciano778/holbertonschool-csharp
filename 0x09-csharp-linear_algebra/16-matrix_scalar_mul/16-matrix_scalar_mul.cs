using System;

/// <summary> A class containing a public method called MultiplyScalar </summary>
class MatrixMath
{
    /// <summary> To find the scalar product of a matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <param name="scalar">The scalar</param>
    /// <returns>matrix that is the result of the scale, else -1</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] err = { { -1 } };

        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return (err);
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (err);

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i,j] *= scalar;
        
        return (matrix);
    }
}
