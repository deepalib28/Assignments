using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CachingImplementation;

namespace CachingImplementationTest
{
    public class Student
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public Student(string firstName,string lastName)
        {
            Firstname = firstName;
            LastName = lastName;
        }

    }
}
