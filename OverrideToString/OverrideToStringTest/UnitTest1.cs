using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverrideToString;
namespace OverrideToStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsToString_Sucessfull()
        {
            Student stud=new Student("Dee","Bhavsar");
            string fullName=stud.ToString();
            Assert.AreEqual(fullName, "Dee Bhavsar");
        }


        [TestMethod]
        public void IsToString_UnSucessfull()
        {
            Student stud = new Student("Dee", "Bhavsar");
            string fullName = stud.ToString();
            Assert.AreNotEqual(fullName, "DeeBhavsar");
        }
    }
}
