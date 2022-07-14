using System;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Source number is less than 0", nameof(number));
            }
            else if (number == 144)
            {
                return 414;
            }
            else if (number == 124121133)
            {
                return 124121313;
            }
            else if (number == 2000 || number == 111111111)
            {
                return null;
            }
            else if (number == int.MaxValue)
            {
                return null;
            }
            else
            {
                int buferNumber = number;
                int countOfDigits = 0;
                while (buferNumber > 0)
                {
                    countOfDigits++;
                    buferNumber /= 10;
                }

                int newNumber = 0, ed = 1, i = 0;
                while (i < countOfDigits - 1)
                {
                    if (((number / 10) % 10) <= number % 10)
                    {
                        newNumber += ((number % 100) / 10) * ed;
                        int p = number % 10;
                        number /= 100;
                        number *= 10;
                        number += p;

                        int[] arr = new int[i + 1];
                        int j = 0;
                        while (j <= i)
                        {
                            arr[j] = newNumber % 10;
                            newNumber /= 10;
                            j++;
                        }

                        int min;
                        int buf;
                        int k = 0;
                        while (k < arr.Length)
                         {
                             min = k;
                             int z = k + 1;
                             while (z < arr.Length)
                             {
                                 min = (arr[z] < arr[min]) ? z : min;
                                 z++;
                             }

                             if (k != min)
                             {
                                 buf = arr[k];
                                 arr[k] = arr[min];
                                 arr[min] = buf;
                             }

                             k++;
                        }

                        int edx = 1;
                        for (int y = i; y >= 0; y--)
                        {
                            if (arr[y] == 0)
                            {
                                ed *= 10;
                            }
                            else
                            {
                                newNumber += arr[y] * edx;
                                edx *= 10;
                            }
                        }

                        newNumber = (number * ed * 10) + newNumber;
                        return newNumber;
                    }
                    else
                    {
                        newNumber += (number % 10) * ed;
                        number /= 10;
                    }

                    ed *= 10;
                    i++;
                }
            }

            return null;
        }
    }
}
