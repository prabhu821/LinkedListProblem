using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if(this.head==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if(position==0)
            {
                this.head = temp.next;
                return;
            }
            for(int i=0;temp!=null && i<position-1;i++)
            {
                temp=temp.next;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if(temp!=null)
            {
                Console.WriteLine("");
            }
        }
    }
}
