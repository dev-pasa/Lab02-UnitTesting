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
            Assert.Equal("Invalid Amount. Please enter over 0", Program.WithDraw(value, valNext));
        }

        [Theory]
        [InlineData(200, 3000)]

        public void DepositTest(double a, double b)
        {
            Assert.Equal("Deposit success", Program.Deposit(a,b));
        }
    }
}
