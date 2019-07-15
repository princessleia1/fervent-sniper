using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    class Program
    {   
        // Use of ref keyword
        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade); // Pass location in memory any changes will reflect in vars in the function
            Console.WriteLine(studentGrade);
        }

        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }
    }
}
