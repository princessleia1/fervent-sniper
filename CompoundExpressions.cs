using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compound expressions in If Statements
            bool x = true;
            bool y = true;
            bool z = x && y;

            // && is only true if both sides are true
            // All conditions must be met
            // T && T = T
            // T && F = F
            // F && F = F
            // F && T = F

            bool a = true;
            bool b = true;
            bool c = x || y;
            // Or is only false when both are false
            // Only 1 condition evaluated to true
            // T || T = T
            // T || F = T
            // F || T = T
            // F || F = F

            // && 
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 55)
            {
                Console.WriteLine("You are good to go.");
            }
            else
            {
                Console.WriteLine("There is a problem.");
            }

            // ||
            Console.WriteLine("Enter your child's age:");
            int age2 = int.Parse(Console.ReadLine());

            if (age2 >= 18 || age2 <= 55)
            {
                Console.WriteLine("You are good to go.");
            }
            else
            {
                Console.WriteLine("There is a problem.");
            }

            // If you are less than or equal 12, discount applied
            // If you are older than or equal 55 and rating of title is G, discount applied
            // && evalues first
            Console.WriteLine("Enter your age:");
            int age3 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the movie rating?");
            char rating = char.Parse(Console.ReadLine());

            if (age3 <= 12 || age3 >= 55 && rating == 'G')
            {
                Console.WriteLine("Discount is applied.");
            }
            else
            {
                Console.WriteLine("Discount is not applied.");
            }
        }
    }
}