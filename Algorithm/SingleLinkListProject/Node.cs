using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkListProject
{
    public class Node<T> 
    {
        public T Info;
        public Node<T>? Link;

        public Node(T value)
        {
            Info = value;
            Link = null;
        }
    }
}
