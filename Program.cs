using System;
using static System.Console;

namespace student_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student("Matthew", "Obert");
            WriteLine(DisplayNameAndMajor(aStudent));
        }
        static string DisplayNameAndMajor(Student myStudent)
        {
            string result = String.Format("****************************************\n");
            result += String.Format("* {0, 12}{1, 24} *\n", "Full Name:", myStudent.GetFullName());
            result += String.Format("* {0, 12}{1, 24} *\n", "Major:", myStudent.Major);
            result += String.Format("****************************************");
            return result;
        }
    }
}
