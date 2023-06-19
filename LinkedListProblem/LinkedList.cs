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

    //UC4 & UC8-Add at Particular Position
    public Node AddAtParticularPosition(int position, int data)
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

    //UC5-Remove First Node
    public void RemoveFirstNode()
    {
        if (this.head == null)
        {
            Console.WriteLine("LinkedList is empty");
        }
        this.head = this.head.next;
        Console.WriteLine("First element is deleted successfully");
    }

    //UC6-Remove Last Node
    public void RemoveLastNode()
    {
        if (this.head == null)
        {
            Console.WriteLine("LinkedList is empty");
        }
        if (head.next == null)
        {
            head = null;
        }
        Node lastNode = this.head;
        while (lastNode.next.next != null)
        {
            lastNode = lastNode.next;
        }
        lastNode.next = null;
        Console.WriteLine("Last element is deleted successfully");
    }

    //UC7-Search
    public int Search(int value)
    {
        Node node = this.head;
        if (node == null)
            return -1;
        int count = 0;
        while (node != null)
        {
            if (node.data == value)
            {
                return count;
            }
            node = node.next;
            count++;
        }
        return count;
    }

    //Size
    public void Size()
    {
        Node temp = this.head;
        int count = 0;
        if (temp == null)
        {
            Console.WriteLine("LinkedList is empty");
        }
        Console.Write("LinkedList is as : ");
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
            count++;
        }
        Console.WriteLine("\nSize of LinkedList is " + count);
    }

    //UC9-Insert at Particular Position
    public Node InsertAtParticuarPosition(int position, int data)
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
        Console.WriteLine("Value is Successfully Inserted in LinkedList");
        Display();
        return this.head;

    }
}
