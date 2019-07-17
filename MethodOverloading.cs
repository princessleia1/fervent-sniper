using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Param keyword
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            // Enter in any amount of args
            Console.WriteLine("Hello {0} {1} {2}", 5, 6, 7);

            // Method overload
            // Function needs same name but params are diff amount or data types
            Add(5, 6);
            Add(5.5, 6.5);
            Add("hello", "world");
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void Add(string x, string y)
        {
            // Concat
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
