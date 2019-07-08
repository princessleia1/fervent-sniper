using System;

namespace HourlyRatePay
{
    class Program
    {
        /*
         * Write a program that prompts the user for an hourly pay rate.
         * If the value entered is less than $7.50 or greater than $99.00, display an error message
         * Otherwise display a message indicating that the rate is okay.
         */
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly pay rate:");
            double rate = double.Parse(Console.ReadLine());
            if (rate < 7.50 || rate > 99.00)
            {
                Console.WriteLine("Rate is invalid.");
            }
            else
            {
                // True
                Console.WriteLine("The Rate is valid.");
            }
        }
    }
}
