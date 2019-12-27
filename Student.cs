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
    }
}
