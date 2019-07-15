using System;

namespace OutKeyword
{
    class Program
    {
        // Out keyword
        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(out studentGrade); // Ref keyword requires an initial value
            Console.WriteLine(studentGrade);

            int add;
            int mult;
            AddandMult(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);
        }

        public static void GiveExtraCredit(out int studentGrade)
        {
            studentGrade = 0;
            studentGrade += 3;
        }

        public static void AddandMult(int a, int b, out int added, out int mult)
        {
            added = a + b;
            mult = a * b;
        }
    }
}
