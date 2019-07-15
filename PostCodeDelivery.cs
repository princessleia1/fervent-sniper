using System;

namespace PostCodeDelivery
{
    class Program
    {
        /* Write a program for a package delivery service.
         * Program contains an array that holds 7 post codes to which company delivers to.
         * Prompt a user to enter post code and display message indicating whether post code the company sends delivers to.
         */
        static void Main(string[] args)
        {
            string[] postCodes = { "4000", "4010", "4005", "4510", "4560", "4321", "4352" };

            Console.WriteLine("Enter the Post Code:");
            string code = Console.ReadLine();
            bool found = false;

            for(int i = 0; i < postCodes.Length; i++)
            {
                if (code == postCodes[i])
                { // Mark found var to if true
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                Console.WriteLine("We do ship to this Post Code.");
            }
            else
            {
                Console.WriteLine("We do not ship to this Post Code.");
            }
        }
    }
}
