using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderLinkedListProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HeaderLinkedList headerLinkedList = new HeaderLinkedList();
            CreatLinkedList(headerLinkedList);
            headerLinkedList.InsertAtBefore(5, 2);
            headerLinkedList.InsertPosition(10, 2);
            headerLinkedList.DeleteNode(5);
            headerLinkedList.DisplayLIst();

        }

        private static void CreatLinkedList(HeaderLinkedList headerLinked)
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
                headerLinked.InsertAtEnd(data);
            }
        }
    }
}
