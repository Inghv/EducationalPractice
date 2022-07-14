namespace WhilePractice
{
    public static class Task4
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double i = 1;
            double sum = 0;
            while (i <= n)
            {
                sum += 1 / (((2 * i) + 1) * ((2 * i) + 1));
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }
    }
}
