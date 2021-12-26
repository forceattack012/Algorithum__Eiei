using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueProject
{
    public class Node
    {
        public int info;
        public int priority;
        public Node link;

        public Node(int value, int priority)
        {
            info = value;
            this.priority = priority;
            link = null;
        }
    }
}
