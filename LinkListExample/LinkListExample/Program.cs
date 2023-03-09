namespace LinkListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * UC-01-Lets create a simple Linked List of 56, 30 and 70
            */
            LinkedListOperation linkedListOperation =new LinkedListOperation(); //Creation Of Object Of LinkedListOperation Class
            linkedListOperation.add(56); //with using object of class we call the method add and pass data 56
            linkedListOperation.add(30); //with using object of class we call the method add and pass data 30
            linkedListOperation.add(70); //with using object of class we call the method add and pass data 70
        }
    }
}