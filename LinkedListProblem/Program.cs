using System;
namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List operation");
            
            //  LinkedList list = new LinkedList();
            //  list.Add(50);
            //  list.Add(70);
            //  list.Add(30);
            //  list.Display();
            //  int a = list.Search(30);
            //  list.InsertAtParticularPosition(a + 1, 40);
            //  list.Display();
            //  list.DeleteNodeAtParticularPosition(2);
            //  list.Size();
            //  list.Display();



              LinkedListStack stack =new LinkedListStack();
              stack.Push(50);
              stack.Push(70);
              stack.Push(30);
              stack.Display();
            //  stack.Peek();
            //  stack.Pop();
            //  stack.Display();



            //  LinkedListQueue queue = new LinkedListQueue();
            //  queue.Enqueue(50);
            //  queue.Enqueue(70);
            //  queue.Enqueue(30);
            //  queue.Display();
            //  queue.Dequeue();
            //  queue.Display();
        
        
        }
    }
}