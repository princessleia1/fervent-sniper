using System;

namespace RandonNumGuess
{
    class Program
    {
        /*
         * Write a program to generate a random number between 1 and 10.
         * Ask the user to guess the random number, then display the random number and a message.
         * Indicate whether the user's guess was too high, too low, or correct.
         */

        static void Main(string[] args)
        {
            // Generate random number
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11); // min, max

            // Ask user to guess the number and store it
            Console.WriteLine("Guess the Random Number:");
            int userGuess = int.Parse(Console.ReadLine());

            // Display the guessed number
            Console.WriteLine("User entered: {0}", userGuess);

            // Display the random number
            Console.WriteLine("The random number was {0}", randomNumber);

            // Indicate to the user whether too low, too high, or correct
            if (userGuess < randomNumber)
            {
                Console.WriteLine("Your guessed number is too low!");
            }
            if (userGuess > randomNumber)
            {
                Console.WriteLine("Your guessed number is too high!");
            }
            else
            {                    
                Console.WriteLine("Your guessed number is correct!");
            }
        }

    }
}
