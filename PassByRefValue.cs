using System;

namespace PassByRefValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Structures or value type get passed by value
            // Pass by value
            int student1Grade = 75;
            Console.WriteLine("Student's Grade BEFORE Extra Credit {0}.", student1Grade);
            GiveExtraCredit(student1Grade);
            Console.WriteLine("Student's Grade AFTER Extra Credit {0}.", student1Grade);

            // Expected output:
            //Student's Grade BEFORE Extra Credit 75.
            //Student's Grade AFTER Extra Credit Inside Function 78.
            //Student's Grade AFTER Extra Credit 75.

            // Pass by reference 
            // Classes are reference types, when you see new
            // Passing a memory location
            int[] grades = new int[1];
            grades[0] = 75;
            Console.WriteLine("Student Array BEFORE Extra Credit {0}.", grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Student Array AFTER Extra Credit {0}.", grades[0]);

            // Expected output:
            // Student Array BEFORE Extra Credit 75.
            // Student Array AFTER Extra Credit 78.
        } 
        // Pass by values 
        // Passes a copy
        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine("Student's Grade AFTER Extra Credit Inside Function {0}.", studentsGrade);
        }
        // Pass by reference
        // Passes the entire array itself
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }
    }
}
