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

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /*
         * UC-04-Ability to insert 30 between 56 and 70
         * i.e Ability To Insert Data At Particular Postion
         */
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0 && temp != null)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }

                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        /*
         * UC-05-Ability to delete the first element in the LinkedList of sequence 56->30->70 - Write pop method
         */
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            else
            {
                this.head = this.head.next;
                return this.head;
            }   
        }

        /*
         * UC-06-Ability to delete the last element in the LinkedList of sequence 56->30->70 - Write popLast method
         */
        internal Node RemoveLastNode()
        {
          if (head == null)
            {
                return null;
            }
                
            if (head.next == null)
            {
                return null;
            }
            else
            {
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                return head;
            }   
        }
        internal void Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Given value: " + value + " is present in Linked list");
                 
                }
                temp = temp.next;
            }
            if (temp == null)
                Console.WriteLine("Given value: " + value + " is not present in Linked list");
        }
    }
}
