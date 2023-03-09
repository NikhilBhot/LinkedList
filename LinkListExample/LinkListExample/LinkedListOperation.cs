using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListExample
{
    public class LinkedListOperation
    {
        internal Node head;
        internal void add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null) 
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} INSERTED INTO LINKED LIST",node.data);
        }
    }
}
