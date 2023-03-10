using System.Collections.Generic;

namespace LinkListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * UC-01-Lets create a simple Linked List of 56, 30 and 70
             * UC-02-Ability to create Linked List by adding 30 and 56 to 70
             * UC-03Ability to create Linked List by appending 30 and 70 to 56
            */
            LinkedListOperation linkedListOperation =new LinkedListOperation(); //Creation Of Object Of LinkedListOperation Class
            linkedListOperation.add(30); //with using object of class we call the method add and pass data 56
            linkedListOperation.add(70); //with using object of class we call the method add and pass data 30
            linkedListOperation.add(56); //with using object of class we call the method add and pass data 70
            linkedListOperation.Display();
            /*
              * UC-04-Ability to insert 30 between 56 and 70
              * i.e Ability To Insert Data At Particular Postion
            */
            linkedListOperation.InsertAtParticularPosition(2, 81);
            Console.WriteLine();
            linkedListOperation.Display();
            /*
              * UC-05-Ability to delete the first element in the LinkedList of sequence 56->30->70 - Write pop method
            */
            Console.WriteLine("\nRemoving First Element");
            linkedListOperation.RemoveFirstNode();
            Console.WriteLine();
            linkedListOperation.Display();
            Console.WriteLine("\nRemoving Last Element");
            linkedListOperation.RemoveLastNode();
            linkedListOperation.Display();
        }
    }
}