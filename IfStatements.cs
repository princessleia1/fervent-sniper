using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        /* Build an age verification program.
         * Ask the user their Age.
         * If the user's age is greater than or equal to 55, display an appropriate message.
         * If the user's age is not equal or greater than 55, display an appropriate message.
         */

        static void Main(string[] args)
        {
            // Reading input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); 
            Console.WriteLine("Hello {0} this is a simple age program for if statements.", name);

            // Read user input of age and parse string to int
            Console.WriteLine("Enter your Age in Years:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The User's Age is: {0}", age);

            // Eval bool
            // Use blocks for if statements as 2nd statements are not part of initial if statement parameters
            if (age >= 55)
            {
                Console.WriteLine("Age is equal or greater than 55.");
                Console.WriteLine("You are a Pensioner.");
            }
            else
            {
                Console.WriteLine("Age is not less than 55 or greater.");
                Console.WriteLine("You are a Child, Teenager, or Adult.");
            }
        }
    }
}
