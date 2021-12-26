using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListProject
{
    public class SigngleLinkListInteger: SingleLinkList<int>
    {
        public void BubbleSortExData()
        {
            Node<int>? end, p, q;

            for(end = null; end != start.Link; end = p)
            {
                for(p = start; p.Link != end; p = p.Link)
                {
                    q = p.Link;
                    if(p.Info > q.Info)
                    {
                        int temp = p.Info;
                        p.Info = q.Info;
                        q.Info = temp;
                    }
                }
            }
        }

        public SigngleLinkListInteger Merge1(SigngleLinkListInteger list)
        {
            SigngleLinkListInteger mergeList = new SigngleLinkListInteger();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }

        public SigngleLinkListInteger Merge2(SigngleLinkListInteger list)
        {
            SigngleLinkListInteger mergeList = new SigngleLinkListInteger();
            mergeList.start = Merge2(start, list.start);
            return mergeList;
        }

        private Node<int> Merge1(Node<int> p1, Node<int> p2)
        {
            Node<int> startMerge;

            if(p1.Info <= p2.Info)
            {
                startMerge = new Node<int>(p1.Info);
                p1 = p1.Link;
            }
            else
            {
                startMerge = new Node<int>(p2.Info);
                p2 = p2.Link;
            }

            Node<int> pM = startMerge;

            while(p1 != null && p2 != null)
            {
                if (p1.Info <= p2.Info)
                {
                    pM.Link = new Node<int>(p1.Info);
                    p1 = p1.Link;
                }
                else
                {
                    pM.Link = new Node<int>(p2.Info);
                    p2 = p2.Link;
                }
                pM = pM.Link;
            }

            while(p1 != null)
            {
                pM.Link = new Node<int>(p1.Info);
                p1 = p1.Link;
                pM = pM.Link;
            }

            while (p2 != null)
            {
                pM.Link = new Node<int>(p2.Info);
                p2 = p2.Link;
                pM = pM.Link;
            }
            return startMerge;
        }
        private Node<int> Merge2(Node<int> p1, Node<int> p2)
        {
            Node<int> startM;

            if(p1.Info <= p2.Info)
            {
                startM = p1;
                p1 = p1.Link;
            }
            else
            {
                startM = p2;
                p2 = p2.Link;
            }
            Node<int> pM = startM;
            
            while(p1 != null && p2 != null)
            {
                if(p1.Info <= p2.Info)
                {
                    pM.Link = p1;
                    pM = pM.Link;
                    p1 = p1.Link;
                }
                else
                {
                    pM.Link = p2;
                    pM = pM.Link;
                    p2 = p2.Link;
                }
            }
            if(p1 == null)
            {
                pM.Link = p2;
            }
            else
            {
                pM.Link = p1;
            }
            return startM;
        }

        public void InsertOrder(int data)
        {
            Node<int> newNode = new Node<int>(data);
            if(start == null || data < start.Info)
            {
                newNode.Link = start;
                start = newNode;
                return;
            }

            var p = start;
            while(p.Link != null && p.Link.Info <= data)
            {
                p = p.Link;
            }
            newNode.Link = p.Link;
            p.Link = newNode;
        }
    }
}
