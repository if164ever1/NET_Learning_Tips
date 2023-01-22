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
            //Anonymous delegate
            sayHello = delegate(string name1)
            {
                Console.WriteLine($"Hello, {name1}");
            };
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            sayHello(name);
            sayHello = delegate(string name1)
            {
                Console.WriteLine($"Goodbye, {name}");
            };
            sayHello(name);
            
            
            
        }
    }
}