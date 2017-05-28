using System;

namespace ExpressionBodied
{

    delegate string Say(string name);

    class Program
    {
        static int sum (int a, int b) => a + b;
        static int number => 10;

        static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        static string BuildMessage(Say message)
        {
            return message("New Message");
        }

        private static void DoSomething(Action action ) {
            action();
        }

        static void Main(string[] args)
        {

            Say say = SayHello;

            Console.WriteLine(say("John"));

            Say sayGoodBye = name => { return $"GoodBye {name}"; };

            Console.WriteLine(BuildMessage(message => message.ToUpper()));

            Console.WriteLine($"sum(3,4): {sum(3, 4)}");

            Action<int> action = x => Console.WriteLine(x);

            action(10);

            DoSomething(() => {
                Console.WriteLine($"test");
            });

        }
    }
}
