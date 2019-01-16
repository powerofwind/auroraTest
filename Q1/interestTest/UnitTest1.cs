using System;
using interestAPI;
using Xunit;

namespace interestTest
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เงินต้น10k ,ดอก12%, 3ปี")]
        [InlineData(10000,12,1200)]
        public void money10k(double inputMoney, double inputInterest, double expected)
        {
            var sut = new logic();
            var result = sut.interestLogic(inputMoney,inputInterest);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "เงินต้น20k ,ดอก5%, 3ปี")]
        [InlineData(20000,5,1000)]
        public void money20k(double inputMoney, double inputInterest, double expected)
        {
            var sut = new logic();
            var result = sut.interestLogic(inputMoney,inputInterest);
            Assert.Equal(expected, result);
        }
    }
}
