using System.Runtime.ExceptionServices;
using System;
using Start_1;

namespace Start_1.Test
{

    public class UnitTest1
    {
        [Fact]
        public void MaxElemeTest()
        {
            int[] array = { 1, 3, 4, 5, 9 };
            FirstPart firstPart = new FirstPart(array);
            int res = firstPart.MaxElemet();
            Assert.Equal(9, firstPart.MaxElemet());
        }

        [Fact]
        public void SumElementPositive()
        {
            int []  array = { 1, 2, 3, 4, -5, 9 };
            FirstPart firstPart2 = new FirstPart(array);
            int res2c = firstPart2.SumElementPositive();
            Assert.Equal(5, firstPart2.SumElementPositive()); 
        }
    }
}