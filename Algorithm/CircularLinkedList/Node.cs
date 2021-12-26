using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class Node
    {
        public int info;
        public Node next;

        public Node(int data)
        {
            info = data;
            next = null;
        }
    }
}
