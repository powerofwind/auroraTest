using System;
using interestAPI;
using Xunit;

namespace interestTest
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เงินต้น10k ,ดอก12%, 3ปี")]
        [InlineData(10000,12,3,11200)]
        public void money10k(double inputMoney, double inputInterest, int inputYear,double expected)
        {
            var sut = new logic();
            var result = sut.interestLogic(inputMoney,inputInterest,inputYear);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "เงินต้น20k ,ดอก5%, 3ปี")]
        [InlineData(20000,5,10,21000)]
        public void money20k(double inputMoney, double inputInterest, int inputYear,double expected)
        {
            var sut = new logic();
            var result = sut.interestLogic(inputMoney,inputInterest,inputYear);
            Assert.Equal(expected, result);
        }
    }
}
