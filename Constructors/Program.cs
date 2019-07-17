using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Leia",18,75); 
            s1.SayHello();  

            Student s2 = new Student("Han",21,85);
            s2.SayHello();

            Student s3 = new Student("Luke",23,95);
            s3.SayHello();

            Student s4 = new Student("Mike", 17);
            s4.SayHello();
        }
    }
}
