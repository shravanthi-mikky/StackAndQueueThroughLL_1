// See https://aka.ms/new-console-template for more information
using DS_Stack_Queue_LL;
while (true)
{
    Console.WriteLine("Please enter the Option to be performed :\n1) Implementation of Stack using LinkedList.\n2) Implementation of Queue using LinkedList.");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Implementation Of Stack Through LinkedList!");
            LinkedListMethods<int> ll1 = new();
            ll1.Push(70);
            ll1.Push(30);
            ll1.Push(56);
            Console.WriteLine("The Elements of the Stack are :");
            ll1.Display();
            Console.WriteLine("\n*************************************");
            int Len = ll1.Count;
            for (int i = 0; i < Len; i++)
            {
                Console.WriteLine("The top Element in stack is :" + ll1.Peek());
                ll1.Pop();
                Console.WriteLine("Number of elements in stack after pop method : " + ll1.Count);
            }
            Console.WriteLine("\n*************************************");
            break;
        case 2:
            Console.WriteLine("Implementation of Queue using LinkedList!");
            Queue_LinkedList<int> QueuqObject = new();
            QueuqObject.enqueue(70);
            QueuqObject.enqueue(30);
            QueuqObject.enqueue(56);
            Console.Write("The Elements of the Queue are :");
            QueuqObject.Display();
            Console.WriteLine("\n");
            int Len1 = QueuqObject.Count;
            Console.WriteLine("Number od elements in Queue are :"+QueuqObject.Count);
            for (int i = 0; i < Len1; i++)
            {
                QueuqObject.dequeue();
                Console.WriteLine("Number of elements in Queue after deQueue method : " + QueuqObject.Count);
            }
            Console.WriteLine("\n*************************************");
            break;
        default:
            Console.WriteLine("Please choose the correct option.");
            break;
    }
}


