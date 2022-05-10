using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class Queue_LinkedList<Generic>
    {
        QNode<Generic> Front, Rear;
        public Queue_LinkedList()
        {
            this.Front = this.Rear = null;
        }
        public int Count = 0;
        public void enqueue(Generic key)
        {
            Count++;
            QNode<Generic> temp = new QNode<Generic>(key);
            if (this.Rear == null)
            {
                this.Front = this.Rear = temp;
                return;
            }
            this.Rear.Next = temp;
            this.Rear = temp;
           
        }
        public void Display()
        {
            if (Front == null)
            {
                Console.Write("Queue Underflow");
                return;
            }
            else
            {
                QNode<Generic> temp = Front;
                while (temp != null)
                {
                    Console.Write("->{0}", temp.Key);
                    temp = temp.Next;
                }
            }

        }
        public void dequeue()
        {
            if (this.Front == null)
                return;

            // Store previous front and
            // move front one node ahead
            QNode<Generic> temp = this.Front;
            this.Front = this.Front.Next;

            // If front becomes NULL,
            // then change rear also as NULL
            if (this.Front == null)
                this.Rear = null;
            Count--;
        }
    }
}
