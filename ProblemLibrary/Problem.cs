using System;

namespace ProblemLibrary
{
    public static class Problem
    {
        public static bool TriangleProblem(int sideA, int sideB, int sideC, out string resultMessage)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                resultMessage = "邊長不合法";
                return false;
            }
            else if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                resultMessage = "兩邊和不大於第三邊";
                return false;
            }
            else if (sideA == sideB && sideB == sideC)
            {
                resultMessage = "正三角形";
                return true;
            }
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                resultMessage = "等腰三角形";
                return true;
            }
            else
            {
                int maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
                resultMessage = (maxSide * maxSide == sideA * sideA + sideB * sideB + sideC * sideC - maxSide * maxSide) ? "直角三角形" : "普通三角形";
                return true;
            }
        }

        public static bool NextDateProblem(int year, int month, int day, out string resultMessage)
        {
            throw new NotImplementedException("Problem NextDateProblem");
        }

        public static bool CommissionProblem(int lockCount, int stockCount, int barrelCount, out string resultMessage)
        {
            if (lockCount < 1 || lockCount > 70 || stockCount < 1 || stockCount > 80 || barrelCount < 1 || barrelCount > 90)
            {
                resultMessage = "輸入不合法";
                return false;
            }
            else
            {
                int totalSum = 45 * lockCount + 30 * stockCount + 25 * barrelCount;
                if (totalSum <= 1000)
                    resultMessage = (totalSum * 10 / 100).ToString();
                else if (totalSum <= 1800)
                    resultMessage = (totalSum * 15 / 100).ToString();
                else
                    resultMessage = (totalSum * 20 / 100).ToString();
                return true;
            }
        }
    }
}
