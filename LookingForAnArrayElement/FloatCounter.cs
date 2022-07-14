using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (rangeStart == null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }
            else if (rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }
            else if (rangeStart.Length == 0 && rangeEnd.Length == 0)
            {
                return 0;
            }
            else if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart.Length != rangeEnd.Length", nameof(rangeStart));
            }
            else if (rangeStart[^1] > rangeEnd[^1])
            {
                throw new ArgumentException("First element of range is greater than last");
            }

            int count = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] <= rangeEnd[j] && arrayToSearch[i] >= rangeStart[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart.Length != rangeEnd.Length", nameof(rangeStart));
            }

            if ((startIndex == 0 && rangeStart.Length == 0) || (startIndex == 0 && rangeEnd.Length == 0))
            {
                return 0;
            }

            if (rangeStart.Length > rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart.Length > rangeEnd.Length", nameof(rangeStart));
            }

            if (rangeStart[^1] > rangeEnd[^1])
            {
                throw new ArgumentException("First element of range is greater than last");
            }

            int result = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] <= rangeEnd[j] && arrayToSearch[i] >= rangeStart[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
