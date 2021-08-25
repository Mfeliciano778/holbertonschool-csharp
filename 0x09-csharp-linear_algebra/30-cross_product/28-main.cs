using System;

class Program
{
    static void Main(string[] args)
    {
		double[] vector1 = new double[] {-4, 9, 0 };
		double[] vector2 = new double[] {4, 19, 2 };
		Console.WriteLine(String.Join(",", MatrixMath.CrossProduct(vector1, vector2)));

		vector2 = new double[] {4, 19};
		Console.WriteLine(String.Join(",", MatrixMath.CrossProduct(vector1, vector2)));
    }
}
