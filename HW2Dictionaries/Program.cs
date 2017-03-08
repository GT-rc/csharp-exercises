using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List<string> students = new List<string>();
            //List<double> grades = new List<double>();
            string newStudent;
            Dictionary<string, int> students = new Dictionary<string, int>();


            Console.WriteLine("Enter your students (or ENTER to finish):\n");
            do
            {
                Console.WriteLine("Name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Console.WriteLine("ID Number: ");
                    int idNumber = int.Parse(Console.ReadLine());

                    students.Add(newStudent, idNumber);
                }
            } while (newStudent != "");

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(student.Key + " has the ID number of: " + student.Value);

            }
            /*
            Console.WriteLine("\nClass roster:");

            System.Text.StringBuilder phrase = new System.Text.StringBuilder();
            for (int i = 0; i < students.Count; i++)
            {
                phrase.Append(students[i]).Append(" (").Append(grades[i]).Append(")\n");
            }
            Console.WriteLine(phrase);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);
            */
            Console.ReadLine();
        }
    }
}
