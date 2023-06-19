using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListProblem;

public class LinkedList
{
    //UC1-Create Linked List
    public Node head;
    public void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        Console.WriteLine("{0} inserted into linked list", node.data);
    }

    //UC2-Display List
    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data);
            if (current.next != null)
            {
                Console.Write("->");
            }
            current = current.next;
        }
        Console.WriteLine();
    }

    //UC3-ADD IN REVERSE ORDER
    public void AddInReverseOrder(int data)
    {
        Node newNode = new Node(data);
        if (this.head == null)
        {
            this.head = newNode;
        }
        else
        {
            Node temp = this.head;
            head = newNode;
            head.next = temp;
        }
    }

    //UC4-Add at Particular Position
    internal Node InsertAtParticularPosition(int position, int data)
    {
        Node newestNode = new Node(data);
        if (this.head == null)
        {
            return newestNode;
        }
        if (position == 0)
        {
            newestNode.next = this.head;
            this.head = newestNode;
            return this.head;
        }
        Node prev = null;
        Node current = this.head;
        int count = 0;
        while (current != null && count < position)
        {
            prev = current;
            current = current.next;
            count++;
        }
        newestNode.next = prev.next;
        prev.next = newestNode;
        return this.head;
    }
}
