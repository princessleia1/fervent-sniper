using System;

namespace StaticKeyword
{
    class Program
    {
        // Using static keyword
        static void Main(string[] args)
        {
            Person p1 = new Person("Luke", 5);
            Person p2 = new Person("Han", 6);

            // Access to static is through class itself
            Console.WriteLine(Person.Count);
            
            //Test(); // Main cannot see Test if made not static
            Test();
        }
        public static void Test()
        {
            Console.WriteLine("TEST");
        }
    }
}