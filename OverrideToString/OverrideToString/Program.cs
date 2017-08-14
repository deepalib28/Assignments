using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud=new Student("Deepali","Bhavsar");

            string fullName=stud.ToString();

            Console.WriteLine("fullName of student is:   "+fullName);
            Console.ReadKey();
        }
    }
}
