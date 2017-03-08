using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2ListsAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What length of word would you like?");
            
            int wordLength = int.Parse(Console.ReadLine());

            List<string> words = new List<string>
            {
                "word",
                "table",
                "the",
                "basket",
            };

            Program.PrintWordsWithCount(words, wordLength);

            Console.ReadLine();
        }

        public static void PrintWordsWithCount(List<string> words, int count)
        {
            int wordCount = 0;

            foreach (string word in words)
            {
                if (word.Length == count)
                {
                    Console.WriteLine(word);
                    wordCount += 1;
                }
            }

            Console.WriteLine(String.Format("The total number of words with {0} charachters is: {1}", count, wordCount ));
        }
            
            
            
            
            
            
            
            
            
            //string phrase = "This is a list with two five letter words in it. Wooot.";

            //LetterCount(phrase);

            //Console.ReadLine();
        //}
        /*
        public static string LetterCount(string phrase)
        {
            String substrings = phrase.Split(" ");
            //List<string> substringList = new List<string>();

            foreach (string word in substrings)
            {
                if (word.Count(char.IsLetter) == 5)
                {
                    //substringList.Append(word);
                    Console.WriteLine(word);
                }
            }
        } */
    }
}
