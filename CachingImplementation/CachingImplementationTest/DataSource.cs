using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingImplementationTest
{
    public static class DataSource
    {
        public static Student GetStudent()
        {
            return new Student("Deepali","Bhavsar");
        }
    }
}
