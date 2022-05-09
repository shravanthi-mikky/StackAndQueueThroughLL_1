using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class Queue_LinkedList
    {
        QNode Front, Rear;
        public Queue_LinkedList()
        {
            this.Front = this.Rear = null;
        }
        public int Count = 0;
        public void enqueue(int key)
        {
            Count++;
            QNode temp = new QNode(key);
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
                QNode temp = Front;
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
            QNode temp = this.Front;
            this.Front = this.Front.Next;

            // If front becomes NULL,
            // then change rear also as NULL
            if (this.Front == null)
                this.Rear = null;
            Count--;
        }
    }
}
