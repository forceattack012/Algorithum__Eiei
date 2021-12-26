using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueProject
{
    public class PriorityQueue
    {
        private Node front;
        public PriorityQueue()
        {
            front = null;
        }
        public bool isEmpty()
        {
            return front == null;
        }
        public void Insert(int value,int newPriority)
        {
            var newNode = new Node(value, newPriority);
            if(isEmpty() || newPriority < front.priority)
            {
                newNode.link = front;
                front = newNode;
            }
            else
            {
                var p = front;
                while(p.link != null && p.link.priority <= newPriority)
                {
                    p = p.link;
                }
                newNode.link = p.link;
                p.link = newNode;
            }
        }

        public int Delete()
        {
            if (isEmpty())
            {
                throw new Exception("");
            }
            int element = front.info;
            front = front.link;
            return element;
        }

        public void Display()
        {
            if (isEmpty())
            {
                return;
            }
            Node p = front;
            while(p != null)
            {
                Console.WriteLine("Priority : " + p.priority + "value : " + p.info + "\n");
                p = p.link;
            }
        }
    }
}
