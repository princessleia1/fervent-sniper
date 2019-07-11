using System;

namespace Circumference
{
    class Program
    {
        // Enumerator lists
        // IsDefined? method
        // GetName method
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

        static void Main(string[] args)
        {            
        const double PI = Math.PI;
            var daysType = typeof(Days);
            Console.WriteLine("PI Type: " + PI.GetType());
            Console.WriteLine("Circumference: " + (PI * 3));

            Console.WriteLine("\nFirst Name:" + Days.Sat);
            Console.WriteLine("\n1st Index: " + (int)Days.Sat);

            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("\n2nd Index: " + name);

            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon?: " + flag);
            Console.ReadKey();
        }
    }
}
