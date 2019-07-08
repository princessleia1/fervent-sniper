using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If else statement
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                // True
                Console.WriteLine("You are of age.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not 18 yet.");
            }

            // Else if statement never runs the false
            Console.WriteLine("Enter your child's age:");
            int childAge = int.Parse(Console.ReadLine());
            if (childAge == 1)
            {
                Console.WriteLine("Your child is 1.");
            }
            else if (childAge == 2)
            {
                Console.WriteLine("Your child is 2.");
            }
            else if (childAge == 3)
            {
                Console.WriteLine("Your child is 3.");
            }
        }
    }
}
