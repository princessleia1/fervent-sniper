using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        // How to use objects with arrays
        static void Main(string[] args)
        {
            int[] myArray = new int[2]; // Each slot is empty
            // However with array each memory slot needs more mem
            myArray[0] = 5; // Not new reference types
            myArray[1] = 10;

            Person[] peopleArray = new Person[2]; // Each element needs to call new and call constructor
            peopleArray[0] = new Person("HAN", 5);
            peopleArray[1] = new Person("TEST", 6);

            for(int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0}, {0}", peopleArray[i].Name, peopleArray[i].Age);
            }
        }
    }
}
