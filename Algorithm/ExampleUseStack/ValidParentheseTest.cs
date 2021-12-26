using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExampleUseStack
{
    public class ValidParentheseTest
    {
        [Fact]
        public void Test1()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("()");

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("()[]{}");

            Assert.True(result);
        }


        [Fact]
        public void Test3()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("(]");

            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("([)]");

            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("{[]}");

            Assert.True(result);
        }

        [Fact]
        public void TestCase6()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("(([]){})");

            Assert.True(result);
        }
        [Fact]
        public void TestCase7()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("]");
            Assert.False(result);
        }

        [Fact]
        public void TestCase8()
        {
            ValidParenthese solution = new ValidParenthese();
            var result = solution.IsValid("(8+2)/3");
            Assert.True(result);
        }
    }
}
