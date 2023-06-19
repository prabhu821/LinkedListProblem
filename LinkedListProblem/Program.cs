namespace LinkedListProblem
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
                     "\n4.Add At Particular Position \n5.Exit");
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
                        list.InsertAtParticularPosition(pos, value);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}