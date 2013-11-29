using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TestApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 5;
            int c = a + b;

            Assert.AreEqual(10, c);
        }
    }
}
