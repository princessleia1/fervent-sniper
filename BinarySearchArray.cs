using System;

namespace BinarySearchArray
{
    class Program
    {
        /* Binary search array Array.BinarySearch
         * Binary search is faster
         * Data needs to be sorted; useful functions sort, reverse
         */
        
        static void Main(string[] args)
        {
            int[] myArray = { 10, 15, 20, 30, 35, 40, 45 };
            Console.WriteLine("Enter number to check if it exists:");
            int number = int.Parse(Console.ReadLine());
            int answer = Array.BinarySearch(myArray, number);
            if (answer < 0)
            {
                Console.WriteLine("The number does NOT EXIST.");
            }
            else
            {
                Console.WriteLine("The number DOES EXIST.");
            }

            // Sort function
            int[] myArray2 = { 10, 5, 7, 2, 55 };
            Array.Sort(myArray2);
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            // Reverse function
            int[] myArray3 = { 10, 5, 7, 2, 55 };
            Array.Reverse(myArray3);
            for (int i = 0; i < myArray3.Length; i++)
            {
                Console.WriteLine(myArray3[i]);
            }
        }
    }
}
