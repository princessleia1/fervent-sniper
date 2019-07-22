using System;

namespace SquareObjects
{
    class Program
    {
        /* Create a class named Square that contains fields for area and length of a side and whose
         * Constructor requires a parameter for the length of one side of the Square.
         * The constructor assigns its parameter to the length of the Square's side field, and
         * Calls a private method. It computes the area field. Include read-only properties to set
         * Square objects with sides that in the main method create an array or ten Square objects with
         * Sides that haave values of 1 through 10. Display the values for each Square.
         */

        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            for(int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("{0}, {1}", squares[i].Side, squares[i].Area);
            }
        }
        // Expected output:
        // 1, 1
        // 2, 4
        // 3, 9
        // 4, 16
        // 5, 25
        // 6, 36
        // 7, 49
        // 8, 64
        // 9, 81
        // 10, 100
    }
}
