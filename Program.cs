using System;
using static System.Console;

namespace student_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("Matthew", "Obert");
            WriteLine(myStudent.GetFullName());
        }
    }
}
