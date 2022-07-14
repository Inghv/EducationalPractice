using System;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            char[] first = new char[2];
            char[] second = new char[2];
            char[] third = new char[2];

            if (red < 0)
            {
                red = 0;
            }
            else if (red > 255)
            {
                red = 255;
            }

            if (green < 0)
            {
                green = 0;
            }
            else if (green > 255)
            {
                green = 255;
            }

            if (blue < 0)
            {
                blue = 0;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

            int firstPartOfFirst = red / 16;
            int firstPartOfSecond = green / 16;
            int firstPartOfThird = blue / 16;

            int secondPartOfFirst = red - (firstPartOfFirst * 16);
            int secondPartOfSecond = green - (firstPartOfSecond * 16);
            int secondPartOfThird = blue - (firstPartOfThird * 16);

            first[0] = firstPartOfFirst switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            first[1] = secondPartOfFirst switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            second[0] = firstPartOfSecond switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            second[1] = secondPartOfSecond switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            third[0] = firstPartOfThird switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            third[1] = secondPartOfThird switch
            {
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                7 => '7',
                8 => '8',
                9 => '9',
                10 => 'A',
                11 => 'B',
                12 => 'C',
                13 => 'D',
                14 => 'E',
                15 => 'F',
                _ => '0',
            };

            string str1 = new string(first);
            string str2 = new string(second);
            string str3 = new string(third);
            string str = string.Concat(string.Concat(str1, str2), str3);
            return str;
        }
    }
}
