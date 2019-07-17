using System;

namespace MultiplicationTable
{
    class Program
    {
        /* Create a basic console-based program whose Main() method asks user to input an integer and then calls
         * Method named MultiplicationTable(), which displays the results of multiplying the integer by each of the numbers 2-10
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
        }

        public static void MultiplicationTable(int number)
        {
            // Use for loop
            for (int i = 2; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0,2} * {1,2} = {2,2}", i, number, answer);
            }

            // Expected output like:
            //Enter a Number:
            // 45
            // 2 * 45 = 90
            // 3 * 45 = 135
            // 4 * 45 = 180
            // 5 * 45 = 225
            // 6 * 45 = 270
            // 7 * 45 = 315
            // 8 * 45 = 360
            // 9 * 45 = 405
            //10 * 45 = 450
        }
    }
}
