using System.Runtime.ExceptionServices;
using System;
using Start_1;


namespace Start_1.Test
{
    public class UnitTest2
    {
        [Fact]
        public void SumOfColumnsWithNoNegatives()
        {
            int[,] resultArray = { { 1, 2, 3 },
                                    { 4, 5, 6 } };
            SecondPart secondpart = new SecondPart(resultArray);
            int res = secondpart.SumOfColumnsWithNoNegatives(resultArray);
            Assert.Equal(21, res);


        }
        [Fact]
        public void MinSumOfDiagonalParallelToSecondary() 
        {
            int[,] resultArray = { { 18, 17, 9 },
                                    { 6, 10, 5 },
                                    { -6, -10, 5 } };
            SecondPart secondpart2 = new SecondPart(resultArray);
            int res2 = secondpart2.MinSumOfDiagonalParallelToSecondary(resultArray);
            Assert.Equal(6, res2);
            

        }
        

         
    }

   
}