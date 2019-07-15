using System;

namespace FinalScore
{
    class Program
    {
        /* Write a program that allows a teacher to enter in an amount of students.
         * For each student ask the teacher to enter their name and final score for class.
         * When user is done entering data, print the highest grade in the class.
         * Print the average grade for the classs and their name.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of students in your class:");
            int amountOfStudents = int.Parse(Console.ReadLine());
            // Declare var
            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            // String array
            string[] studentNames = new string[amountOfStudents];
            // Grade array
            double[] grades = new double[amountOfStudents];

            // Loop required
            for(int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("Enter Student #{0} Name", i +1);
                string name = Console.ReadLine();
                studentNames[i] = name; // name is stored

                Console.WriteLine("Enter Student #{0} Grade", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                if(grade > highestGrade)
                {
                    highestGrade = grade; // Only overwrite grade if highest
                    highestGradeName = name;
                }
            }
            // Print output from loop
            averageGrade = averageGrade / amountOfStudents;
            Console.WriteLine("The Average Grade of the Class is {0}.", averageGrade);
            // double average = averageGrade / amountOfStudents;
            Console.WriteLine("The Highest Grade of the Class is {0}, and their Name was {1}.", highestGrade, highestGradeName);
        }
    }
}
