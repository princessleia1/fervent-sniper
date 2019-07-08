using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCosting
{
    class Program

        /* Write a program that asks user for length and width of their room.
         * Define a constant that represents Price of Tiling per Square Foot.
         * Compute and display the cost of Tiling the room.
         */
    {
        static void Main(string[] args)
        {
            // Reading input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); 
      
            Console.WriteLine("Hello {0} this program calculates Price of Tiling per Square Foot.", name);

            // Declare const for cost of tiling per square foot
            const double per_square_foot = 5.34;

            // Read input of width parse string to double
            Console.WriteLine("Enter the WIDTH of the room in Feet?");
            double width = double.Parse(Console.ReadLine());

            // Read input of length parse string to double
            Console.WriteLine("Enter the LENGTH of the room in Feet?");
            double length = double.Parse(Console.ReadLine());

            // Calculate price
            double area = width * length;
            double price = area * per_square_foot;
            Console.WriteLine("For the area defined (Width {0}, Length {1}), the Final Cost is $:{2}", width, length, price);
        }
    }
}
