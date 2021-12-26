using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProject
{
    public class Recursion
    {
        public long Factorial(int n)
        {
            if(n== 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public long Summation(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n + Summation(n - 1);
        }

        public void Print1(int n)
        {
            if(n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            Print1(n - 1);
        }

        public void Print2(int n)
        {
            if(n == 0)
            {
                return;
            }
            Print2(n - 1);
            Console.Write(n + " ");
        }

        public long SumDigit(int n)
        {
            if(n/10 == 0)
            {
                return n;
            }
            return SumDigit(n / 10) + n % 10;
        }

        public void ToBinary(int n)
        {
            if(n == 0)
            {
                return;
            }
            ToBinary(n / 2);
            Console.Write(n % 2 + " ");
        }

        public float Power(float n , int power)
        {
            if(power == 0)
            {
                return 1;
            }

            return n * Power(n, power - 1);
        }

        public int GCD(int a,int b)
        {
            if(b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }

        public int Fibonacci(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int Count(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else
            {
                return 1 + Count(n / 10);
            }
        }
    }
}
