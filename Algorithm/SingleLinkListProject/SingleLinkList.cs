using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListProject
{
    public class SingleLinkList<T> 
    {
        internal Node<T>? start;

        public SingleLinkList()
        {
            this.start = null;
        }

        public void DisplayNodes()
        {
            if(start == null)
            {
                Console.WriteLine("Node is Emppty");
                return;
            }

            Node<T>? p = start;
            while(p != null)
            {
                Console.WriteLine(p.Info + " ");
                p = p.Link;
            }

            Console.WriteLine();
        }

        public void CountNodes()
        {
            int count = 0;
            Node<T>? p = start;

            while (p != null)
            {
                count++;
                p = p.Link;
            }
            Console.WriteLine("Number of Node in List {0}", count);
        }

        public bool Search(T x)
        {
            Node<T>? p = start;
            while(p != null)
            {
                if(p.Info.Equals(x))
                {
                    break;
                }
                p = p.Link;
            }

            if(p == null)
            {
                Console.WriteLine(x + "Not Found in List");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Node<T> GetLastNode()
        {
            Node<T>? p = start;
            Node<T>? lastNode;

            while(p.Link != null)
            {
                p = p.Link;
            }
            lastNode = p;

            return lastNode;
        }

        public Node<T> GetNodeByIndex(int index)
        {
            Node<T>? p = start;
            for (int i = 0; i < index && p != null; i++)
            {
                p = p.Link;
            }

            return p;
        }

        public void InsertInBeginNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Link = start;
            start = newNode;
        }
        public void InsertAtEndNode(T data)
        {
            Node<T>? p;
            Node<T> newNode = new Node<T>(data);
            if(start == null)
            {
                start = newNode;
                return;
            }

            p = start;
            while(p.Link != null)
            {
                p = p.Link;
            }
            p.Link = newNode;
        }

        public void InsertAfter(T data, T x)
        {
            Node<T> p = start;

            while(p.Link != null)
            {
                if(p.Info.Equals(x))
                {
                    break;
                }
                p = p.Link;
            }

            if(p == null)
            {
                Console.WriteLine($"{x} not present in List");
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Link = p.Link;
                p.Link = newNode;
            }
        }

        public void InsertAtPosition(T data, int position) //position 2 3 4
        {
            int i = 0;

            if (position == 1)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Link = start;
                start = newNode;
            }

            Node<T>? p = start;
            for(i=1; i < position-1 && p != null; i++)
            {
                p = p.Link;
            }

            if(p == null)
            {
                Console.WriteLine("You can insert upto "+ i + " th position");
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Link = p.Link;
                p = newNode;
            }

        }

        public void DeleteFirstNode()
        {
            if(start == null)
            {
                return;
            }

            start = start.Link;
        }

        public void DeleteEndNode()
        {
            if(start == null)
            {
                return;
            }

            if(start.Link == null)
            {
                start = null;
                return;
            }

            Node<T>? p = start;
            while(p.Link.Link != null)
            {
                p = p.Link;
            }
            p.Link = null;
        }

        public void DeleteNode(T x)
        {
            if(start == null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            if(start.Info.Equals(x))
            {
                start = start.Link;
                return;
            }

            Node<T>? p = start;
            while (p.Link != null)
            {
                if (p.Link.Info.Equals(x))
                {
                    break;
                }
                p = p.Link;
            }

            if(p.Link == null)
            {
                Console.WriteLine("Cloud not Delete");
            }
            else
            {
                p.Link = p.Link.Link;
            }
        }
        
        public void ReverseLinkList()
        {
            Node<T>? prev, next, p;

            prev = null;
            p = start;
            while(p != null)
            {
                next = p.Link;
                p.Link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void LoopInLinkedList()
        {
            var lastNode = GetLastNode();
            lastNode.Link = start.Link.Link;
        }

        public bool HasCycle()
        {
            if(FindCycle() != null)
            {
                return true;
            }
            return false;
        }

        public void Concatenate(SingleLinkList<T> singleLinkList)
        {
            if(start == null)
            {
                start = singleLinkList.start;
            }
            if (singleLinkList.start == null)
            {
                return;
            }
            Node<T>? p = start;

            while(p.Link != null)
            {
                p = p.Link;
            }
            p.Link = singleLinkList.start;
        }
        
        private Node<T>? FindCycle()
        {
            if(start == null || start.Link == null)
            {
                return null;
            }

            Node<T> tortoise = start, rabit = start;
            while(rabit != null && rabit.Link != null)
            {
                tortoise = tortoise.Link;
                rabit = rabit.Link.Link;
                if(tortoise == rabit)
                {
                    return tortoise;
                }
            }
            return null;
        }
    }
}
