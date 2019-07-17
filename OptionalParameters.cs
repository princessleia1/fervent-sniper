using System;

namespace OptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to define y as being optional
            // Give default value for y
            Add(5);
            Add(5, 5);
            // Named arguments 5 to x, forcing 2nd param default 1, z named arg
            Add(5, z: 5);
            // Expected result 11
        }
        
        // Default value int y = 1
        public static void Add(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }

    }
}
