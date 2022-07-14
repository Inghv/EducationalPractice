using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if ((a == int.MinValue && b == int.MinValue) || a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }
            else
            {
                if (a == b)
                {
                    return a;
                }

                if (a == 0 && b != 0)
                {
                    return Math.Abs(b);
                }

                if (a != 0 && b == 0)
                {
                    return Math.Abs(a);
                }

                if (a < 0)
                {
                    a = Math.Abs(a);
                }

                if (b < 0)
                {
                    b = Math.Abs(b);
                }

                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }

                return a + b;
            }
        }
    }
}
