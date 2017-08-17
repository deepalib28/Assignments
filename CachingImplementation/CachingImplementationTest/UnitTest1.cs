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
            Assert.IsTrue(_cache.count == 1);

        }

        [TestMethod]
        public void AddNullObject()
        {
            Initialize();
            _cache.Add("1",null);
            Assert.IsTrue(_cache.count==0);
        }
        [TestMethod]
        public void Retrieve()
        {

            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            var stud = _cache.Retrieve("1");
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
            Assert.IsTrue(_cache.count == 0);
        }

        [TestMethod]
        public void Remove()
        {
            Initialize();
            _cache.Add("1", DataSource.GetStudent());
            _cache.Add("2", DataSource.GetStudent());
            _cache.Remove("2");
            Assert.IsTrue(_cache.count==1);
        }
    }
}
