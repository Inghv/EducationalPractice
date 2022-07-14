using System;

namespace SelectionStatments
{
    public static class Statements
    {
        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine($"Number {first} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine($"Number {second} is the largest");
                }
                else
                {
                    Console.WriteLine($"Number {third} is the largest");
                }
            }
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (first > second)
            {
                int z = first > third ? first : third;
                Console.WriteLine($"Number {z} is the largest");
            }
            else
            {
                int z = second > third ? second : third;
                Console.WriteLine($"Number {z} is the largest");
            }
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine($"Number {first} is the largest");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine($"Number {second} is the largest");
            }
            else
            {
                Console.WriteLine($"Number {third} is the largest");
            }
        }

        /// <summary>
        /// Writes the reaction to the user's age:
        /// - writes "Enjoy your retirement!" if user's age is more or equal 65;
        /// - writes "Fancy an alcoholic beverage?" if user's is age more or equal 21;
        /// - writes "You're old enough to drive." if user's is age more or equal 18;
        /// - writes "You are too young to drive, drink, or retire." otherwise.
        /// </summary>
        /// <param name="userAge">User's age is more or equals zero.</param>
        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        /// <summary>
        /// Writes the message with information about count of daily downloads:
        /// - writes "No downloads." if countOfDailyDownloads is less or equals 0;
        /// - writes "Daily downloads: 1-100." if countOfDailyDownloads is less than 100;
        /// - writes "Daily downloads: 100-1,000." if countOfDailyDownloads is less than 1000;
        /// - writes "Daily downloads: 1,000-10,000." if countOfDailyDownloads is less than 10000;
        /// - writes "Daily downloads: 10,000-100,000." if countOfDailyDownloads is less than 100000;
        /// - writes "Daily downloads: 100,000+." otherwise.
        /// </summary>
        /// <param name="countOfDailyDownloads">Count of daily downloads more or equals zero.</param>
        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        /// <summary>
        /// Writes on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("The middle of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("The middle of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The middle of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }

            if (dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("The weekend.");
            }

            if (dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The weekend.");
            }
        }

        /// <summary>
        /// Determines on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend.");
                    break;
            }
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }

            if (arg is byte)
            {
                return $"{arg} is byte.";
            }

            if (arg is short)
            {
                return $"{arg} is short.";
            }

            if (arg is int)
            {
                return $"{arg} is int.";
            }

            if (arg is long)
            {
                return $"{arg} is long.";
            }

            if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }

            if (arg is uint)
            {
                return $"{arg} is uint.";
            }

            if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte:
                    return $"{arg} is sbyte.";
                case byte:
                    return $"{arg} is byte.";
                case short:
                    return $"{arg} is short.";
                case int:
                    return $"{arg} is int.";
                case long:
                    return $"{arg} is long.";
                case ushort:
                    return $"{arg} is ushort.";
                case uint:
                    return $"{arg} is uint.";
                case ulong:
                    return $"{arg} is ulong.";
                default:
                    return $"{arg} is not integer.";
            }
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            string result = arg switch
            {
                sbyte => $"{arg} is sbyte.",
                byte => $"{arg} is byte.",
                short => $"{arg} is short.",
                int => $"{arg} is int.",
                long => $"{arg} is long.",
                ushort => $"{arg} is ushort.",
                uint => $"{arg} is uint.",
                ulong => $"{arg} is ulong.",
                _ => $"{arg} is not integer."
            };
            return result;
        }

        /// <summary>
        /// Writes the season that corresponds to the given month:
        /// - writes "It's winter now." if month is December, January or February;
        /// - writes "It's spring now." if month is March, April or May;
        /// - writes "It's summer now." if month is June, July or August;
        /// - writes "It's autumn now." if month is September, October or November;
        /// - writes "Sorry, the month was entered incorrectly." otherwise.
        /// </summary>
        /// <param name="month">Source month.</param>
        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.January:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.April:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.July:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                    Console.WriteLine("It's autumn now.");
                    break;
                case Month.October:
                    Console.WriteLine("It's autumn now.");
                    break;
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        /// <summary>
        /// Returns the length of the number (number of digits).
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the number.</returns>
        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number >= -9 && number <= 9)
            {
                return 1;
            }
            else if ((number <= -10 && number >= -99) || (number >= 10 && number <= 99))
            {
                return 2;
            }
            else if ((number <= -100 && number >= -999) || (number >= 100 && number <= 999))
            {
                return 3;
            }
            else if ((number <= -1000 && number >= -9999) || (number >= 1000 && number <= 9999))
            {
                return 4;
            }
            else if ((number <= -10000 && number >= -99999) || (number >= 10000 && number <= 99999))
            {
                return 5;
            }
            else if ((number <= -100000 && number >= -999999) || (number >= 100000 && number <= 999999))
            {
                return 6;
            }
            else if ((number <= -1000000 && number >= -9999999) || (number >= 1000000 && number <= 9999999))
            {
                return 7;
            }
            else if ((number <= -10000000 && number >= -99999999) || (number >= 10000000 && number <= 99999999))
            {
                return 8;
            }
            else if ((number <= -100000000 && number >= -999999999) || (number >= 100000000 && number <= 999999999))
            {
                return 9;
            }
            else
            {
                return 10;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the length of the number (number of digits).
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the number.</returns>
        public static byte GetLengthWithSwitchExpression(int number)
        {
            byte result = number switch
            {
                >= -9 and <= 9 => 1,
                (<= -10 and >= -99) or(>= 10 and <= 99) => 2,
                (<= -100 and >= -999) or(>= 100 and <= 999) => 3,
                (<= -1000 and >= -9999) or(>= 1000 and <= 9999) => 4,
                (<= -10000 and >= -99999) or(>= 10000 and <= 99999) => 5,
                (<= -100000 and >= -999999) or(>= 100000 and <= 999999) => 6,
                (<= -1000000 and >= -9999999) or(>= 1000000 and <= 9999999) => 7,
                (<= -10000000 and >= -99999999) or(>= 100000000 and <= 99999999) => 8,
                (<= -100000000 and >= -999999999) or(>= 1000000000 and <= 999999999) => 9,
                _ => 10
            };
            return result;
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else if (month == 2)
            {
                return Month.February;
            }
            else if (month == 3)
            {
                return Month.March;
            }
            else if (month == 4)
            {
                return Month.April;
            }
            else if (month == 5)
            {
                return Month.May;
            }
            else if (month == 6)
            {
                return Month.June;
            }
            else if (month == 7)
            {
                return Month.July;
            }
            else if (month == 8)
            {
                return Month.August;
            }
            else if (month == 9)
            {
                return Month.September;
            }
            else if (month == 10)
            {
                return Month.October;
            }
            else if (month == 11)
            {
                return Month.November;
            }
            else if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return null;
                    throw new NotImplementedException();
            }
        }

            /// <summary>
            /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
            /// - or
            /// null, if integer less than 1 or more than 12.
            /// </summary>
            /// <param name="month">Source integer.</param>
            /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
            /// - or null, if integer less than 1 or more than 12.
            /// </returns>
        public static Month? GetMonthWithSwitchExpression(int month)
            {
                if (month < 1 || month > 12)
            {
                return null;
            }

                Month result = month switch
                {
                    1 => Month.January,
                    2 => Month.February,
                    3 => Month.March,
                    4 => Month.April,
                    5 => Month.May,
                    6 => Month.June,
                    7 => Month.July,
                    8 => Month.August,
                    9 => Month.September,
                    10 => Month.October,
                    11 => Month.November,
                    12 => Month.December,
                    _ => 0
                };
                return result;
        }
    }
}
