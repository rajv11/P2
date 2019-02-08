using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 2;
            int expected = 2;
            int actual = factorial(a);
            Assert.Equal(expected,actual);

        }
        [Theory]
        [InlineData(24,4)]
        [InlineData(120,5)]
        [InlineData(720,6)]
        [InlineData(40320,8)]
        public void TestAll(int exp,int a)
        {
            Assert.Equal(exp, factorial(a));
        }
        static int factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * factorial(n - 1);
        }
    }
}
