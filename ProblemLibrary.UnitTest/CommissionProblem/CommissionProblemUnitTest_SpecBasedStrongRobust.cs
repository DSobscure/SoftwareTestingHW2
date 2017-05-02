using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.CommissionProblem
{
    [TestClass]
    public class CommissionProblemUnitTest_SpecBasedStrongRobust
    {
        [TestMethod]
        public void CP_StrongRobustTestMethod一階傭金1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 10, out resultMessage));
            Assert.AreEqual("100", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod二階傭金1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod三階傭金1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(20, 20, 20, out resultMessage));
            Assert.AreEqual("400", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 50, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(71, 50, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(50, 0, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(50, 81, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(50, 50, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(50, 50, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockStockBarrelMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockStockBarrelMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(71, 81, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
    }
}
