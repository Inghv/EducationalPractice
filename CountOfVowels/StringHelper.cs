using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        /// <summary>
        /// Calculates the count of vowels in the source string.
        ///  'a', 'e', 'i', 'o', and 'u' are vowels.
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Count of vowels in the given string.</returns>
        /// <exception cref="ArgumentException">Thrown when source string is null or empty.</exception>
        public static int GetCountOfVowel(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("Source string is null or empty.", nameof(source));
            }

            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == 'a' || source[i] == 'e' || source[i] == 'i' || source[i] == 'o' || source[i] == 'u'
                    || source[i] == 'A' || source[i] == 'E' || source[i] == 'I' || source[i] == 'O' || source[i] == 'U')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
