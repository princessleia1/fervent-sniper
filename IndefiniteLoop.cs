using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // while ( test-expression ) { statements}
            // Infinite loop
            /*  int x = 1;
            *   while (x > 0)
            *   {
            *       Console.WriteLine("Infinite loop");
            *   }
            */

            // Terminated loop
            int x = 0; // Counter control variable
            while (x < 11) // Condition 0 1 2 3 4 5 7 8 9 10 11 true until false at 12
            {
                Console.WriteLine("Terminated loop");
                x++; // Alter statement

            }

            // Indefinite loop
            int runningTotal = 0;

            Console.WriteLine("Enter a Number or -1 to Quit.");
       
            int Number = int.Parse(Console.ReadLine());
            while (Number != -1)
            {
                runningTotal += Number;
                Console.WriteLine("Enter a Number or -1 to Quit");
                Number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Total is {0}", runningTotal);
        }
    }
}
