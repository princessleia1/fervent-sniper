using System;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Hello");
                x++;
            }

            // For loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello Again");
            }

            Console.WriteLine("Enter an amount of times to print hello: ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("For Loop");
            }

            // Do while loop
            int z = 5; // Executes at least one time
            do
            {
                Console.WriteLine("Do While Loop");
                z++;
            }
            while (z > 6) ;

            // While loop
            Console.WriteLine("Hello");
            string response = Console.ReadLine();

            while (response == "again")
            {
                Console.WriteLine("Hello");
                response = Console.ReadLine();
            }

            // Do while loop
            // Condition comes first
            string responseAgain;
            do
            {
                Console.WriteLine("Hello");
                responseAgain = Console.ReadLine();
            } while (responseAgain == "Again");

            // Nested loop
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
