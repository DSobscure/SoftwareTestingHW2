using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.NextDateProblem
{
    [TestClass]
    public class NextDateProblemUnitTest_CodeBasedMCDC
    {
        [TestMethod]
        public void NDP_MCDC_TestMethod1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod3()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod8()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod10()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 1, out resultMessage));
            Assert.AreEqual("2017/1/2", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod11()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 31, out resultMessage));
            Assert.AreEqual("2017/2/1", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod12()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 1, out resultMessage));
            Assert.AreEqual("2017/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod13()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 1, out resultMessage));
            Assert.AreEqual("2020/2/2", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod14()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 1, out resultMessage));
            Assert.AreEqual("2017/4/2", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod15()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod16()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2400, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod17()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2100, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_MCDC_TestMethod18()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 31, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
    }
}
