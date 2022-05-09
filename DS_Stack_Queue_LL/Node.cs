using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class Node<T>
    {
        public T data;
        public Node<T> link;
        public Node()
        {
            this.link = null;
        }
    }
}
