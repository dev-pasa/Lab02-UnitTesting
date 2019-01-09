using System;
using Xunit;
using Lab02_UnitTesting;

namespace LAB02_UnitTestTDD
{
    public class UnitTest1
    {
        [Fact]
        public void WithDrawTest()
        {
            //Arrange
            double value = -100; double valNext = 3000;

            //Act

            //Asserted
            Assert.Equal(3000, Program.WithDraw(value, valNext));
        }

        [Fact]
        public void WithDrawTest2()
        {
            //Arrange
            double value = 100; double valNext = 3000;

            //Act

            //Asserted
            Assert.Equal(2900, Program.WithDraw(value, valNext));
        }

        [Theory]
        [InlineData(200, 3000)]

        public void DepositTest(double a, double b)
        {
            Assert.Equal(3200, Program.Deposit(a,b));
        }

        [Theory]
        [InlineData(500, 3000)]

        public void DepositTest2(double a, double b)
        {
            Assert.Equal(3500, Program.Deposit(a, b));
        }
    }
}
