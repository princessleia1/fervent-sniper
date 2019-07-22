using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    class Person
    {
        // Static means it is applied to entire class and one version
        private string name;
        private int age;

        public static int Count; // Applied to entire class

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            // Increase
            Count++;
        }

        // Property
        public string Name // Unique to this class and considered an instance variable
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}