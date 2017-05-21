using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name followed by enter: ");
            string word = Console.ReadLine();
            Console.WriteLine($"Hello from the World, {word}");
        }
    }
}
