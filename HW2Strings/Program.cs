using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW2Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your studnets (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            } while (newStudent != "");

            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }
            
            Console.WriteLine("\nClass roster:");

            /*
            for (int i=0; i< students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }
            */

            System.Text.StringBuilder phrase = new System.Text.StringBuilder();
            for (int i = 0; i < students.Count; i++)
            {
                phrase.Append(students[i]).Append(" (").Append(grades[i]).Append(")\n");
            }
            Console.WriteLine(phrase);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
            }
        }
    }

