using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest
{
    [TestClass]
    public class NextDateProblemUnitTest
    {
        #region spec-based testing
        [TestMethod]
        public void StrongRobustTestMethod1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 30, out resultMessage));
            Assert.AreEqual("2017/1/31", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 31, out resultMessage));
            Assert.AreEqual("2017/2/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 27, out resultMessage));
            Assert.AreEqual("2017/2/28", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 29, out resultMessage));
            Assert.AreEqual("2017/4/30", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 7, 30, out resultMessage));
            Assert.AreEqual("2017/7/31", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 7, 31, out resultMessage));
            Assert.AreEqual("2017/8/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 8, 30, out resultMessage));
            Assert.AreEqual("2017/8/31", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 8, 31, out resultMessage));
            Assert.AreEqual("2017/9/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 9, 30, out resultMessage));
            Assert.AreEqual("2017/10/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 30, out resultMessage));
            Assert.AreEqual("2017/12/31", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 28, out resultMessage));
            Assert.AreEqual("2020/2/29", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2100, 2, 28, out resultMessage));
            Assert.AreEqual("2100/3/1", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2400, 2, 28, out resultMessage));
            Assert.AreEqual("2100/2/29", resultMessage);
            Assert.IsTrue(Problem.NextDateProblem(2400, 2, 29, out resultMessage));
            Assert.AreEqual("2100/3/1", resultMessage);

            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 13, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 31, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 12, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2100, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2400, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
            Assert.IsFalse(Problem.NextDateProblem(2017, 14, 50, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
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
