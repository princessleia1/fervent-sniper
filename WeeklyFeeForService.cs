using System;

namespace WeeklyFeeForService
{
    class Program
    {
        /*
         * Write a program for a lawn mowing service. The lawn-mowing season lasts for 20 weeks.
         * The weekly fee for a lot under 400 square feet is $25.00.
         * The fee for a lot that is 400 square feet or more, but under 600 sq feet is over $50.00 per week.
         * Prompt the user for the length and width of lawn, and then display the weekly mowing fee,
         * Including the total fee for the 20 week season.
         */
      
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of the lawn:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the lawn:");
            int width = int.Parse(Console.ReadLine());

            // Calculate square fee for lot
            int squareFeet = length * width;
            int weeklyPrice;    // Value to be determined by if statements

            if (squareFeet < 400)
            {
                weeklyPrice = 25;
            }
            else if (squareFeet >= 400 && squareFeet < 600)
            {
                // True
                weeklyPrice = 35;    
            }
            else
            {
                weeklyPrice = 50;
            }
            Console.WriteLine("The weekly fee is {0}", weeklyPrice);
            Console.WriteLine("The 20 week season price is {0}.", weeklyPrice * 20);
        }
    }
}
