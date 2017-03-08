using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sequence = { 1, 1, 2, 3, 5, 8 };

            foreach (int var in sequence)
            {
                Console.WriteLine(var);
            }

            Console.ReadLine();
        }
    }
}
