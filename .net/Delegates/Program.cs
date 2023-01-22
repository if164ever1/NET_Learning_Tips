using System;

namespace Delegates
{
    internal abstract class Program
    {
        //private delegate void SayHello(string name);

        private static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        private static void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}");
        }
        
        public static void Main(string[] args)
        {
            //var sayHello = new SayHello(Hello);
            Action<string> sayHello;

            Func<string, string> conversation = (message) =>
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            };

            var name = conversation("What is your name");

            //Anonymous delegate
            sayHello = (greeting) =>
            {
                Console.WriteLine(greeting, name);
            };
            
            sayHello($"Hello, {name}"); 
            sayHello($"Goodbye, {name}");
        }
    }
}