using System;
using System.Collections.Generic;
using System.Linq;


namespace SlidingWindow
{
    public class SlidingWindowSolution
    {
        private int maxSize { get; set; }
        private int[] numbers { get; set; }

        public SlidingWindowSolution()
        {

        }

        public SlidingWindowSolution(int[] numbers, int maxSize)
        {
            this.numbers = numbers;
            if(maxSize > numbers.Length)
            {
                //Errror
            }
            this.maxSize = maxSize;
        }

        public void DisplaySlidingWindow()
        {
            string text = "";

            for(int i=0;i <= numbers.Length - maxSize;i++)
            {
                Console.WriteLine($"=========================================== Round {i+1} ==================================");
                text = "";

                for(int j=i; j < i + maxSize; j++)
                {
                    text += Convert.ToString(numbers[j]);
                }

                Console.WriteLine($"[{text}]");
                Console.WriteLine($"=========================================================================================");
            }
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> MaxWindowsList = new List<int>();

            for (int i = 0; i <= numbers.Length - k; i++)
            {
                int[] arrayOfWindows = new int[k];

                for (int j = i; j < i + maxSize; j++)
                {
                    arrayOfWindows[j - i] = numbers[j];
                }

                MaxWindowsList.Add(arrayOfWindows.Max());
            }

            return MaxWindowsList.ToArray();
        }
    }
}
