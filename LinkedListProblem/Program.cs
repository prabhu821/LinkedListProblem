﻿namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Problem!");
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Linked List \n2.Display \n3.Add In Reverse Order " +
                    "\n4.Add At Particular Position \n5.Remove First Node \n6.Remove Last Node \n7.Search \n8.Size of List " +
                    "\n9.Insert at Particular Position \n10.Delete Node At Particular Position \n11.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        Console.WriteLine("Added in Reverse Order");
                        break;
                    case 4:
                        Console.WriteLine("Enter position and value u want to insert");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        int value = Convert.ToInt32(Console.ReadLine());
                        list.AddAtParticularPosition(pos, value);
                        break;
                    case 5:
                        list.RemoveFirstNode();
                        break;
                    case 6:
                        list.RemoveLastNode();
                        break;
                    case 7:
                        Console.WriteLine("Enter the value present in List to find Position");
                        int option = Convert.ToInt32(Console.ReadLine());
                        int find = list.Search(option);
                        Console.WriteLine("The Position of Node in LinkedList is " + find);
                        break;
                    case 8:
                        list.Size();
                        break;
                    case 9:
                        Console.WriteLine("Enter the value to be find in the list to Insert");
                        int Insert = Convert.ToInt32(Console.ReadLine());
                        int position = list.Search(Insert);
                        Console.WriteLine("Enter the value to Insert");
                        int data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtParticuarPosition(position + 1, data);
                        break;
                    case 10:
                        Console.WriteLine("Enter the value present in List to Delete");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeAtParticularPosition(list.Search(delete));
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}