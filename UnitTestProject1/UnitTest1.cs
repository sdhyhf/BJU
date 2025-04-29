using System;
using BJU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            Form1 form1 = new Form1();
            Assert.AreEqual(form1.bju(45), new double[] {270, 162, 540});
        }
    }
}
