using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        public Student(string name, int age, double finalGrade)
        {
            //Console.Write(name);
            //name = name;
            //age = age;
            //finalGrade = finalGrade;

            // Use This reference
            // Diff between param name and passed name
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        // Constructor overload to have another version where one param is not needed
        // Code duplication so call constructor from constructor
        public Student(string name, int age) : this(name,age,0)
        {
            //this.name = name;
            //this.age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
    }
}
