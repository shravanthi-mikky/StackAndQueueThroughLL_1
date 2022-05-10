using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class QNode<Generic>
    {
        public Generic Key;
        public QNode<Generic> Next;
        public QNode(Generic Key)
        {
            this.Next = null;
            this.Key = Key;
        }
    }
}
