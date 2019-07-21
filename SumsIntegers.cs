using System;

namespace SumsIntegers
{
    class Program
    {
        /* Write a console-based application that sums the integers from 1 to 50.
         */
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += i;
            }
            Console.WriteLine("The Sum is {0}.", sum);
        }
    }
}