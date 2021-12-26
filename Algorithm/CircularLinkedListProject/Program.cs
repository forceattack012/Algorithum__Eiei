using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CircularLinkedList circularLinked = new CircularLinkedList();
            CreatLinkedList(circularLinked);
            circularLinked.DeleteFirst();
            circularLinked.DeleteLast();
            circularLinked.DisplayList();
            

        }

        private static void CreatLinkedList(CircularLinkedList circularLinkedList)
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
                circularLinkedList.InsertEnd(data);
            }
        }
    }
}
