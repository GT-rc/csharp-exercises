using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int times;

            Console.WriteLine("What is your name?");
            input = Console.ReadLine();

            Console.WriteLine("What number?");
            times = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + input + " you like: " + times);
            //should convert times to string before concatenating

            //Console.WriteLine(string.Format("Hello, {0}", name));
            //example from class using 'string interpolation' instead of concatenation

            Console.ReadLine();
            //Also option: Console.Read()
        }
    }
}
