// See https://aka.ms/new-console-template for more information
using DS_Stack_Queue_LL;

Console.WriteLine("Implementation Of Stack Through LinkedList!");
LinkedListMethods<int> ll1 = new();
ll1.Push(70);
ll1.Push(30);
ll1.Push(56);
Console.WriteLine("The Elements of the Stack are :");
ll1.Display();
Console.WriteLine("\n*************************************");
int Len = ll1.Count;
for(int i = 0; i < Len; i++)
{
    Console.WriteLine("The top Element in stack is :"+ll1.Peek());
    ll1.Pop();
    Console.WriteLine("Number of elements in stack after pop method : "+ll1.Count);
}