using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
         [Fact]
        public void Test1()
        {
           RecursiveCalc calc = new RecursiveCalc();

           Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(9, 1));
         }

        
        [Theory]
        [InlineData(false, 6)]
        [InlineData(true, 5)]
        public void FibbonaciTests(Boolean actual, int num)
        {
            RecursiveCalc calc = new RecursiveCalc();
            Assert.Equal(actual, calc.FibCheck(num));
        }
         [Theory]
         [InlineData(false,8)]
         public void PrimeCheckTest(bool actual, int num){
              RecursiveCalc calc = new RecursiveCalc();
             Assert.Equal(actual, calc.PrimeCheckRec(num, 1));
         }

         [Fact]
         public void FibbonaciRecursiveTest()
         {
             RecursiveCalc calc = new RecursiveCalc();
             Assert.Equal(1, calc.FibonacciRec(7,7,7));
         }
        
    }
}
