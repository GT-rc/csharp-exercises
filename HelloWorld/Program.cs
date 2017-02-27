using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("What is your name?");
            input = Console.ReadLine();
            Console.WriteLine("Hello, " + input);
            Console.ReadLine();
        }
    }
}
