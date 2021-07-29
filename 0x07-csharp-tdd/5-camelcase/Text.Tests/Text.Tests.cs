using NUnit.Framework;
using Text;
using System;

namespace Text.Tests
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
            string testWords = new String("word");
            int sum = Str.CamelCase(testWords);
            Assert.AreEqual(sum, 1);
        }

        [Test]
        public void Test2()
        {
            string testWords = new String("bigWord");
            int sum = Str.CamelCase(testWords);
            Assert.AreEqual(sum, 2);
        }

        [Test]
        public void Test3()
        {
            string testWords = new String("theOnlyThingICanThinkOf");
            int sum = Str.CamelCase(testWords);
            Assert.AreEqual(sum, 7);
        }

        [Test]
        public void Test4()
        {
            string testWords = new String("");
            int sum = Str.CamelCase(testWords);
            Assert.AreEqual(sum, 0);
        }
    }
}