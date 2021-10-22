using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoubleNode
    {
        internal int data;
        internal DoubleNode prev;
        internal DoubleNode next;

        public DoubleNode(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }
}
