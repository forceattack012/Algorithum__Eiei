using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderLinkedListProject
{
    public class HeaderLinkedList
    {
        private Node head;
        public HeaderLinkedList()
        {
            head = new Node(0);
        }

        public void DisplayLIst()
        {
            if(head.link == null)
            {
                return;
            }

            var p = head.link;
            while(p != null)
            {
                Console.Write("info is : " + p.info);
                p = p.link;
            }
        }

        public void InsertAtEnd(int val)
        {
            Node newNode = new Node(val);
            var p = head;
            while(p.link != null)
            {
                p = p.link;
            }
            p.link = newNode;
        }

        public void InsertAtBefore(int data, int x)
        {
            Node p = head;
            while(p.link != null)
            {
                if(p.info == x)
                {
                    break;
                }
                p = p.link;
            }

            if(p.link == null)
            {
                return;
            }
            else
            {
                var newNode = new Node(data);
                newNode.link = p.link;
                p.link = newNode;
            }
        }
        public void InsertPosition(int data,int position)
        {
            Node p = head;
            for(int i = 0; i < position - 1 && p != null; i++)
            {
                p = p.link;
            }

            if(p == null)
            {
                return;
            }
            else
            {
                var newNode = new Node(data);
                newNode.link = p.link;
                p.link = newNode;
            }
        }

        public void DeleteNode(int value)
        {
            var p = head;
            while(p.link != null)
            {
                if(p.link.info == value)
                {
                    break;
                }
                p = p.link;
            }
            if(p == null)
            {
                return;
            }
            else
            {
                p.link = p.link.link;
            }
        }
    }
}
