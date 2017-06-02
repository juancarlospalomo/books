using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
namespace GenericClass
{
    class Program
    {

        private static void useLinkedList()
        {
            var linkedList = new LinkedList<string>();
            var value = "first node";

            linkedList.addNode(value);
            value = "second node";
            linkedList.addNode(value);
            value = "third node";
            linkedList.addNode(value);
            value = linkedList.getFirstNode();
            while (value != default(string))
            {
                Console.WriteLine($"Node: {value}");
                value = linkedList.getFirstNode();
            }
        }

        private static void useQueue()
        {
            var queue = new Queue(5);
            queue.Push("First element");
            queue.Push("Second element");

            Console.WriteLine(queue.Pop<string>());
            Console.WriteLine(queue.Pop<string>());

            queue.Push("Third element");
            Console.WriteLine(queue.Pop<string>());
        }

        static void Main(string[] args)
        {
            useLinkedList();
            useQueue();
        }
    }
}
