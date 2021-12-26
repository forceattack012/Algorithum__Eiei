using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArrayProject
{
    public class QueueArray
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public QueueArray()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueArray(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear= -1;
        }

        public bool IsEmpty()
        {
            return front == -1 || front == rear + 1;
        }

        public bool IsFull()
        {
            return rear == queueArray.Length - 1;
        }
        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }
            return rear - front + 1;
        }

        public void Enqueue(int data)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Queue Overflow");
            }
            if(front == -1)
            {
                front++;
            }
            rear += 1;
            queueArray[rear] = data;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }
            var value = queueArray[front];
            front += 1;
            return value;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }
            return queueArray[front];
        }

        public void Display()
        {
            for(int i = front; i <= rear; i++)
            {
                Console.Write($"info : {queueArray[i]}\n");
            }
        }
    }
}
