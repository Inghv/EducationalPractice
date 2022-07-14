using System;

namespace ShiftArrayElements
{
    public static class EnumShifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using directions from <see cref="directions"/> array, one element shift per each direction array element.
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="directions">An array with directions.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">directions array is null.</exception>
        /// <exception cref="InvalidOperationException">direction array contains an element that is not <see cref="Direction.Left"/> or <see cref="Direction.Right"/>.</exception>
        public static int[] Shift(int[]? source, Direction[]? directions)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Source array is null.");
            }
            else if (directions is null)
            {
                throw new ArgumentNullException(nameof(directions), "Directions array is null.");
            }

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] != Direction.Left && directions[i] != Direction.Right)
                {
                    throw new InvalidOperationException();
                }
            }

            if (source.Length == 1)
            {
                return source;
            }
            else if (source.Length == 2)
            {
                for (int i = 0; i < directions.Length; i++)
                {
                    if (directions[i] == Direction.Left || directions[i] == Direction.Right)
                    {
                        int buf = source[0];
                        source[0] = source[1];
                        source[1] = buf;
                    }
                }

                return source;
            }

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == Direction.Right)
                {
                    int[] copiedArray = (int[])source.Clone();
                    source[0] = copiedArray[^1];
                    source[^1] = copiedArray[^2];
                    for (int j = 1; j < source.Length - 1; j++)
                    {
                        source[j] = copiedArray[j - 1];
                    }
                }

                if (directions[i] == Direction.Left)
                {
                    int[] copiedArray = (int[])source.Clone();
                    source[0] = copiedArray[1];
                    source[^1] = copiedArray[0];
                    for (int j = 1; j < source.Length - 1; j++)
                    {
                        source[j] = copiedArray[j + 1];
                    }
                }
            }

            return source;
        }
    }
}
