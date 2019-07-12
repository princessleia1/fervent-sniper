using System;

namespace GradeCredit
{
    class Program
    {
        /* Write a console-based application using loops with an array.
         * Print 5 students their grades plus extra 3 credits. 
         */
        static void Main(string[] args)
        {
            int[] grades = { 66, 68, 95, 90, 100 };

            for(int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }

            // for (int i = 0; i < 11; i++)
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            // Without loop
            int[] grade = { 66, 68, 95, 90, 100 };
            grade[0] += 3;
            grade[1] += 3;
            grade[2] += 3;
            grade[3] += 3;
            grade[4] += 3;
            Console.WriteLine(grade[2]);

            // Foreach loop steps inside the array 
            // Print the values read-only in the array
            foreach(int score in grades)
            {
                score += 3;
                Console.WriteLine(score);
            }
        }
    }
}
