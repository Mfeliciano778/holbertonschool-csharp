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
            var sum = Operations.Add(2, 2);

            Assert.AreEqual(sum, 4);
        }

        [Test]
        public void Test2()
        {
            var sum = Operations.Add(-2, 2);

            Assert.AreEqual(sum, 0);
        }

        [Test]
        public void Test3()
        {
            var sum = Operations.Add(0, 0);

            Assert.AreEqual(sum, 0);
        }
    }
}