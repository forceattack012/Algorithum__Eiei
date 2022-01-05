using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class Node
    {
        public Node lChlidNode;
        public char info;
        public Node rChlidNode;

        public Node(char c)
        {
            info = c;
            lChlidNode = null;
            rChlidNode = null;
        }
    }
}
