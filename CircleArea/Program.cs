using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius = 0;
            double area = 0;
            string input = " ";
            bool isDouble = false;

            Console.WriteLine("Let's find the area of a circle!");
            Console.WriteLine("What is the radius?");

            do
            {
                input = Console.ReadLine();
                while (input != "")
                {
                    isDouble = double.TryParse(input, out radius);
                    if (isDouble == true)
                    {
                        continue;
                    } else
                    {
                        Console.WriteLine("Please enter a valid value.");
                        input = Console.ReadLine();
                    }
                }
                while (radius > 1)
                {
                    Console.WriteLine("Please enter a valid value.");
                    radius = double.Parse(Console.ReadLine());
                }
                
            } while (radius == 0);

            //input = Console.ReadLine();
            //validation should go here?

            //isDouble = double.TryParse(input, out radius);

            //while (input != null)
            //{
            //    if (double,TryParse(input, out radius) == false)
            //    {
            //        Console.WriteLine("Please enter a valid value.");
            //        input = Console.ReadLine();
            //        isDouble = double.TryParse(input, out radius);
            //    }
            //}




            //if (isDouble == true)
            //{
            //    continue;
            //} else
            //{
            //    Console.WriteLine("Please enter a valid value.");
            //    radius = double.Parse(Console.ReadLine());
            //}

            //make validation a while loop and put # check while loop back inside so it can check info entered

            //while (radius < 1)
            //{
            //    Console.WriteLine("Please enter a valid value.");
            //    radius = double.Parse(Console.ReadLine());
            //}

            //area = Math.PI * Math.Pow(radius, 2);


            area = Math.PI * radius * radius;

            Console.WriteLine(String.Format("The area of the circle with radius {0} is: {1:0.###}.", radius, area));
            Console.Read();
        }
    }
}
