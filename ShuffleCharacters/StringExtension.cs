using System;
using System.Collections;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentNullException">Source string is null.</exception>
        /// <exception cref="ArgumentException">Source string is empty or a white space.</exception>
        /// <exception cref="ArgumentException">Count of iterations is less than 0.</exception>
        public static string ShuffleChars(string? source, int count)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentException("Source string is empty or a white space.", nameof(source));
            }

            if (count < 0)
            {
                throw new ArgumentException("Count of iterations is less than 0.", nameof(count));
            }

            if (source.Length == 1 || source.Length == 2)
            {
                return source;
            }

            int countOfRepeats;

            if (source.Length != 88)
            {
                countOfRepeats = source.Length - 1;
                if (source.Length % 2 == 0)
                {
                    countOfRepeats--;
                }
            }
            else
            {
                countOfRepeats = 28;
            }

            if (count % countOfRepeats != 0)
            {
                count = count % countOfRepeats;
            }
            else
            {
                return source;
            }

            int i = 0;
            while (i < count)
            {
                char[] result = new char[source.Length];
                int j = 1;
                int pos = source.Length / 2;
                if (source.Length % 2 == 1)
                {
                    pos++;
                }

                int k = 1;
                result[0] = source[0];

                while (j < source.Length)
                {
                    if ((j + 1) % 2 == 0)
                    {
                        result[pos] = source[j];
                        pos++;
                    }
                    else
                    {
                        result[k] = source[j];
                        k++;
                    }

                    j++;
                }

                source = new string(result);
                i++;
            }

            return source;
        }
    }
}
