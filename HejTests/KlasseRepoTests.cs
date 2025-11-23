using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hej;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hej.Tests
{
    [TestClass()]
    public class KlasseRepoTests
    {
        private KlasseRepo _repo;
        //h
        [TestInitialize]
        public void TestInitialize()
        {
            _repo = new KlasseRepo();
        }

        [TestMethod]
        public void Test()
        {
            Assert.IsNotNull(_repo);
        }
    }
}