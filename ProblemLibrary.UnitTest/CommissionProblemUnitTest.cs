using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest
{
    [TestClass]
    public class CommissionProblemUnitTest
    {
        #region spec-based testing
        [TestMethod]
        public void StrongRobustTestMethod1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.CommissionProblem(10, 10, 10, out resultMessage));
            Assert.AreEqual("100", resultMessage);
            Assert.IsTrue(Problem.CommissionProblem(10, 20, 10, out resultMessage));
            Assert.AreEqual("195", resultMessage);
            Assert.IsTrue(Problem.CommissionProblem(20 , 20, 20, out resultMessage));
            Assert.AreEqual("400", resultMessage);

            Assert.IsFalse(Problem.NextDateProblem(0, 50, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(71, 50, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);

            Assert.IsFalse(Problem.NextDateProblem(50, 0, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(50, 81, 50, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);

            Assert.IsFalse(Problem.NextDateProblem(50, 50, 0, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(50, 50, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);

            Assert.IsFalse(Problem.NextDateProblem(71, 81, 91, out resultMessage));
            Assert.AreEqual("輸入不合法", resultMessage);
        }
        #endregion

        #region path testing
        [TestMethod]
        public void C0TestMethod1()
        {
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void C1TestMethod1()
        {
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void C2TestMethod1()
        {
            throw new System.NotImplementedException();
        }
        [TestMethod]
        public void MCDCTestMethod1()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
