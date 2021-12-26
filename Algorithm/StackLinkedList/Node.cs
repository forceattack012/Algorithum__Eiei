using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    public class Node<T> 
    {
        public T info;
        public Node<T> next;

        public Node(T data)
        {
            info = data;
            next = null;
        }
    }
}
