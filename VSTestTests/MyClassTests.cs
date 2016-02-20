using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTest.Tests
{
    [TestClass()]
    public class MyClassTests
    {
        [TestMethod()]
        public void Test_Add()
        {
            Assert.AreEqual(3, MyClass.Add(1, 2));
        }
    }
}