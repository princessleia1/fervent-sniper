using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fervent_sniper
{
    class Program
    {
        // Enumeration
        enum DayOfWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            FRIDAY,
            SATURDAY,
        }
        // Main method entry point into app
        static void Main(string[] args)
        {
            // Declaring and init vars
            int myInt = 4;
            double myDouble = 5.5;
            string myString = "Hello Again!";
            bool myBool = true;
            char myChar = 'A';

            myInt = 5555; // Do not need to init

            // Write vars to console
            Console.WriteLine("Hello World!");
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myDouble);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);

            // Value of var format and concat
            Console.WriteLine("The value of myInt is {0,-4} and the value of myDouble is {1,-2}.", myInt, myDouble);
            Console.WriteLine("The value of myInt is " + myInt);
            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble);

            // + - * / % Operators
            int myInt3 = 5 + 5;
            Console.WriteLine(myInt3);
            int myInt4 = 5 - 5;
            Console.WriteLine(myInt4);
            int myInt5 = 5 * 5;
            Console.WriteLine(myInt5);
            int myInt6 = 5 / 5;
            Console.WriteLine(myInt6);

            // Tell it not do int division
            double myDouble1 = 5.0 / 2;
            Console.WriteLine(myDouble1);

            // Using Modulas
            double remain = 5 % 4;
            Console.WriteLine(remain);

            // Operator Precedence
            // * / % precedes
            int result = 2 + 3 * 4;
            Console.WriteLine(result);

            int results = (2 + 3) * 4;
            Console.WriteLine("The results is {0}", results);

            int myInt10 = myInt + myInt3 + myInt4;
            Console.WriteLine(myInt5);

            // Increment operators
            int x = 5;
            x = x + 1;
            // Shorten the duplication
            x += 1;
            x *= 5;

            Console.WriteLine("The value of x is {0}", x);

            // Prefix
            int y = 5;
            y++;

            Console.WriteLine("The value of y is {0}", y);

            int b = 4;
            int c = b++;

            Console.WriteLine("The value of b is {0} and the value of c is {1}", b, c);
            // Returns:
            // The value of b is 5 and the value of c is 4

            // Post Subtract
            int d = 4;
            int e = --d;

            Console.WriteLine("The value of d is {0} and the value of e is {1}", d, e);
            // Returns: The value of d is 3 and the value of e is 3  

            // Using bool type, comparison operators > >= < <= return true or false value
            // Equality == Not equal to !=
            bool myBool2 = 5 > 6;
            Console.WriteLine(myBool2);
            // Returns False

            bool myBool3 = 5 >= 6;
            Console.WriteLine(myBool3);
            // Returns False

            bool myBool4 = 5 <= 6;
            Console.WriteLine(myBool4);
            // Returns True

            bool myBool5 = 5 == 5;
            Console.WriteLine(myBool5);
            // Returns True

            bool myBool6 = 6 != 5;
            Console.WriteLine(myBool6);
            // Returns True

            int hoursWorked = 25;
            bool doesEmployeeGetOverTime1 = hoursWorked > 40;
            Console.WriteLine("Does employee get overtime? {0}", doesEmployeeGetOverTime1);
            // Returns False

            int hoursWorked2 = 41;
            bool doesEmployeeGetOverTime = hoursWorked2 > 40;
            Console.WriteLine("Does employee get overtime? {0}", doesEmployeeGetOverTime);
            // Returns True

            // Using char type
            char myChar2 = '*';
            Console.WriteLine(myChar2);

            myChar2 = 'A';
            Console.WriteLine(myChar2);

            // Escape char
            myChar2 = '\'';
            Console.WriteLine(myChar2);

            myChar2 = '\"';
            Console.WriteLine(myChar2);

            // New line char
            myChar2 = '\n';
            Console.WriteLine(myChar2);

            // Using string type with quotes
            string myString2 = "Hello again, new \"World\"";
            Console.WriteLine("So this is the text of string: {0}", myString2);

            // 1. Check for equality, compare strings
            string name1 = "Princess";
            string name2 = "Leia";

            bool namesEqual = name1 == name2;
            Console.WriteLine("Names equal {0}", namesEqual);
            // Returns False

            // 2nd method
            name1 = "Leia";
            name2 = "Princess";
            bool namesEqual2 = string.Equals(name1, name2);
            Console.WriteLine("Names equal {0}", namesEqual2);
            // Returns False

            // 3rd method
            // string.compare returns error so change string to int
            name1 = "Han";
            name2 = "Han";
            int namesEqual3 = string.Compare(name1, name2);
            Console.WriteLine("Names equal {0}", namesEqual3);
            // Returns 0

            // 4th method
            int namesEqual4 = name1.CompareTo(name2);
            Console.WriteLine("Names equal {0}", namesEqual4);
            // Returns 0

            // Length properties, return number of chars
            Console.WriteLine("{0} has {1} characters", name1, name1.Length);
            // Returns: Han has 3 characters

            // Substring
            string firstOfName = name1.Substring(0, 1);
            Console.WriteLine(firstOfName);

            // Middle
            string name3 = "Chickenlips";
            string middleOfName = name3.Substring(1, 3);
            Console.WriteLine("The middle char of name is {0}", middleOfName);
            // Returns hic

            // Start switch, does var starts with Chi
            bool startsWith = name3.StartsWith("Chi");
            Console.WriteLine("Does the name start with Chi? {0}", startsWith);
            // Returns True

            // Numeric conversions
            // Implicit
            int z = 5;
            double t = z;
            Console.WriteLine(z);

            // Casting forces double into int - knowing .4 is lost
            double myDouble2 = 5.4;
            int myInt7 = (int)myDouble2;
            Console.WriteLine(myInt7);
            // Returns 5

            // Declaring constants still named storage location
            const int myConstInt = 5;
            // myConstInt = 6; // Throws error
            Console.WriteLine(myConstInt);

            // Const for pi will never change ms in built
            Console.WriteLine(Math.PI);

            // Using enums
            DayOfWeek today = DayOfWeek.FRIDAY;
            Console.WriteLine(today);
            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);

            // Reading input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // Waits for input

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0},{1}", name, lastName);
            // Returns: Hello <name> <lastName>

            // Parsing string to numeric value
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number += 20;
            Console.WriteLine("The multiplied number is {0}", number);
        }
    }   
}
