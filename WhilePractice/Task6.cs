﻿namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double i = 1;
            double sum = 0;
            double p = -1;
            while (i <= n)
            {
                sum += p / ((2 * i) + 1);
                p *= -1;
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }
    }
}
