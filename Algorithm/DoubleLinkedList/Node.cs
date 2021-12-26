using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class Node
    {
        public Node prev;
        public int info;
        public Node next;

        public Node(int val)
        {
            info = val;
            prev = null;
            next = null;
        }
    }
}
