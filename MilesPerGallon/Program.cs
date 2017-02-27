using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputMiles;
            string inputGallons;
            int miles;
            int gallons;
            int milesPerGallon;

            Console.WriteLine("How many miles have you driven?");
            inputMiles = Console.ReadLine();
            miles = int.Parse(inputMiles);

            Console.WriteLine("How many gallons of gas have you used?");
            inputGallons = Console.ReadLine();
            gallons = int.Parse(inputGallons);

            milesPerGallon = miles / gallons;
            Console.WriteLine("You're getting " + milesPerGallon + " miles to the gallon.");
            Console.ReadLine();
        }
    }
}
