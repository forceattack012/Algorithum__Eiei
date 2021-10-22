using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
    public static class FunctionalFindPrime
    {
        private static bool isPrimenumber(int number)
        {
            if(number == 1)
            {
                return false;
            }

            for(int i = 2; i < number; i++)
            {
                if(number%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<int> FilterPrimeNumber(this int [] numbers)
        {
            return numbers.OrderBy(r => r).Where(r => isPrimenumber(r) == true);
        }

        public static IEnumerable<int> GetPrimeNumberByN(this int n)
        {
            return Enumerable.Range(1, n).Where(r => isPrimenumber(r));
        }
    }
}
