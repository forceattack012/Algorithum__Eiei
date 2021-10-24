using System;
using Xunit;

namespace SlidingWindow
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] numbs = new int[]
            {
                1,2,3,4,5,6
            };

            SlidingWindowSolution slidingWindowSolution = new SlidingWindowSolution(numbs, 3);
            slidingWindowSolution.DisplaySlidingWindow();
        }

        [Fact]
        public void Test2()
        {
            int[] numbs = new int[]
            {
                1,2,3,4,5,6
            };

            SlidingWindowSolution slidingWindowSolution = new SlidingWindowSolution(numbs, 3);
            var listMax = slidingWindowSolution.MaxSlidingWindow(numbs, 3);

            Assert.Equal(listMax, new int[] { 3, 4, 5, 6 });
        }

        [Fact]
        public void Test3()
        {
            int[] numbs = new int[]
            {
               1,3,-1,-3,5,3,6,7
            };

            SlidingWindowSolution slidingWindowSolution = new SlidingWindowSolution(numbs, 3);
            var listMax = slidingWindowSolution.MaxSlidingWindow(numbs, 3);

            Assert.Equal(listMax, new int[] { 3, 3,5,5,6,7 });
        }
    }
}
