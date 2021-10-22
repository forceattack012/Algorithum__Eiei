using System;
using Xunit;

namespace PrimeNumber
{
    public class TestPrimeNumber
    {

        [Fact]
        public void TestCase0()
        {
            FindPrime primeNumber = new FindPrime();
            var numbers = new int[] { 1 };

            var result = primeNumber.Solutiion(numbers);
            Assert.Equal(result, new int[] {  });
        }
        [Fact]
        public void TestCase1()
        {
            FindPrime primeNumber = new FindPrime();
            var numbers = new int[] { 1, 2, 3, 4, 5 , 6 , 7, 8, 9, 10 };

            var result = primeNumber.Solutiion(numbers);
            Assert.Equal(result, new int[] { 2, 3, 5,7 });
        }

        [Fact]
        public void TestCase2()
        {
            FindPrime primeNumber = new FindPrime();
            var numbers = new int[] { 8,7,4,3,2,1,5,9,10,11,12,13,14,15 };

            var result = primeNumber.Solutiion(numbers);
            Assert.Equal(result, new int[] { 2, 3, 5, 7,11,13 });
        }

        [Fact]
        public void TestCase3()
        {
            FindPrime findPrime = new FindPrime();
            var result = findPrime.FindPrimeNumberOneToOnehundred();
            var expect = new int[]
            {
                2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97
            };
            Assert.Equal(result, expect);
        }

        [Fact]
        public void TestCase4()
        {
            FindPrime findPrime = new FindPrime();
            var result = findPrime.FindPrimeNumberUseSieveofEratosthenes(100);
            var expect = new int[]
            {
                2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97
            };
            Assert.Equal(result, expect);
        }

        [Fact]
        public void TestCase5()
        {
            var numbers = new int[] { 8, 7, 4, 3, 2, 1, 5, 9, 10, 11, 12, 13, 14, 15 };
            var result = numbers.FilterPrimeNumber();

            Assert.Equal(result, new int[] { 2, 3, 5, 7, 11, 13 });
        }

        [Fact]
        public void TestCase6()
        {
            var n = 100;
            var result = n.GetPrimeNumberByN();

            var expect = new int[]
                {
                  2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97
                };
            Assert.Equal(result, expect);
        }
    }
}
