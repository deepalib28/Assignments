using System;
using ImmutableCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImmutableCollectionTest
{
    [TestClass]
    public class UnitTest1
    {
        private MutableCollection _mutableCollection;
        [TestInitialize]
        public void Initialise()
        {
            _mutableCollection =new MutableCollection();
        }
        [TestMethod]
        public void GetStudent()
        {
            Initialise();
            var student= _mutableCollection.StudentCollection["2"];
            string fullName=student.Concat(student.FirstName, student.LastName);
            Assert.AreEqual(fullName,"DeeBhavsar");
        }
    }
}
