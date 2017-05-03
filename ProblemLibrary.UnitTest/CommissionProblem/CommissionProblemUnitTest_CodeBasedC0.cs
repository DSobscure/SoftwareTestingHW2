using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.CommissionProblem
{
    [TestClass]
    public class CommissionProblemUnitTest_CodeBasedC0
    {
        [TestMethod]
        public void CP_C0TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C0TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(1, 1, 1, out resultMessage));
            Assert.AreEqual("10", resultMessage);
        }
        [TestMethod]
        public void CP_C0TestMethod3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
        }
        [TestMethod]
        public void CP_C0TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 5, 48, out resultMessage));
            Assert.AreEqual("270", resultMessage);
        }
    }
}
