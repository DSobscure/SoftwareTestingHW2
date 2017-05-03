using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.NextDateProblem
{
    [TestClass]
    public class NextDateProblemUnitTest_CodeBasedC0
    {
        [TestMethod]
        public void NDP_C0TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod3()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod8()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C0TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
    }
}
