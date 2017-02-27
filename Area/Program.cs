using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputLength;
            string inputWidth;
            int length;
            int width;
            int area;

            Console.WriteLine("What is the Length of the rectangle?");
            inputLength = Console.ReadLine();
            length = int.Parse(inputLength);

            Console.WriteLine("What is the width of the rectangle?");
            inputWidth = Console.ReadLine();
            width = int.Parse(inputWidth);

            area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
