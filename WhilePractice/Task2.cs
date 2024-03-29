﻿namespace WhilePractice
{
    public static class Task2
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double i = 1;
            double sum = 0;
            double p = 1;
            while (i <= n)
            {
                sum += p / (i * (i + 1));
                p *= -1;
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }
    }
}
