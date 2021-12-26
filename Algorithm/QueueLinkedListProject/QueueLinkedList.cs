using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedListProject
{
    public class QueueLinkedList
    {
        private Node front;
        private Node rear;
        public QueueLinkedList()
        {
            front = null;
            rear = null;
        }
        public int Size()
        {
            int size = 0;
            var p = front;
            while(p != null)
            {
                size++;
                p = p.link;
            }
            return size;
        }

        public void Enqueue(int val)
        {
            var newNode = new Node(val);
            if(front == null)
            {
                front = newNode;
            }
            else
            {
                rear.link = newNode;
            }
            rear = newNode;
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }
            var data = front.info;
            front = front.link;
            return data;
        }
        public bool IsEmpty()
        {
            return front == null;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }
            return front.info;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }

            var p = front;
            while(p != null)
            {
                Console.Write($"info : {p.info} ");
                p = p.link;
            }
        }
    }
}
