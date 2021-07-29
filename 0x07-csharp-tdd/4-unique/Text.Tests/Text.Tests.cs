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
            string testWord = new String("aabbcc");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Test2()
        {
            string testWord = new String("word");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Test3()
        {
            string testWord = new String("aabbccg");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, 6);
        }

        [Test]
        public void Test4()
        {
            string testWord = new String("abbcc");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Test5()
        {
            string testWord = new String("aabcc");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Test6()
        {
            string testWord = new String("");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Test7()
        {
            string testWord = new String("wordword");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Test8()
        {
            string testWord = new String("wordabc");
            int result = Str.UniqueChar(testWord);
            Assert.AreEqual(result, 0);
        }
    }
}