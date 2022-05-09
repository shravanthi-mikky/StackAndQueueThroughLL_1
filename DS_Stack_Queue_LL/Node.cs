using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class Node
    {
        public int data;
        public Node link;
        public Node(int data)
        {
            this.data = data;
            this.link = null;
        }
    }
}
