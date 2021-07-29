using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[,] matrix = new int[,] {{6, 88, 0,}, {12, -95, 15}, {140, -7, -100}};
            int[,] sumMatrix = Matrix.Divide(matrix, 2);
            int[,] exampleOutput = new int[,] {{3, 44, 0}, {6, -47, 7}, {70, -3, -50}};

            Assert.AreEqual(sumMatrix, exampleOutput);
        }

        [Test]
        public void Test2()
        {
            int[,] matrix = new int[,] {{6, 88, 0,}, {12, -95, 15}, {140, -7, -100}};
            int[,] sumMatrix = Matrix.Divide(matrix, -2);
            int[,] exampleOutput = new int[,] {{-3, -44, 0}, {-6, 47, -7}, {-70, 3, 50}};

            Assert.AreEqual(sumMatrix, exampleOutput);
        }

        [Test]
        public void Test3()
        {
            int[,] matrix = null;
            int[,] sumMatrix = Matrix.Divide(matrix, 2);
            int [,] exampleOutput = null;

            Assert.AreEqual(sumMatrix, exampleOutput);
        }
    }
}