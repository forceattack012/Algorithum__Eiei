using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class BinaryTree
    {
        private Node root;
        public BinaryTree()
        {
            root = null;
        }

        public void Display()
        {
            Display(root, 0);
        }
        private void Display(Node node,int level)
        {
            if(node == null)
            {
                return;
            }
            Display(node.lChlidNode, level + 1);
            Console.WriteLine();

            for(int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
            Console.Write(node.info);
            Display(node.rChlidNode,level + 1);
        }

        public int Height()
        {
            return Height(root);
        }
        private int Height(Node node)
        {
            if(node == null)
            {
                return 0;
            }
            int hL = Height(node.lChlidNode);
            int hR = Height(node.rChlidNode);

            if (hL > hR)
            {
                return hL + 1;
            }
            else
            {
                return hR + 1;
            }
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }
        private void PreOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write(node.info + " ");
            PreOrder(node.lChlidNode);
            PreOrder(node.rChlidNode);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        private void InOrder(Node node)
        {
            if(node == null)
            {
                return;
            }
            InOrder(node.lChlidNode);
            Console.Write(node.info + " ");
            InOrder(node.rChlidNode);
        }


        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }
        private void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.lChlidNode);
            PostOrder(node.rChlidNode);
            Console.Write(node.info + " ");
        }

        public void LevelOrder()
        {
            Node p;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count() != 0)
            {
                p = queue.Dequeue();
                Console.Write(p.info + " ");
                if (p.lChlidNode != null)
                {
                    queue.Enqueue(p.lChlidNode);
                }
                if(p.rChlidNode != null)
                {
                    queue.Enqueue(p.rChlidNode);
                }
            }
            Console.WriteLine();
        }
        public void Create()
        {
            root = new Node('A');
            root.lChlidNode = new Node('B');
            root.rChlidNode = new Node('C');
            root.rChlidNode.lChlidNode = new Node('E');
        }
    }
}
