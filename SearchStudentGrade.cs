using System;

namespace SearchStudentGrade
{
    class Program
    {
        /* Write a console application that asks a user to enter a student's name.
         * If the student is found indicate that they are found and their associated grade.
         * Indicate to the user if the student is not found.
         * Use a parallel array.
         */

        static void Main(string[] args)
        {
            // String array
            string[] students = { "Han", "Leia", "Obi-Wan", "Luke" };
            int[] grades = { 77, 50, 78, 99 };

            Console.WriteLine("Enter Students Name to Search for:");
            string studentName = Console.ReadLine();

            // Logic
            bool contains = false;
            int studentGrade = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (studentName == students[i])
                {
                    contains = true;
                    studentGrade = grades[i];
                    break;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("The student is FOUND");
                Console.WriteLine("The student's Grade is {0}", studentGrade);
            }
            else
            {
                 Console.WriteLine("The student is NOT FOUND");
            }
        }
    }
}
