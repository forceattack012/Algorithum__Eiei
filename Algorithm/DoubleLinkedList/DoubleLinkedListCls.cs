using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedListCls
    {
        private Node start;
        public DoubleLinkedListCls()
        {
            start = null;
        }

        public void DisplayNodes()
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node p = start;
            while (p != null)
            {
                Console.WriteLine("List is : "+p.info);
                p = p.next;
            }
        }

        public void InsertAtBegin(int val)
        {
            Node newNode = new Node(val);
            if(start == null)
            {
                start = newNode;
                return;
            }
            newNode.next = start;
            start.prev = newNode;
            start = newNode;
        }

        public void InsertAtEnd(int val)
        {
            Node newNode = new Node(val);
            if(start == null)
            {
                start = newNode;
                return;
            }

            Node p = start;
            while(p.next != null)
            {
                p = p.next;
            }
            p.next = newNode;
            newNode.prev = p;
        }

        public void InsertAfterNode(int newValue, int x)
        {
            Node p = start;
            while(p.next != null)
            {
                if(p.info == x)
                {
                    break;
                }
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine($"{x} not present in List");
                return;
            }
            else
            {
                Node newNode = new Node(newValue);
                newNode.prev = p;          
                if(p.next != null)
                {
                    p.next.prev = newNode;
                    newNode.next = p.next;
                }
                p.next = newNode;
            }
        }

        public void InsertBeginNode(int newValue, int x)
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if(start.info == x)
            {
                Node newNode = new Node(newValue);
                newNode.prev = start;
                start.next = newNode;
                start = newNode;
                return;
            }

            Node p = start;
            while (p.next != null)
            {
                if(p.info == x)
                {
                    break;
                }
                p = p.next;
            }

            if (p == null)
            {
                Console.WriteLine($"{x} not present in List");
                return;
            }
            else
            {
                Node newNode = new Node(newValue);
                newNode.next = p;
                newNode.prev = p.prev;
                p.prev.next = newNode;
                p.prev = newNode;
            }
        }

        public void insertAtIndex(int index,int val)
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node p = start;
            for(int i=0; i!=index && p.next != null; i++)
            {
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine($"{index} index not found");
                return;
            }
            else
            {
                Node newNode = new Node(val);
                newNode.next = p;
                newNode.prev = p.prev;
                p.prev.next = newNode;
                p.prev = newNode;
            }
        }

        public void DeleteFirstNode()
        {
            if(start == null)
            {
                return;
            }
            if(start.next == null)
            {
                start = null;
                return;
            }

            start = start.next;
            start.prev = null;
        }

        public void DeleteLastNode()
        {
            if(start == null)
            {
                return;
            }
            Node p = start;

            while(p.next != null)
            {
                p = p.next;
            }
            p.prev.next = null;
        }

        public void DeleteBetweenNode(int x)
        {
            if(start == null)
            {
                return;
            }

            Node p = start;
            while(p.next != null)
            {
                if(p.info == x)
                {
                    break;
                }
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine($"{x} not found");
                return;
            }
            else
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
        }

        public void ReverseList()
        {
            if (start == null)
            {
                return;
            }

            Node p1 = start;
            Node p2 = start.next;
            p1.next = null;
            p1.prev = p2;
            while(p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            start = p1;
        }
    }
}
