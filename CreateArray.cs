using System;

namespace CreateArray
{
    class Program
    {
        /* Write a console-based application that mber.
         * Indicate whether the user's guess was too high, too low, or correct.
         * Use loop for this solution.
         */
        static void Main(string[] args)
        {
            // Create array
            // 100 integers in an array with no values default 0
            int[] myArray = new int[100]; // Allocating mem in a different spot for many

            // Element is all individual integers or items in the array
            // Index is the number how we access it
            int[] myArray = new int[3]; // 0, 1, 2 in the array
            myArray[0] = 5; // Allocate 0  to 5
            myArray[1] = 6;
            myArray[2] = 7;
            //myArray[3] = 10;    // Causes exeption as crossing boundary no mem allocated in ram
            
            // Output to console 
            Console.WriteLine(myArray[2]);
        }
    }
}
