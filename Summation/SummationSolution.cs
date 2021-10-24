using System;
using System.Collections.Generic;
using System.Text;

namespace Summation
{
    public class SummationSolution
    {
        public double Summation(int n , int m)
        {
            double sum = 0.00;

            if(m > n)
            {
                for(int i = m; i >= n; i--)
                {
                    sum += oneDivideFactorial(i);
                }
            }
            else
            {
                for (int i = m; i <= n; i++)
                {
                    sum += oneDivideFactorial(i);
                }
            }

            return (double)sum;
        }

        private double oneDivideFactorial(int m)
        {
            int myFactorial = factorial(m);

            double ans = Math.Pow((myFactorial), -1);

            return ans;
        }

        private int factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            

            return n * factorial(n-1);
        }
    }
}
