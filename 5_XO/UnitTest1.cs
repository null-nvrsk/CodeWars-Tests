using NUnit.Framework;

namespace _5_XO
{
    public static class Kata
    {
        public static bool XO(string input)
        {
            int x = 0, o = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'x' || input[i] == 'X') x++;
                if (input[i] == 'o' || input[i] == 'O') o++;
            }

            return (x == o);
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, Kata.XO("xo"));
            Assert.AreEqual(true, Kata.XO("xxOo"));
            Assert.AreEqual(false, Kata.XO("xxxm"));
            Assert.AreEqual(false, Kata.XO("Oo"));
            Assert.AreEqual(false, Kata.XO("ooom"));
        }
    }
}