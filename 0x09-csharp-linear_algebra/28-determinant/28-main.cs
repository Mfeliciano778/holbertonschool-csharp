using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix = new double[,] { { 2, 2 }, { -9, 4 } };
		Console.WriteLine(MatrixMath.Determinant(matrix));

		matrix = new double[,] { { -4, 9, 0 }, { 1, -2, 1 },  { 3, -4, 2 }};
		Console.WriteLine(MatrixMath.Determinant(matrix));

		matrix = new double[,] { { -4, 9 }, { 1, -2 },  { 3, -4 }};
		Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}
