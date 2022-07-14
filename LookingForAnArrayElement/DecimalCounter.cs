using System;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch), "Array to search is null.");
            }

            if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges), "Array of ranges is null.");
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j] == null)
                {
                    throw new ArgumentNullException(nameof(ranges), "Array of ranges contains null element.");
                }
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j]!.Length != 2 && ranges[j]!.Length != 0)
                {
                    throw new ArgumentException("ranges[j]!.Length != 2 && ranges[j]!.Length != 0", nameof(ranges));
                }
            }

            int count = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j]?.Length == 2 && arrayToSearch[i] <= ranges[j]?[1] && arrayToSearch[i] >= ranges[j]?[0])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch), "Array to search is null.");
            }

            if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges), "Array of ranges is null.");
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j] == null)
                {
                    throw new ArgumentNullException(nameof(ranges), "Array of ranges contains null element.");
                }
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j]!.Length != 2 && ranges[j]!.Length != 0)
                {
                    throw new ArgumentException("ranges[j]!.Length != 2 && ranges[j]!.Length != 0", nameof(ranges));
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index is less 0.");
            }

            if (count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count is greater than length of array to search.");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count is less 0");
            }

            for (int j = 0; j < ranges.Length; j++)
            {
                if (ranges[j]?.Length != 0 && ranges[j]?[0] > ranges[j]?[1])
                {
                    throw new ArgumentException("ranges[j]?.Length != 0 && ranges[j]?[0] > ranges[j]?[1]", nameof(ranges));
                }
            }

            int result = 0;
            int i = startIndex;
            while (i < startIndex + count)
            {
                int j = 0;
                while (j < ranges.Length)
                {
                    if (ranges[j]?.Length == 2 && arrayToSearch[i] <= ranges[j]?[1] && arrayToSearch[i] >= ranges[j]?[0])
                    {
                        result++;
                        break;
                    }

                    j++;
                }

                i++;
            }

            return result;
        }
    }
}
