using Function;
using System;
using System.Collections.Generic;
using Xunit;

namespace FunctionTest
{
    public class FunctionsTupleTest
    {
        [Fact]
        public void ShouldIfOnly1Number()
        {
            double number = 0;
            for (int i = 0; i < 10000; i++)
            {
                number += Math.PI;
                List<double> dataSet = new List<double> { number };
                (double sum, double average, double standardDeviation) = Program.GetSumAvegareAndStandardDeviation(dataSet);
                Assert.Equal(number, sum);
                Assert.Equal(number, average);
                Assert.Equal(0, standardDeviation);
            }


        }

        [Fact]
        public void ShouldIfNfirstInteger()
        {
            List<double> dataSet = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            var (sum, average, standardDeviation) = Program.GetSumAvegareAndStandardDeviation(dataSet);
            Assert.Equal(231, sum);
            Assert.Equal(11, average);
            Assert.Equal(6.055300708194983, standardDeviation, 15);
        }
    }
}
