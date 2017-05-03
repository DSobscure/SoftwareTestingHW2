using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.TriangleProblem
{
    [TestClass]
    public class TriangleProblemUnitTest_CodeBaedC2
    {
        [TestMethod]
        public void TP_C2TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod2()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(2, 1, 1, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(2, 2, 2, out resultMessage));
            Assert.AreEqual("正三角形", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(2, 2, 1, out resultMessage));
            Assert.AreEqual("等腰三角形", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod5()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 4, 5, out resultMessage));
            Assert.AreEqual("直角三角形", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 4, 6, out resultMessage));
            Assert.AreEqual("普通三角形", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod8()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 1, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 2, 1, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod10()
        {
            string resultMessage;
            Assert.IsFalse(Problem.TriangleProblem(1, 1, 2, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod11()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(1, 2, 2, out resultMessage));
            Assert.AreEqual("等腰三角形", resultMessage);
        }
        [TestMethod]
        public void TP_C2TestMethod12()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(2, 1, 2, out resultMessage));
            Assert.AreEqual("等腰三角形", resultMessage);
        }
    }
}
