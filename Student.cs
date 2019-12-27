using System;
using System.Collections.Generic;
using System.Text;

namespace student_classes
{
    class Student
    {
        // properties
        private int studentNumber;
        private string firstName,
                       lastName,
                       classification,
                       major;
        // accessors and mutators
        public int StudentNumber
        {
            set
            {
                studentNumber = value;
            }
            get
            {
                return studentNumber;
            }
        }
        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public string Classification
        {
            set
            {
                classification = value;
            }
            get
            {
                return classification;
            }
        }
        public string Major
        {
            set
            {
                major = value;
            }
            get
            {
                return major;
            }
        }
        // constructors (at least two, per spec)
        Student()
        {
            studentNumber = GenerateNumber();
            firstName = "Example";
            lastName = "Student";
            classification = "Freshman";
            major = "Computer Science";
        }
        Student(string first, string last)
        {
            studentNumber = GenerateNumber();
            firstName = first;
            lastName = last;
            classification = "Freshman";
            major = "Computer Science";

        }
        // generate student number
        public static int GenerateNumber()
        {
            Random r = new Random();
            return r.Next(1000, 9999);
        }
    }
}
