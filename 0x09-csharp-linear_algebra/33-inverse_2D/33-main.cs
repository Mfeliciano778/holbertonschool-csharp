using System;

class Program
{
    static void Main(string[] args)
    {
		double[,] matrix = new double[,] {{ 1, 2 }, { 3, 4 }};

		printMatrix(MatrixMath.Inverse2D(matrix));

		matrix = new double[,] {{ 11, 8, 7 }, { 2, 13, 1 },  { 4, 0, 17 }};
		printMatrix(MatrixMath.Inverse2D(matrix));
		
		matrix = new double[,] {{ -4, 9 }, { 1, -2 }};
		printMatrix(MatrixMath.Inverse2D(matrix));
    }
	
	static void printMatrix(double[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			Console.Write("(");
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i,j] + ",");
			Console.WriteLine("),");
		}
		Console.WriteLine();
	}
}
