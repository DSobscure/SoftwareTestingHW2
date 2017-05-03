using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.NextDateProblem
{
    [TestClass]
    public class NextDateProblemUnitTest_CodeBasedC1
    {
        [TestMethod]
        public void NDP_C1TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod3()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod8()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod10()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 1, out resultMessage));
            Assert.AreEqual("2017/1/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod11()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 31, out resultMessage));
            Assert.AreEqual("2017/2/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod12()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 1, out resultMessage));
            Assert.AreEqual("2017/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod13()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 1, out resultMessage));
            Assert.AreEqual("2020/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C1TestMethod14()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 1, out resultMessage));
            Assert.AreEqual("2017/4/2", resultMessage);
        }
    }
}
