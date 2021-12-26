using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListProject
{
    public class CircularLinkedList
    {
        private Node last;
        public CircularLinkedList()
        {
            last = null;
        }
        public void DisplayList()
        {
            if(last == null)
            {
                return;
            }

            Node p = last.link;
            do
            {
                Console.WriteLine("List is : " + p.info);
                p = p.link;
            } while (p != last.link);
        }
        public void InsertBegin(int val)
        {
            Node newNode = new Node(val);
            if(last == null)
            {
                last = newNode;
                last.link = last;
                return;
            }
            newNode.link = last.link;
            last.link = newNode;
        }

        public void InsertEnd(int val)
        {
            Node newNode = new Node(val);
            if (last == null)
            {
                last = newNode;
                last.link = last;
                return;
            }
            newNode.link = last.link;
            last.link = newNode;
            last = newNode;
        }

        public void DeleteFirst()
        {
            if(last == null)
            {
                last = null;
                return;
            }
            last.link = last.link.link;
        }

        public void DeleteLast()
        {
            if(last == null)
            {
                return;
            }

            Node p = last.link;
            while(p.link != last.link)
            {
                p = p.link;
            }
            p.link = last.link;
            last = p;
        }

        public void Concatenate(CircularLinkedList list)
        {
            if (last == null)
            {
                last = list.last;
            }
            if (list.last == null)
            {
                return;
            }
            var p = last.link;
            last.link = list.last;
            list.last = p;
            
        }
    }
}
