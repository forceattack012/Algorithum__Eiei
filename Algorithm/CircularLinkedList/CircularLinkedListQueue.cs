using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class CircularLinkedListQueue
    {
        private Node rear;
        public CircularLinkedListQueue()
        {
            rear = null;
        }

        public void Enqueue(int data)
        {
            var newNode = new Node(data);
            if(rear == null)
            {
                rear = newNode;
                rear.next = newNode;
            }
            else
            {
                newNode.next = rear.next;
                rear.next = newNode;
                rear = newNode;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("queue undeflow");
            }
            Node temp;
            if(rear == rear.next) //One Node
            {
                temp = rear;
                rear = null;
            }
            else
            {
                temp = rear.next;
                rear.next = temp.next;
            }

            return temp.info;
        }
        public bool IsEmpty()
        {
            return rear == null;
        }
        public int Size()
        {
            int size = 0;
            if (IsEmpty())
            {
                return 0;
            }
            var p = rear.next;

            do
            {
                size++;
                p = p.next;
            } while (p != rear.next);
            return size;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("queue undeflow");
            }
            return rear.next.info;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("queue undeflow");
            }

            var p = rear.next;
            do
            {
                Console.Write("Info " + p.info);
                p = p.next;
            }while(p != rear.next);
        }
    }
}
