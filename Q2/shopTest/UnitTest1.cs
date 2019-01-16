using System;
using shopAPI;
using Xunit;

namespace shopTest
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ของ4ชิ้น ชิ้นละ10บาท")]
        [InlineData(4,10,30)]
        public void amount4(int amount, int price, double expected)
        {
            var sut = new logic();
            var result = sut.discount(amount,price);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "ของ8ชิ้น ชิ้นละ10บาท")]
        [InlineData(8,10,60)]
        public void amount8(int amount, int price, double expected)
        {
            var sut = new logic();
            var result = sut.discount(amount,price);
            Assert.Equal(expected, result);
        }

    }
}
