using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassTest1()
        {
            // This test passes
            Assert.AreEqual("passing value", "passing value");
        }

        [TestMethod]
        public void FailTest1()
        {
            // This test fails
            Assert.AreEqual("one string", "a different string");
        }
    }
}
