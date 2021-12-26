using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicularQueueProject
{
    public class CicularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public CicularQueue()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }
        public CicularQueue(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear= -1;
        }
        public bool IsEmpty()
        {
            return front == -1;
        }
        public bool IsFull()
        {
            return (front == rear + 1) || (front == 0 && rear == queueArray.Length - 1);
        }
        public void Enqueue(int data)
        {
            if (IsFull())
            {
                return;
            }
            if(front == -1)
            {
                front = 0;
            }
            else if(rear == queueArray.Length - 1)
            {
                rear = 0;
            }
            else
            {
                rear += 1;
            }
            queueArray[rear] = data;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("");
            }
            var data = queueArray[front];
            if(front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if(front == queueArray.Length - 1)
            {
                front = 0;
            }
            else
            {
                front += 1;
            }
            return data;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                throw new Exception("");
            }
            int i = front;
            if(front <= rear)
            {
                while(i <= rear)
                {
                    Console.Write($"{queueArray[i++]}");
                    i++;
                }
            }
            else
            {
                while(i <= queueArray.Length - 1)
                {
                    Console.Write($"{queueArray[i++]}");
                }
                i = 0;
                while(i <= rear)
                {
                    Console.Write($"{queueArray[i++]}");
                }
            }
        }
    }
}
