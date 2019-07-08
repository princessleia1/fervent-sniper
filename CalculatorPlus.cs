using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPlus
{
    class Program
    {
        /* Build a simple calculator program. 
         * Read user name and print output.
         * Read in two integers from user and add them together.
         * Print the results in a nice output statement.
         */
        static void Main(string[] args)
        {
            // Reading input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // Waits for input

          
            Console.WriteLine("Hello {0} this is a simple Calculator.", name);
            // Returns: Hello <name> this is a simple Calculator.
            
            // Parsing string to numeric value
            Console.WriteLine("Enter 1st Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number + number2;
            Console.WriteLine("{0} + {1} Result is: {2}", number, number2, result);
        }
    }
}
