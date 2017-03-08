using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook_exercise_arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxStudents = 30;

            string[] students = new string[maxStudents];
            double[] grades = new double[maxStudents];

            string newStudent;
            int numStudents = 0;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students[numStudents] = newStudent;
                    numStudents++;
                }
            } while (newStudent != " && numStudents < maxStudents");

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for " + students[i] + ": ");
                double studentGrade = double.Parse(Console.ReadLine());
                grades[i] = studentGrade;
            }

            Console.WriteLine("\nClass roster:");
            double sum = 0;

            for (int j = 0; j < numStudents; j++)
            {
                Console.WriteLine(students[j] + " (" + grades[j] + ")");
                sum += grades[j];
            }

            double avg = sum / numStudents;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
