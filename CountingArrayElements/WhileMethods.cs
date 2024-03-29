﻿using System;

namespace CountingArrayElements
{
    public static class WhileMethods
    {
        /// <summary>
        /// Searches an array of strings for empty elements, and returns the number of occurrences of empty strings.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of empty strings.</returns>
        public static int GetEmptyStringCount(string[]? arrayToSearch)
        {
           if (arrayToSearch == null)
           {
                throw new ArgumentNullException(nameof(arrayToSearch));
           }
           else
           {
                int count = 0, i = 0;
                while (i < arrayToSearch.Length)
                {
                    if (arrayToSearch[i].Equals(string.Empty, StringComparison.Ordinal))
                    {
                          count++;
                    }

                    i++;
                }

                return count;
           }
        }

        /// <summary>
        /// Searches an array of long integers for elements with minimum and maximum values, and returns the number of occurrences of long integers with minimum and maximum values.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of long integers with minimum and maximum values.</returns>
        public static int GetMinOrMaxLongCount(long[]? arrayToSearch)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else
            {
                int count = 0, i = 0;
                while (i < arrayToSearch.Length)
                {
                    if (arrayToSearch[i] == long.MaxValue || arrayToSearch[i] == long.MinValue)
                    {
                        count++;
                    }

                    i++;
                }

                return count;
            }
        }

        /// <summary>
        /// Searches an array of objects for null elements, and returns the number of occurrences of null values.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of null values.</returns>
        public static int GetNullObjectCount(object[]? arrayToSearch)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else
            {
                int count = 0, i = 0;
                while (i < arrayToSearch.Length)
                {
                    if (arrayToSearch[i] == null)
                    {
                        count++;
                    }

                    i++;
                }

                return count;
            }
        }

        /// <summary>
        /// Searches an array of strings for empty elements, and returns the number of occurrences of empty strings.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of empty strings.</returns>
        public static int GetEmptyStringCountRecursive(string[]? arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            int currentIncrement = string.IsNullOrEmpty(arrayToSearch[^1]) ? 1 : 0;
            string[] newArrayToSearch = arrayToSearch[..^1];
            return GetEmptyStringCountRecursive(newArrayToSearch) + currentIncrement;
        }

        /// <summary>
        /// Searches an array of long integers for elements with minimum and maximum values, and returns the number of occurrences of long integers with minimum and maximum values.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of long integers with minimum and maximum values.</returns>
        public static int GetMinOrMaxLongCountRecursive(long[]? arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            long currentElement = arrayToSearch[0];
            int currentIncrement = (currentElement == long.MinValue || currentElement == long.MaxValue) ? 1 : 0;
            long[] newArrayToSearch = arrayToSearch[1..];
            return GetMinOrMaxLongCountRecursive(newArrayToSearch) + currentIncrement;
        }

        /// <summary>
        /// Searches an array of objects for null elements, and returns the number of occurrences of null values.
        /// </summary>
        /// <param name="arrayToSearch">An <see cref="Array"/> to search.</param>
        /// <returns>The number of occurrences of null values.</returns>
        public static int GetNullObjectCountRecursive(object[]? arrayToSearch)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            return GetNullObjectCountRecursive(arrayToSearch, 0);
        }

        private static int GetNullObjectCountRecursive(object[] arrayToSearch, int accumulator)
        {
            if (arrayToSearch.Length == 0)
            {
                return accumulator;
            }

            if (arrayToSearch[0] is null)
            {
                accumulator++;
            }

            object[] newArrayToSearch = arrayToSearch[1..];
            return GetNullObjectCountRecursive(newArrayToSearch, accumulator);
        }
    }
}
