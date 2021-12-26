using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    public class StackL<T>: IStackL<T>
    {
        private Node<T> top;
        public StackL()
        {
            top = null;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                return;
            }
            var p = top;
            while(p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.next;
            }
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public T Peek()
        {
            return top.info;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack overflow");
            }
            var topData = top.info;
            top = top.next;
            return topData;
        }

        public void Push(T data)
        {
            var newNode = new Node<T>(data);
            newNode.next = top;
            top = newNode;
        }

        public int Size()
        {
            int size = 0;
            var p = top;
            while (p != null)
            {
                p = p.next;
                size++;
            }
            return size;
        }
    }
}
