using Algorithms.SelectionSort;
using System;
using Xunit;

namespace SelectionSort
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int [] numbers = new int[] {3,1,2};
            var sort = numbers.ToSelectionSort();

            Assert.Equal(sort, new int[] {1,2,3});
        }

        [Fact]
        public void Test2()
        {
            int[] numbers = new int[] { 10,5,6,8,7,4 };
            var sort = numbers.ToSelectionSort();

            Assert.Equal(sort, new int[] { 4,5,6,7,8,10 });
        }

        [Fact]
        public void Test3()
        {
            int[] numbers = new int[] { 44, 33, 11, 85, 77, 60 };
            var sort = numbers.ToSelectionSort();

            Assert.Equal(sort, new int[] { 11,33,44,60,77,85 });
        }

        [Fact]
        public void Test4()
        {
            int[] numbers = new int[] { 23, 78, 45, 8, 32, 56 };
            var sort = numbers.ToSelectionSort();

            Assert.Equal(sort, new int[] { 8,23,32,45,56,78 });
        }

        [Fact]
        public void Test5()
        {
            string text = "BAC";
            var sort = text.ToSelectionSort();
            Assert.Equal("ABC", sort);
        }
    }
}
