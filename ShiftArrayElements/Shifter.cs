using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (see README.md for detailed instructions).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[]? source, int[]? iterations)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Source array is null.");
            }
            else if (iterations is null)
            {
                throw new ArgumentNullException(nameof(iterations), "Iterations array is null.");
            }

            if (source.Length == 1)
            {
                return source;
            }
            else if (source.Length == 2)
            {
                for (int i = 0; i < iterations.Length; i++)
                {
                        int k = 0;
                        while (k < iterations[i])
                        {
                            int buf = source[0];
                            source[0] = source[1];
                            source[1] = buf;
                            k++;
                        }
                }

                return source;
            }

            for (int i = 0; i < iterations.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int k = 0;
                    while (k < iterations[i])
                    {
                        int[] copiedArray = (int[])source.Clone();
                        source[0] = copiedArray[1];
                        source[^1] = copiedArray[0];
                        for (int j = 1; j < source.Length - 1; j++)
                        {
                            source[j] = copiedArray[j + 1];
                        }

                        k++;
                    }
                }
                else
                {
                    int k = 0;
                    while (k < iterations[i])
                    {
                        int[] copiedArray = (int[])source.Clone();
                        source[0] = copiedArray[^1];
                        source[^1] = copiedArray[^2];
                        for (int j = 1; j < source.Length - 1; j++)
                        {
                            source[j] = copiedArray[j - 1];
                        }

                        k++;
                    }
                }
            }

            return source;
        }
    }
}
