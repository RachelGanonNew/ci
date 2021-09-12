using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();
            int res = c.add(2, 3);
                Assert.AreEqual(res, 5);
          
   

        }
    }
}
