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
        public Dictionary<int,int> GetBaht(int money)
        {
            var dic = new Dictionary<int, int>();
            CalBath(money,ref dic);
            return dic;
        }

        private void CalBath(int money,ref Dictionary<int,int> dictionary)
        {
            int n;
            int divid;
            if (money >= 1000)
            {
                divid = 1000;
                n = (int)money / divid;
            }
            else if (money >= 500)
            {
                divid = 500;
                n = (int)money / divid;
            }
            else if (money >= 100)
            {
                divid = 100;
                n = (int)money / divid;
            }
            else if (money >= 20)
            {
                divid = 20;
                n = (int)money / divid;
            }
            else if (money >= 10)
            {
                divid = 10;
                n = (int)money / divid;
            }
            else if (money >= 5)
            {
                divid = 5;
                n = (int)money / divid;
                money = money - (n * divid);
            }
            else if (money >= 1)
            {
                divid = 1;
                n = (int)money / divid;
            }
            else
            {
                return;
            }
            dictionary.Add(divid, n);
            CalBath(money - (n * divid), ref dictionary);
        }

        public int RevseveNumber(int n)
        {
            int mul = 1;
            if(n >= 100)
            {
                mul = 100;
            }
            else if(n >= 10)
            { 
                mul = 10; 
            }
            if (n / 10 == 0)
            {
                return n;
            }
            return (n % 10 * mul) + RevseveNumber(n/10);
        }

        public void PrintPeramietA(int n)
        {
            if(n == 0)
            {
                return;
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            PrintPeramietA(n - 1);
        }

        public void PrintPeramietB(int n)
        {
            int temp = 0;
            if(n == 0)
            {
                return;
            }
            for(int i = 0; i < n - 1; i++)
            {
                temp += 1;
                Console.Write(" ");
            }
            for(int j = 0; j < 5 - temp; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            PrintPeramietB(n - 1);
        }
    }
}
