using System;
using System.Linq;

namespace Algorithms.SelectionSort {

// Selection Sort

// value => 10 5 6 8 7 4

// index => 0  1 2 3 4 5

// Step 1 : value 10 check in array find min value in array [10 to 4] 
//   inner Rannge index 1 to n find index of min
//   indexMin = 5
//   Swap(10,4) : 4 5 6 8 7 10  
// Step 2 : value 5 find min in array [5 to 7] Range index 1 to n-1
// 4 5 6 8 7 10 
//   inner Rannge index 2 to n find index of min
//   indexMin = 1
//   swap : 4 5 6 8 7 10
// Step 3 : value 6 Find Min in array [6 to 7] Range index 2 to n-1
// 4 5 6 8 7 10
//   inner Rannge index 3 to n find index of min
//   indexMin = 2
//   Swap() : 4 5 6 8 7 10
// Step 4 : value 8 Find Min in array [8 to 7] Range index 3 to n-1
// 4 5 6 8 7 10
//   inner Rannge index 4 to n find index of min
//   indexMin = 3
//   swap(8,7) :  4 5 6 7 8 10

// Step 5 : value 8 Find Min in array [8 to 10] Range index 4 to n-1
// 4 5 6 7 8 10
   


    public static class SelectionSortSolution {
        public static int[] ToSelectionSort(this int[] numbers) {
            int size = numbers.Length;

            for(int i=0; i<size-1; i++) {
                int indexMin = i;

                for(int j=i+1; j < size; j++) {
                    if(numbers[j] < numbers[indexMin]) {
                        indexMin = j;
                    }
                }
                swap(ref numbers[i],  ref numbers[indexMin]);
            }

            return numbers;
        }

        public static string ToSelectionSort(this string text)
        {
            int size = text.Length;

            for (int i = 0; i < size - 1; i++)
            {
                int indexMin = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (text[j] < text[indexMin])
                    {
                        indexMin = j;
                    }
                }
                var temp = text[i];
                var result = text.Select(r => r == temp ? text[indexMin] : (r == text[indexMin] ? temp : r)).ToArray();
                text = new String(result);

            }

            return text.ToString();
        }

        private static void swap(ref int numberA, ref int numberB) {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
        }

        
    }
}