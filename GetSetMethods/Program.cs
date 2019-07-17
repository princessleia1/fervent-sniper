using System;

namespace GetSetMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student("Leia", 16, 75);
            Student s1 = new Student("Leia", 18, 75);
            s1.SetName("");
            Console.WriteLine(s1.GetName());
            s1.SetFinalGrade(105);
            Console.WriteLine(s1.GetFinalGrade());
            //s1.SetName();

            Student s2 = new Student("Han", 21, 85);
            s2.SayHello();

            Student s3 = new Student("Luke", 23, 95);
            s3.SayHello();

            Student s4 = new Student("Mike", 17);
            s4.SayHello();
        }
    }
}
