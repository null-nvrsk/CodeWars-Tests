using NUnit.Framework;

namespace _1_Sum_of_Digits___Digital_Root
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            while (n > 9)
            {
                long sum = 0;
                long tempResult = n;
                do
                {
                    sum += tempResult % 10;
                    tempResult /= 10;
                } while (tempResult > 0);
                n = sum;

            }
   
            return (int)n;
        }
    }

    [TestFixture]
    public class NumberTest
    {
        private Number num;

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}