using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string startOfAlice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string str = startOfAlice.ToLower();
            string subString;
            bool isAppearing;

            Console.WriteLine("What string should I search for?");
            subString = Console.ReadLine();
            string str1 = subString.ToLower();
            
            isAppearing = str.Contains(str1);
            
            Console.WriteLine(isAppearing);
            Console.ReadLine();

        }
    }
}
