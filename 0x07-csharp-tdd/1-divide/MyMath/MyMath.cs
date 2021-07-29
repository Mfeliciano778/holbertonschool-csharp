using System;

namespace MyMath
{
    /// <summary> A class called Matrix holding Divide method </summary>
    public class Matrix
    {
        /// <summary> A method called Divide method that divideds a matrix</summary>
        /// <param name="matrix"> The matrix </param>
        /// <param name="num"> The number to divide by </param>\
        /// <returns> New matrix divided by a number </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return (null);
            try
            {
                int[,] sumMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sumMatrix[i, j] = matrix[i, j] / num;
                    }
                }
                Console.WriteLine(sumMatrix);
                return (sumMatrix);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num Cannot be 0");
                return (null);
            }
        }
    }
}
