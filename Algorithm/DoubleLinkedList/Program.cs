using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoubleLinkedListCls doubleLinkedListCls = new DoubleLinkedListCls();
            CreateDoubleLinkedList(doubleLinkedListCls);

            doubleLinkedListCls.ReverseList();
            doubleLinkedListCls.DisplayNodes();

        }

        private static void CreateDoubleLinkedList(DoubleLinkedListCls doubleLinkedListCls)
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
                doubleLinkedListCls.InsertAtEnd(data);
            }
        }
    }
}
