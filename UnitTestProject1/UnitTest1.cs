using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GitTestApp.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MyUtilityController obj = new MyUtilityController();
            int i = obj.Add(5, 15);
            Assert.AreEqual(20, i);
        }
        [TestMethod]
        public void TestGet()
        {
            MyUtilityController obj = new MyUtilityController();
            string s = obj.Get(1);
            Assert.AreEqual("one", s);
        }

        [TestMethod]
        public void TestGet2()
        {
            MyUtilityController obj = new MyUtilityController();
            string s = obj.Get(1);
            Assert.AreEqual("two", s);
        }

    }
}
