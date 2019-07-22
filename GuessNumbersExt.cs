using System;

namespace GuessNumbersExt
{
    class Program
    {
        /* Write a console-based application that generates a random number between 1 and 10.
         * Ask the user to guess the random number, then display the random number.
         * Indicate whether the user's guess was too high, too low, or correct.
         * Use loop for this solution.
         */
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int amountOfGuess = 0;
            // Use do while
            int usersGuess;
            do
            {
                Console.WriteLine("Guess the Random Number: ");
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low.");
                }
                else if (usersGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else
                {
                    Console.WriteLine("Your guess is correct.");
                }
                amountOfGuess++; // Increase amount of guess by 1

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed the Random Number {0} times", amountOfGuess);
        }
    }
}