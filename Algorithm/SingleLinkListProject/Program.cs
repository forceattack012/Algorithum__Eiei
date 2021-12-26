using SingleLinkListProject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static SigngleLinkListInteger singleLinkListNumbers = new SigngleLinkListInteger();
        public static SigngleLinkListInteger singleLinkListNumbers2 = new SigngleLinkListInteger();
        public static void Main(string[] args)
        {
            //CreateList();
            CreateList2();
            singleLinkListNumbers2.DisplayNodes();
            //singleLinkListNumbers.Concatenate(singleLinkListNumbers2);
            //singleLinkListNumbers.DisplayNodes();
        }

        public static void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter Number of The node : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Of Element {0} : ", i);
                data = Convert.ToInt32(Console.ReadLine());
                singleLinkListNumbers.InsertAtEndNode(data);
            }
        }

        public static void CreateList2()
        {
            int i, n, data;
            Console.WriteLine("Enter Number of The node : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Of Element {0} : ", i);
                data = Convert.ToInt32(Console.ReadLine());
                singleLinkListNumbers2.InsertOrder(data);
            }
        }
    }
}

