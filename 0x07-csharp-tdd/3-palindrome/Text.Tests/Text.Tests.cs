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
            string palindrome = new string("RacecaR");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [Test]
        public void Test2()
        {
            string palindrome = new string("acecar");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsFalse(result);
        }

        [Test]
        public void Test3()
        {
            string palindrome = new string("racecar");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [Test]
        public void Test4()
        {
            string palindrome = new string("rac   e   car");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }


        [Test]
        public void Test5()
        {
            string palindrome = new string("RacecaR, racecar: >RaCecaR ");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [Test]
        public void Test6()
        {
            string palindrome = new string("");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }

        [Test]
        public void Test7()
        {
            string palindrome = new string(" ,;.** /? ");
            bool result = Str.IsPalindrome(palindrome);

            Assert.IsTrue(result);
        }
    }
}