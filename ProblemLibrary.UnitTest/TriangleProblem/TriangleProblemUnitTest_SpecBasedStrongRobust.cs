using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.TriangleProblem
{
    [TestClass]
    public class TriangleProblemUnitTest_SpecBasedStrongRobust
    {
        [TestMethod]
        public void TP_StrongRobustTestMethod直角三角形1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 4, 5, out resultMessage));
            Assert.AreEqual("直角三角形", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethod正三角形1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 3, 3, out resultMessage));
            Assert.AreEqual("正三角形", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethod等腰三角形1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 3, 5, out resultMessage));
            Assert.AreEqual("等腰三角形", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethod普通三角形1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 5, 6, out resultMessage));
            Assert.AreEqual("普通三角形", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodA_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(0, 1, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodB_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 0, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodc_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 1, -1, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodAB_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(0, -1, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodAC_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(-1, 1, -1, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodBC_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethodABC_SideMinMinus1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethod非三角形1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 1, 2, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
        [TestMethod]
        public void TP_StrongRobustTestMethod非三角形2()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 2, 3, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
    }
}
