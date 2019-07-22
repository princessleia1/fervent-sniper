using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PassObjectsToMethods
{
    class Program
    {
        // Passing objects to methods
        static void Main(string[] args)
        {
            Person p1 = new Person("Leia", 20);
            Console.WriteLine("BEFORE: {0}, {1}", p1.Name, p1.Age);
            ChangePerson(p1);
            Console.WriteLine("AFTER: {0}, {1}", p1.Name, p1.Age);

            // Pass Reference type data change
            Person p2 = p1; // Exact place in memory
            p2.Name = "TEST";
            Console.WriteLine("AFTER ALTER 2: {0}, {1}", p1.Name, p1.Age);
        }
        // Expected output:
        // BEFORE: Leia, 20
        // AFTER: Han, 50
        // AFTER: TEST, 50

        // Function to manipulate the data, change the original data
        public static void ChangePerson(Person p1)
        {
            p1.Name = "Han";
            p1.Age = 50;
        }
    }
}