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
        public void CP_StrongRobustTestMethod一階傭金2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(1, 1, 1, out resultMessage));
            Assert.AreEqual("10", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod二階傭金1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod二階傭金2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 5, 48, out resultMessage));
            Assert.AreEqual("270", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod三階傭金1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(20, 20, 20, out resultMessage));
            Assert.AreEqual("400", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethod三階傭金2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 5, 49, out resultMessage));
            Assert.AreEqual("365", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(0, 10, 10, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMin1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(1, 10, 10, out resultMessage));
            Assert.AreEqual("59", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMinPlus()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(2, 10, 10, out resultMessage));
            Assert.AreEqual("64", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMaxMinus1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(69, 10, 10, out resultMessage));
            Assert.AreEqual("731", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMax1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(70, 10, 10, out resultMessage));
            Assert.AreEqual("740", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodLockMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(71, 10, 10, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(10, 0, 10, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMin1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 1, 10, out resultMessage));
            Assert.AreEqual("73", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMinPlus1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 2, 10, out resultMessage));
            Assert.AreEqual("76", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMaxMinus1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 79, 10, out resultMessage));
            Assert.AreEqual("614", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMax1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 80, 10, out resultMessage));
            Assert.AreEqual("620", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodStockMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(10, 81, 10, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(10, 10, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMin1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 1, out resultMessage));
            Assert.AreEqual("77", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMinPlus1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 2, out resultMessage));
            Assert.AreEqual("80", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMaxMinus1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 89, out resultMessage));
            Assert.AreEqual("595", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMax1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 90, out resultMessage));
            Assert.AreEqual("600", resultMessage);
        }
        [TestMethod]
        public void CP_StrongRobustTestMethodBarrelMaxPlus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.CommissionProblem(10, 10, 91, out resultMessage));
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
