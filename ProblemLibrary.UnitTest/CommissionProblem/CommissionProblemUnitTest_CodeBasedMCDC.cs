using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.CommissionProblem
{
    [TestClass]
    public class CommissionProblemUnitTest_CodeBasedMCDC
    {
        [TestMethod]
        public void CP_MCDC_TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(1, 1, 1, out resultMessage));
            Assert.AreEqual("10", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 5, 48, out resultMessage));
            Assert.AreEqual("270", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(71, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod6()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 81, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod8()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 1, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_MCDC_TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 1, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
    }
}
