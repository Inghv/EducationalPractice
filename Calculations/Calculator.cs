using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double i = 1, sum = 0;
            while (i <= n)
            {
                sum += 1 / i;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double i = 1, sum = 0, b = 1;
            while (i <= n)
            {
                sum += b / (i * (i + 1));
                b *= -1;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double sum = 0, i = 1;
            while (i <= n)
            {
                sum += 1 / (i * i * i * i * i);
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double i = 1, sum = 0;
            while (i <= n)
            {
                sum += 1 / (((2 * i) + 1) * ((2 * i) + 1));
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double multiply = 1, i = 1;
            while (i <= n)
            {
                multiply *= 1 + (1 / (i * i));
                i++;
            }

            return multiply;
        }

        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double i = 1, sum = 0, b = -1;
            while (i <= n)
            {
                sum += b / ((2 * i) + 1);
                b *= -1;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double i = 1, sum = 0, u = 1, d = 1;
            while (i <= n)
            {
                sum += u / d;
                u *= i + 1;
                d += 1 / (i + 1);
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double sum = Math.Sqrt(2), i = 2;
            while (i <= n)
            {
                sum = Math.Sqrt(2 + sum);
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double i = 1, sum = 0, d = 0;
            while (i <= n)
            {
                d += Math.Sin(Math.PI * i / 180);
                sum += 1 / d;
                i++;
            }

            return sum;
        }
    }
}
