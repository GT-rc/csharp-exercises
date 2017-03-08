using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharachters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<char, int> charachters = new Dictionary<char, int>();
            int letterCount;
            string phrase = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. 
                            Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac 
                            suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            string phraseLower = phrase.ToLower();

            foreach (char letter in phraseLower)
            {
                // exclude non-alpha chars
                if (letter < 'a' || letter > 'z')
                {
                    continue;
                }

                if (charachters.ContainsKey(letter))
                {
                    charachters[letter] += 1;
                }
                else
                {
                    charachters.Add(letter, 1);
                }

            }

            Console.WriteLine("Charachters: ");

            foreach (KeyValuePair<char, int> charachterCount in charachters)
            {
                Console.WriteLine(String.Format("{0}: {1}", charachterCount.Key, charachterCount.Value));
            }


            Console.ReadLine();
        }
    }
}
