using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
    public class FindPrime
    {
        public int[] Solutiion(int [] numbers)
        {
            var newNumbers = numbers.ToList();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 1)
                {
                    var index = newNumbers.IndexOf(numbers[i]);
                    newNumbers.RemoveAt(index);
                }
                for (int j=2; j < numbers[i]; j++)
                {
                    if(numbers[i] % j == 0)
                    {
                        var index = newNumbers.IndexOf(numbers[i]);
                        newNumbers.RemoveAt(index);
                        break;
                    }
                }
            }
            newNumbers.Sort();
            return newNumbers.ToArray();
        }

        public int [] FindPrimeNumberOneToOnehundred()
        {
            List<int> primeNumber = new List<int>();
            bool isPrime = true;
            for(int i = 1; i < 101; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime && i > 1)
                {
                    primeNumber.Add(i);
                }
                isPrime = true;
            }
            return primeNumber.ToArray();
        }

        public int[] FindPrimeNumberUseSieveofEratosthenes(int n)
        {
            if(n <= 1)
            {
                throw new Exception("N is more one");
            }

            bool[] allResult = new bool[n];
            for(int i = 2; i < n; i++)
            {
                allResult[i] = true;
            }

            for(int i = 2; i < (int)Math.Sqrt(n); i++)
            {
                if (allResult[i])
                {
                    for(int j = (int)(Math.Pow(i,2)); j < n; j+=i)
                    {
                        allResult[j] = false;
                    }
                }
            }

            return allResult.Select((value, index) => value == true ? index : -1).Where(index => index != -1).ToArray();
        }
    }
}
