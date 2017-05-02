using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemLibrary.UnitTest.NextDateProblem
{
    [TestClass]
    public class NextDateProblemUnitTest_SpecBasedStrongRobust
    {
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 30, out resultMessage));
            Assert.AreEqual("2017/1/31", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 1, 31, out resultMessage));
            Assert.AreEqual("2017/2/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 27, out resultMessage));
            Assert.AreEqual("2017/2/28", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 2, 28, out resultMessage));
            Assert.AreEqual("2017/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod小月1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 29, out resultMessage));
            Assert.AreEqual("2017/4/30", resultMessage);
        }
        [TestMethod]
        public void StrongRobustTestMethod小月2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 4, 30, out resultMessage));
            Assert.AreEqual("2017/5/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 7, 30, out resultMessage));
            Assert.AreEqual("2017/7/31", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 7, 31, out resultMessage));
            Assert.AreEqual("2017/8/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月5()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 8, 30, out resultMessage));
            Assert.AreEqual("2017/8/31", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod大月6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 8, 31, out resultMessage));
            Assert.AreEqual("2017/9/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod小月2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 9, 30, out resultMessage));
            Assert.AreEqual("2017/10/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod12月1()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 30, out resultMessage));
            Assert.AreEqual("2017/12/31", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod12月2()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2017, 12, 31, out resultMessage));
            Assert.AreEqual("2018/1/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月3()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 28, out resultMessage));
            Assert.AreEqual("2020/2/29", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月4()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2020, 2, 29, out resultMessage));
            Assert.AreEqual("2020/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月5()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2100, 2, 28, out resultMessage));
            Assert.AreEqual("2100/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月6()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2400, 2, 28, out resultMessage));
            Assert.AreEqual("2400/2/29", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod二月7()
        {
            string resultMessage;
            Assert.IsTrue(Problem.NextDateProblem(2400, 2, 29, out resultMessage));
            Assert.AreEqual("2400/3/1", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法1()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法2()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法3()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 13, 1, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法4()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 1, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法5()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法6()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 4, 31, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法7()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 12, 32, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法8()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2020, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法9()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2100, 2, 29, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法10()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2400, 2, 30, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法11()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 0, 0, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
        [TestMethod]
        public void NDP_StrongRobustTestMethod非法12()
        {
            string resultMessage;
            Assert.IsFalse(Problem.NextDateProblem(2017, 14, 50, out resultMessage));
            Assert.AreEqual("日期不合法", resultMessage);
        }
    }
}
