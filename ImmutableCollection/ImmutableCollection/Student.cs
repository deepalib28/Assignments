using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableCollection
{
    public class Student
    {
        private readonly string _firstName;

        public string FirstName
        {
            get { return _firstName; }
        }

        private readonly string _lastName;

        public string LastName
        {
            get { return _lastName; }
          
        }

        public Student(string firstName,string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string Concat(string firstName,string lastName)
        {
            return firstName + lastName;
        }
    }
}
