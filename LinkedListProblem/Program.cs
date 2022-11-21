using System;
namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome tp Linked List operation");
        //    LinkedListStack stack =new LinkedListStack();
        //    stack.Push(50);
        //    stack.Push(70);
        //    stack.Push(30);
        //    stack.Display();
        //    stack.Peek();
        //    stack.Pop();
        //    stack.Display();

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(50);
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }

    }
}