using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DictionaryAsKeyImpl;

namespace DictionaryAsKeyImplTest
{
    [TestClass]
    public class UnitTest1
    {
        private StudentCollection studentCollection;

        [TestInitialize]
        public void Initialize()
        {
            studentCollection = new StudentCollection();
        }


        [TestMethod]
        public void AddInDictionary()
        {
            Initialize();
            var dictionary=studentCollection.Add(DataSource.GetStudent(), "Maths");

            
            var str = studentCollection.Retrieve(DataSource.GetStudent());

            //Assert.IsTrue(string.Equals(str, "Maths", StringComparison.OrdinalIgnoreCase));
            Assert.IsTrue(string.Equals(str, dictionary[DataSource.GetStudent()], StringComparison.OrdinalIgnoreCase));

            // Debug.WriteLine(dict.Count);
        }

        [TestMethod]
        public void updateInDictionary()
        {
            Initialize();
            var dictionary=studentCollection.Update(DataSource.GetStudent(),"Bio");
            
            var str = studentCollection.Retrieve(DataSource.GetStudent());
            Assert.IsTrue(string.Equals(str, dictionary[DataSource.GetStudent()], StringComparison.CurrentCultureIgnoreCase));
        }

        [TestMethod]
        public void DeleteFromDictionary()
        {
            Initialize();
            studentCollection.Add(DataSource.GetStudent(),"Maths");
            var dictionary=studentCollection.Delete(DataSource.GetStudent());

            Assert.IsTrue(dictionary.Count == 0);

        }

    }
}
