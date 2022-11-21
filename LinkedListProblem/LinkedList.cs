using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
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
