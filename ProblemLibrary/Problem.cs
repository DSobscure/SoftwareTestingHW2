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
            bool isLegal = true, isChangeMonth = false, isChangeYear = false;
            if(isLegal)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (day < 1 || day > 31)
                            isLegal = false;
                        if (day == 31)
                        {
                            isChangeMonth = true;
                            if (month == 12)
                                isChangeYear = true;
                        }
                        break;
                    case 2:
                        if (year % 4 == 0 && (!(year % 100 == 0) || (year % 400 == 0)))
                        {
                            if (day < 1 || day > 29)
                                isLegal = false;
                            if (day == 29)
                                isChangeMonth = true;
                        }
                        else
                        {
                            if (day < 1 || day > 28)
                                isLegal = false;
                            if (day == 28)
                                isChangeMonth = true;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (day < 1 || day > 30)
                            isLegal = false;
                        if (day == 30)
                            isChangeMonth = true;
                        break;
                    default:
                        isLegal = false;
                        break;
                }
            }
            if(isLegal)
            {
                if (isChangeYear)
                    resultMessage = $"{year + 1}/1/1";
                else if (isChangeMonth)
                    resultMessage = $"{year}/{month + 1}/1";
                else
                    resultMessage = $"{year}/{month}/{day + 1}";
                return true;
            }
            else
            {
                resultMessage = "日期不合法";
                return false;
            }
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
