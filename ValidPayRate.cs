using System;

namespace ValidPayRate
{
    class Program
    {
        /* Write a console-based application that prompts a user for an hourly pay rate.
         * While the user enters values less than $10.80
         * Or greater than $49.95 continue to prompt the user.
         * Before the program ends, display the total pay rate.
         */
        static void Main(string[] args)
        {
            double payRate;
            do
            {
                Console.WriteLine("Enter a valid Pay Rate: ");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 10.00 || payRate > 49.95);

            Console.WriteLine("This is a valid Pay Rate.");
        }
    }
}
