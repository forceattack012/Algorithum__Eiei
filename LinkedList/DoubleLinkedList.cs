using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoubleLinkedList
    {
        internal DoubleNode Head;

        public void InsertFront(int data)
        {
            DoubleNode newNode = new DoubleNode(data);
            newNode.next = Head;
            newNode.prev = null;

            if(Head != null)
            {
                Head.prev = newNode;
            }
            Head = newNode;
        }

        public void InsertLastNode(int data)
        {
            DoubleNode newNode = new DoubleNode(data);
            if(Head == null)
            {
                Head.next = newNode;
                Head.prev = null;
                return;
            }

            DoubleNode lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;

        }

        public void InsertBetween(DoubleNode prevNode,int data)
        {
            if(prevNode == null)
            {
                return;
            }

            DoubleNode newDoubleNode = new DoubleNode(data);
            newDoubleNode.next = prevNode.next;
            prevNode.next = newDoubleNode;
            newDoubleNode.prev = prevNode;

            if(newDoubleNode.next != null)
            {
                newDoubleNode.next.prev = newDoubleNode;
            }
        }

        public DoubleNode GetLastNode()
        {
            DoubleNode tempNode = Head;
            while(tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

            return tempNode;
        }

        public DoubleNode GetNodes()
        {
            return Head;
        }
    }
}
