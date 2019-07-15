using System;

namespace MultidimentionalArray
{
    class Program
        // Rectangular multidimentional array each row has same amount of columns
        // Jaggered multidimentional array has different amount of rows (arrays of arrays)
        // Every row is a brand new array
    {
        static void Main(string[] args)
        {
            // Rectangular array
            // Comma rep, simple grid
            // ****
            // ****
            // ****
            int[,] myArray = new int[3, 4];
            myArray[0, 0] = 5;
            myArray[0, 1] = 6;
            myArray[0, 2] = 7;
            myArray[0, 3] = 8;

            myArray[1, 0] = 5;
            myArray[1, 1] = 6;
            myArray[1, 2] = 7;
            myArray[1, 3] = 8;

            myArray[2, 0] = 5;
            myArray[2, 1] = 6;
            myArray[2, 2] = 7;
            myArray[2, 3] = 8;

            // Print the values
            // Outer loop goes 1 interation
            for(int  i = 0; i <3; i++)
            {
                for(int j = 0; j <4; j++)
                {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine();
            }

            // Shorthand
            int[,] myA =
            {
                 { 5,6,7,8 },
                 { 5,6,7,8 },
                 { 5,6,7,8 },
            };

            // Jaggered array
            //5 6 7 8
            //1 2 3 4 5 6 7 8 9 10
            //4 5 
            int[][] myArray2 = new int[3][];
            myArray2[0] = new int[4] { 5, 6, 7, 8 };
            myArray2[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myArray2[2] = new int[2] { 4, 5 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < myArray2[i].Length; j++)
                {
                    // Separate brackets for dimension
                    Console.Write(myArray2[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
