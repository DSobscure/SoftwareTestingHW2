using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.NextDateProblem
{
    [TestClass]
    public class NextDateProblemUnitTest_CodeBasedC2
    {
        [TestMethod]
        public void NDP_C2TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod3()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod8()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod10()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 1, out resultMessage));
            Assert.AreEqual("2017/1/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod11()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 31, out resultMessage));
            Assert.AreEqual("2017/2/1", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod12()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 1, out resultMessage));
            Assert.AreEqual("2017/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod13()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 1, out resultMessage));
            Assert.AreEqual("2020/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod14()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 1, out resultMessage));
            Assert.AreEqual("2017/4/2", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod15()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod16()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2400, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod17()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2100, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_C2TestMethod18()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 31, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
    }
}
