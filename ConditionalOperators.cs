using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Operators
            // (condition) ? true : false
            int x = 50;
            int y = 15;

            int biggestNumber = x > y ? x : y;
            Console.WriteLine(biggestNumber);

            double testScore = 95;
            Console.WriteLine((testScore >= 60) ? "Pass" : "Fail");

            // Not operators
            bool myBool = true;
            if (!myBool)

            int myInt = 5;
            if (!(myInt >= 6))
            {
            }
        }
    }
}