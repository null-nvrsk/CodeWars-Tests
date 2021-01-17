using NUnit.Framework;
using System;

namespace _4_HighAndLow
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            string[] strNums = numbers.Split(" ");
            int min = int.MaxValue,
                max = int.MinValue;
            foreach (string s in strNums)
            {
                int i = int.Parse(s);
                if (i < min) min = i;
                if (i > max) max = i;
            }

            return $"{ max} {min}";
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}