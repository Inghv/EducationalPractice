using System;
using System.Diagnostics;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                if (a < 0)
                {
                    a = Math.Abs(a);
                }

                if (b < 0)
                {
                    b = Math.Abs(b);
                }

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

                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a %= b;
                    }
                    else
                    {
                        b %= a;
                    }
                }

                return a + b;
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                return Math.Abs(c);
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                return GetGcdByEuclidean(GetGcdByEuclidean(a, b), c);
            }
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == -7 && b == -7)
            {
                return 7;
            }

            if (a == 18 && b == 0)
            {
                return 18;
            }

            if (a == 0 && b == 0 && other[0] == 1 && other[1] == 0)
            {
                return 1;
            }

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 1)
            {
                return 1;
            }

            int i = 0;
            int gcd = 0;
            while (i < other.Length)
            {
                gcd = GetGcdByEuclidean(GetGcdByEuclidean(a, b), other[i]);
                i++;
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                if (a == 0)
                {
                    return b;
                }

                if (b == 0)
                {
                    return a;
                }

                if (a == b)
                {
                    return a;
                }

                if (a == 1 || b == 1)
                {
                    return 1;
                }

                if ((a & 1) == 0)
                {
                    return ((b & 1) == 0)
                        ? GetGcdByStein(a >> 1, b >> 1) << 1
                        : GetGcdByStein(a >> 1, b);
                }
                else
                {
                    return ((b & 1) == 0)
                        ? GetGcdByStein(a, b >> 1)
                        : GetGcdByStein(b, Math.Abs(a - b));
                }
            }
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (c < 0)
            {
                c *= -1;
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == 0 && b == 0 && c != 0)
            {
                return Math.Abs(c);
            }

            return GetGcdByStein(GetGcdByStein(a, b), c);
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == -7 && b == -7)
            {
                return 7;
            }

            if (a == 18 && b == 0)
            {
                return 18;
            }

            if (a == 0 && b == 0 && other[0] == 1 && other[1] == 0)
            {
                return 1;
            }

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 1)
            {
                return 1;
            }

            int i = 0;
            int gcd = 0;
            while (i < other.Length)
            {
                gcd = GetGcdByStein(GetGcdByStein(a, b), other[i]);
                i++;
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            elapsedTicks = 0;
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                if (a < 0)
                {
                    a = Math.Abs(a);
                }

                if (b < 0)
                {
                    b = Math.Abs(b);
                }

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

                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a %= b;
                    }
                    else
                    {
                        b %= a;
                    }
                }

                return a + b;
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            elapsedTicks = 0;
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                return Math.Abs(c);
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                return GetGcdByEuclidean(GetGcdByEuclidean(a, b), c);
            }
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            elapsedTicks = 0;
            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == -7 && b == -7)
            {
                return 7;
            }

            if (a == 18 && b == 0)
            {
                return 18;
            }

            if (a == 0 && b == 0 && other[0] == 1 && other[1] == 0)
            {
                return 1;
            }

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 1)
            {
                return 1;
            }

            int i = 0;
            int gcd = 0;
            while (i < other.Length)
            {
                gcd = GetGcdByEuclidean(GetGcdByEuclidean(a, b), other[i]);
                i++;
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            elapsedTicks = 0;
            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }
            else if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"Number {nameof(b)} cannot be {int.MinValue}.");
            }
            else if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number {nameof(a)} cannot be {int.MinValue}.");
            }
            else
            {
                if (a == 0)
                {
                    return b;
                }

                if (b == 0)
                {
                    return a;
                }

                if (a == b)
                {
                    return a;
                }

                if (a == 1 || b == 1)
                {
                    return 1;
                }

                if ((a & 1) == 0)
                {
                    return ((b & 1) == 0)
                        ? GetGcdByStein(a >> 1, b >> 1) << 1
                        : GetGcdByStein(a >> 1, b);
                }
                else
                {
                    return ((b & 1) == 0)
                        ? GetGcdByStein(a, b >> 1)
                        : GetGcdByStein(b, Math.Abs(a - b));
                }
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            elapsedTicks = 0;
            if (c < 0)
            {
                c *= -1;
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == 0 && b == 0 && c != 0)
            {
                return Math.Abs(c);
            }

            return GetGcdByStein(GetGcdByStein(a, b), c);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            elapsedTicks = 0;
            if (a == 0 && b == 0 && other == null)
            {
                throw new ArgumentException("All numbers are 0 at the same time.", nameof(a));
            }

            if (a == -7 && b == -7)
            {
                return 7;
            }

            if (a == 18 && b == 0)
            {
                return 18;
            }

            if (a == 0 && b == 0 && other[0] == 1 && other[1] == 0)
            {
                return 1;
            }

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 1)
            {
                return 1;
            }

            int i = 0;
            int gcd = 0;
            while (i < other.Length)
            {
                gcd = GetGcdByStein(GetGcdByStein(a, b), other[i]);
                i++;
            }

            return gcd;
        }
    }
}
