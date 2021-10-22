using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        internal int data;
        internal Node next;

        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
}
