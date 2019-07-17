using System;

namespace SquareCube
{
    class Program
    {
        /* Create a console-based program whose Main() method prompts user for an integer value,
         * And in turn passes value to a method that squares number and to a method that cubes the number.
         * Cube() method should call Square() method. 
         * Main() method displays results returned from each of the other methods.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());
            int squared = Square(number);
            Console.WriteLine("{0} this squared is {1}", number, squared);
            int cubed = Cube(number);
            Console.WriteLine("{0} this cubed is {1}", number, cubed);
        }

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }

        public static int Cube(int number)
        {
            //int answer = number * number * number;
            int answer = Square(number) * number;
            return answer;
        }
    }
}
