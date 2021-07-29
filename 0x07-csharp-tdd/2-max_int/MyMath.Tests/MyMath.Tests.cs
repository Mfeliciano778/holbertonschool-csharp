using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

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
            List<int> list = new List<int>() {0, 1, 2, 3, 4, 5};
            int maxNum = Operations.Max(list);
            int exampleOutput = 5;

            Assert.AreEqual(maxNum, exampleOutput);
        }

        [Test]
        public void Test2()
        {
            List<int> list = new List<int>() {-1, -2, -3, -4, -5};
            int maxNum = Operations.Max(list);
            int exampleOutput = -1;

            Assert.AreEqual(maxNum, exampleOutput);
        }

        [Test]
        public void Test3()
        {
            List<int> list = new List<int>() { };
            int maxNum = Operations.Max(list);
            int exampleOutput = 0;

            Assert.AreEqual(maxNum, exampleOutput);
        }
    }
}