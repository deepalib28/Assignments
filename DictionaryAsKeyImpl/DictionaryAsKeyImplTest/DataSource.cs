using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryAsKeyImpl;

namespace DictionaryAsKeyImplTest
{
    public static class DataSource
    {
        public static Student GetStudent()
        {
            return new Student(1,"Deepali");
        }
    }
}
