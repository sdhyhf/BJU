using System;
using System.Linq;
using BJU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();
            Assert.AreEqual(form1.bju(45, 160).Sum(), new double[] { 270, 162, 540 }.Sum());
        }
    }
}
