using System;

namespace CreateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(5, 10);
            //Add(5, 10);
            //Add(15, 100);
            //Add(30, 300);

            int secondAnswer = Add(answer, 5);
            Console.WriteLine(secondAnswer);
            int a = int.Parse(Console.ReadLine());  // Same as int answer in method below
   
            DisplayMessage();
        }
        
        // Calculate two numbers with a return type
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            // Console.WriteLine(answer);
            // Return an integer
            return answer;
        }

        public static void DisplayMessage() // No return type
        {
            Console.WriteLine("TEST 1");
        } 
    }
}
