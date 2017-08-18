using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CachingImplementation;

namespace CachingImplementationTest
{
    [TestClass]
    public class UnitTest1
    {
        private Cache _cache;

        [TestInitialize]
        public void Initialize()
        {
            _cache = new Cache();
        }

        [TestMethod]
        public void Add()
        {
            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            var stud = _cache.Get("1");
            Student data=stud as Student;
           
            Assert.AreEqual(data.Firstname, DataSource.GetStudent().Firstname);
            
        }

        [TestMethod]
        public void AddNullObject()
        {
            Initialize();
            _cache.Add("1",null);
            var stud = _cache.Get("1");
            Assert.IsNotNull(stud);
         
        }

        [TestMethod]
        public void Get()
        {

            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            var stud = _cache.Get("1");
            Assert.IsNotNull(stud);
        }

        [TestMethod]
        public void Update()
        {
           Initialize();
           var Cache= _cache.Update("1", new Student("Dips","bhavsar"));

          Assert.AreNotSame(Cache,DataSource.GetStudent());
        }

        [TestMethod]
        public void clear()
        {
            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            _cache.Clear();
           
            var stud = _cache.Get("1");

            var ex = stud as Exception;
           
            Assert.IsTrue(string.Equals("Key not Found exception",ex.Message,StringComparison.OrdinalIgnoreCase));
        }

        [TestMethod]
        public void Remove()
        {
            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            _cache.Add("2", DataSource.GetStudent());
            _cache.Remove("2");
            var stud = _cache.Get("2");
            var ex = stud as Exception;
            Assert.IsTrue(string.Equals("Key not Found exception", ex.Message, StringComparison.OrdinalIgnoreCase));
        }
    }
}
