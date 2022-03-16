using ATM;
using System;
using Xunit;


namespace ATMxtest
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTest()
        {
            Assert.Equal(1000, Program.ViewBalance());
        }
        [Fact]
        public void WithdrawTest()
        {
            Assert.Equal(900, Program.Withdraw(100));

        }
        [Fact]
        public void DepositTest()
        {
            Assert.Equal(1100, Program.Deposit(100));

        }
        [Theory]
        [InlineData(800,200)]
       
        public void WithdrawTesttheory(decimal input,decimal output)
        {
            Assert.Equal(output, Program.Withdraw(input));

        }

        [Theory]
        [InlineData(200, 1200)]

        public void DepositTesttheory(decimal input, decimal output)
        {
            Assert.Equal(output, Program.Deposit(input));

        }
    }
}
