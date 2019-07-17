using System;

namespace CreateClass
{
    class Program
        // Class is a blueprint
    {
        static void Main(string[] args)
        {
            // Create some instances
            // Classes by default are reference type
            Student s1 = new Student(); // Call constructor, new = Instantiation allocating mem differently
            s1.Name = "Leia";
            s1.Age = 19;
            s1.FinalGrade = 65;
            s1.SayHello();  // Use leia infor

            Student s2 = new Student();
            s2.Name = "Han";
            s2.Age = 18;
            s2.FinalGrade = 90;
            s2.SayHello();

            Student s3 = new Student();
            s3.Name = "Luke";
            s3.Age = 22;
            s3.FinalGrade = 95;
            s3.SayHello();
            // Console.WriteLine(s1.Name);
        }
    }
}
