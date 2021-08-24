using System;

/// <summary> A class containing a public method called Rotate2D </summary>
class MatrixMath
{
    /// <summary> To find the angle of a matrix </summary>
    /// <param name="matrix">The first matrix</param>
    /// <param name="angle">The angle</param>
    /// <returns>matrix that is the result of the rotation, else -1</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] err = { { -1 } };

        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (err);
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (err);

        double [,] sum = new double[matrix.GetLength(0), matrix.GetLength(0)];

        double first_x = matrix[0, 0];
        double first_y = matrix[0, 1];
        double sec_x = matrix[1, 0];
        double sec_y = matrix[1, 1];

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        sum[0, 0] = Math.Round((first_x * cos), 2) - Math.Round((first_y * sin), 2);
        sum[0, 1] = Math.Round((first_x * sin), 2) + Math.Round((first_y * cos), 2);
        sum[1, 0] = Math.Round((sec_x * cos), 2) - Math.Round((sec_y * sin), 2);
        sum[1, 1] = Math.Round((sec_x * sin), 2) + Math.Round((sec_y * cos), 2);

        return (sum);
    }
}
