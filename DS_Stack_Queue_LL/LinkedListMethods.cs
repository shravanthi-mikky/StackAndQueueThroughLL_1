using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue_LL
{
    public class LinkedListMethods<T>
    {
        Node<T> top;
        
        public LinkedListMethods()
        {
            this.top = null;
            
        }
        private int count =0;
        public int Count
        {
            get { return count; }
        }
        public void Push(T x)
        {
            Node<T> temp = new();
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
            count++;

        }
        public bool isEmpty()
        {
            return top == null;
        }
        public T Peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
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
            count--;
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
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.Write("->{0}", temp.data);
                    temp = temp.link;
                }
            }

        }
    }
}
