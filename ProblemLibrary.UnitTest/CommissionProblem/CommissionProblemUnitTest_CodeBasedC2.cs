using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.CommissionProblem
{
    [TestClass]
    public class CommissionProblemUnitTest_CodeBasedC2
    {
        [TestMethod]
        public void CP_C2TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(1, 1, 1, out resultMessage));
            Assert.AreEqual("10", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(20, 20, 20, out resultMessage));
            Assert.AreEqual("400", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(71, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod6()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 81, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod8()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 1, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_C2TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(1, 1, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
    }
}
