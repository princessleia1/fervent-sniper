using System;

namespace LetterGuessGame
{
    class Program
    {
        /* Create a game where a player guesses letters to try to replicate a hidden word.
         * Store 8 words in an array, randomly select one to be the hidden word.
         * Initially, display the hidden word using asterisks to rep each letter.
         * Ask user to guess the word until the user completes entire word.
         * If user guesses a letter that is not in the word, display an appropriate message.
         * If user guesses a letter that appears multiple times in the hidden word, make sure each correct letter placed.
         */

        static void Main(string[] args)
        {
            // Strings contains methods: string s = "Hello";
            // Strings remove methods: s = s.Remove(0, 1);
            // Strings insert method: s = s.Insert(0, 1);
            // String length property: Console.WriteLine(s.Length);

            // Get random word
            string[] words = { "jump", "programming", "sky", "river", "google", "black", "shoes", "chicken" };
            Random random = new Random();
            int randomIndex = random.Next(0, 9);
            
            // Select random word from the array
            string selectedWord = words[randomIndex];
            string hiddenWord = "";
            
            // Add to hidden word add *
            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }
            
            // Console.WriteLine(hiddenWord);
            // Guess logic
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("The Hidden Word is {0}", hiddenWord);
                Console.Write("Guess a Letter >> ");
                
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for(int i =0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        // jump
                        // j***
                        // j*m* index 2
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                }
                
                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! {0} is in the word",letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is not in the word",letter);
                }
                Console.ResetColor();
            }
            // You won
            Console.WriteLine("Congratulations! You have Won! The Word was {0}", selectedWord);
        }
    }
}
