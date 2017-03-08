using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            /*
             * Random rnd = new Random();
             * for (int i=0; i < 10; i++) {
             * randomNum = rnd.Next(1, 50);
             * numberstoSum.Add(randomNum);
             * Console.Write(string.Format("{0} ", randomNum); }
             * 
             * foreach (int num in numbersToSum) {
             * sum += num; }
             * 
             * */


            for (int i=0; i < 10; i++)
            {
                integers.Append(i);
                Console.WriteLine(i);
            }

            int total = 0;
            foreach (int i in integers)
            {
                total = total + i;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }

        /*
        public static int Word(List<int> argitems)
        {
            int total = 0;
            foreach (int i in argitems)
            {
                total = total + i;
            }
            return total;
        } */
    }
}
