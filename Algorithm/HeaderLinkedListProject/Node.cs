using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderLinkedListProject
{
    public class Node
    {
        public int info;
        public Node link;

        public Node(int value)
        {
            info = value;
            link = null;
        }
    }
}
