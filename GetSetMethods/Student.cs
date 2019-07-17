using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetMethods
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Student(string name, int age) : this(name, age, 0)
        {
            //this.name = name;
            //this.age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        public string GetName()
        {
            // Add constraints to protect data
            if (age >= 18)
            {
                return name;
            }
            else
            {
                return "This Student is Too Young";
            }
            //return (name);
        }

        public void SetName(string newName)
        {
            if (newName != "")
            {
                this.name = newName;
            }

        }

        public int GetAge()
        {
            if (age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }

        public void SetAge(int newAge)
        {
            if (newAge != 0)
            {
                age = newAge;
            }
        }

        public double GetFinalGrade()
        {
            return finalGrade;
        }

        public void SetFinalGrade(double newFinalGrade)
        {
            if (newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if(newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
        }
    }
}
