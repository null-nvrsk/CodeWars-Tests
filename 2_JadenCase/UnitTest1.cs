using NUnit.Framework;
using System;

namespace _2_JadenCase
{

    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            string[] words = phrase.Split(' ');

            string result = "";
            foreach (var word in words)
            {
                result += char.ToUpper(word[0]) + word.Substring(1) + ' ';
            }

            return result.Trim();
        }
    }


    [TestFixture]
    public class JadenCaseTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
        }
    }
}