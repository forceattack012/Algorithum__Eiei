using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SingleLinkedList
    {
        internal Node Head;

        public void InsetFront(int newValue)
        {
            Node newNode = new Node(newValue);
            newNode.next = Head;
            Head = newNode;
        }

        public void InsertLast(int newValue)
        {
            Node newNode = new Node(newValue);
            if(Head == null)
            {
                Head = newNode;
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.next = newNode;

        } 

        public Node GetLastNode()
        {
            Node temp = Head;
            while(temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

        public void InsertBetweenNode(Node prvNode,int data)
        {
            if(prvNode == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            Node newNode = new Node(data);
            newNode.next = prvNode.next;
            prvNode.next = newNode;
        }

        public void DeleteNodeByData(int data)
        {
            Node prev = null;
            Node temp = Head;

            if(temp != null && temp.data == data)
            {
                Head = temp.next;
                return;
            }

            while(temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }

            if(temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void PrintAllNode()
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                Console.Write(currentNode.data + " -> ");
                currentNode =  currentNode.next;
            }
        }

        public Node GetNodes()
        {
            Node nodes = Head;

            return nodes;
        }
    }
}
