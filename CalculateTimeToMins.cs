using System;

namespace CalculateTimeToMinutes
{
    class Program
    {
        /* Write a program that asks the user to enter a total amount of time in minutes only.
         * Print to the console the same amount of time in hours and minutes.
         */

        static void Main(string[] args)
        {
            // Read name input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0} this program converts Total Minutes only to Hours and Minutes.", name);

            // Read input of time in minutes parse string to int
            Console.WriteLine("Enter the Total Number of Minutes: ");
            int totalTimeinMinutes = int.Parse(Console.ReadLine());

            // Calculate hours and remainder using modulas
            int hours = totalTimeinMinutes / 60;
            int remainder = totalTimeinMinutes % 60;
            Console.WriteLine("The Total of Minutes ({0}) in Hours and Minutes is: {1} Hour(s) and {2} Min(s).", totalTimeinMinutes, hours, remainder);
        }
    }
}