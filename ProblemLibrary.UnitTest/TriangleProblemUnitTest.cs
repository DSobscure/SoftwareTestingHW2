using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest
{
    [TestClass]
    public class TriangleProblemUnitTest
    {
        #region spec-based testing
        [TestMethod]
        public void StrongRobustTestMethod1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.TriangleProblem(3, 4, 5, out resultMessage));
            Assert.AreEqual("直角三角形", resultMessage);
            Assert.IsTrue(Problem.TriangleProblem(3, 3, 3, out resultMessage));
            Assert.AreEqual("正三角形", resultMessage);
            Assert.IsTrue(Problem.TriangleProblem(3, 3, 5, out resultMessage));
            Assert.AreEqual("等腰三角形", resultMessage);
            Assert.IsTrue(Problem.TriangleProblem(3, 5, 6, out resultMessage));
            Assert.AreEqual("普通三角形", resultMessage);

            Assert.IsFalse(Problem.TriangleProblem(0, 1, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(1, 0, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(1, 1, -1, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(0, -1, 2, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(-1, 1, -1, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(1, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(0, 0, 0, out resultMessage));
            Assert.AreEqual("邊長不合法", resultMessage);

            Assert.IsFalse(Problem.TriangleProblem(1, 1, 2, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
            Assert.IsFalse(Problem.TriangleProblem(1, 2, 3, out resultMessage));
            Assert.AreEqual("兩邊和不大於第三邊", resultMessage);
        }
        #endregion

        #region path testing
        [TestMethod]
        public void C0TestMethod1()
        {

        }
        [TestMethod]
        public void C1TestMethod1()
        {

        }
        [TestMethod]
        public void C2TestMethod1()
        {

        }
        [TestMethod]
        public void MCDCTestMethod1()
        {

        }
        #endregion
    }
}
