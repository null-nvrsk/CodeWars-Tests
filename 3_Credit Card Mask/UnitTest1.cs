using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace _3_Credit_Card_Mask
{
    public static class Kata
    {
        // return masked string
        public static string Maskify(string cc)
        {
            int lastCharsLength = (cc.Length > 4 ? 4 : cc.Length);
            string lastChars = cc.Substring(cc.Length - lastCharsLength, lastCharsLength);
            string requiredMask = new String('#', cc.Length - lastCharsLength);
            return requiredMask + lastChars;

            // RegEx variant
            // return Regex.Replace(cc, @".(?=.{4})", "#");
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("############5616", Kata.Maskify("4556364607935616"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("1", Kata.Maskify("1"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("#1111", Kata.Maskify("11111"));
        }
    }
}