using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class LinkedListMethods
    {
        Node top;
        
        public LinkedListMethods()
        {
            this.top = null;
            
        }
        public void Push(int x)
        {
            Node temp = new(x);
            if (temp == null)
            {
                Console.WriteLine("Heap overflow");
                return;
            }
            else
            {
                temp.data = x;
                temp.link = top;
                top = temp;
            }

        }
        public bool isEmpty()
        {
            return top == null;
        }
        public int Peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            top = (top).link;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("->{0}", temp.data);
                    temp = temp.link;
                }
            }

        }
    }
}
