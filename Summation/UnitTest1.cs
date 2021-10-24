using System;
using Xunit;

namespace Summation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SummationSolution summationSolution = new SummationSolution();
            var resutl = summationSolution.Summation(3,1);

            Assert.Equal(1.6666666666666667, resutl);
        }

        [Fact]
        public void Test2()
        {
            SummationSolution summationSolution = new SummationSolution();
            var resutl = summationSolution.Summation(1,3);

            Assert.Equal(1.6666666666666665, resutl);
        }

        [Fact]
        public void Test3()
        {
            SummationSolution summationSolution = new SummationSolution();
            var resutl = summationSolution.Summation(6,3);

            Assert.Equal(0.21805555555555553, resutl);
        }
    }
}
