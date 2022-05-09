using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class QNode
    {
        public int Key;
        public QNode Next;
        public QNode(int Key)
        {
            this.Next = null;
            this.Key = Key;
        }
    }
}
