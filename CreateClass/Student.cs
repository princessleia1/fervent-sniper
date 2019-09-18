using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{

    
    class Student
    {
        // Always specify access modifiers
        public string Name;
        public int Age;
        public double FinalGrade;

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", Name);
        }
    }
}
