using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return new int[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = { };
            return array;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return new string[] { };
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return new char[] { };
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            return arr;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] arr = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            return arr;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] arr = new string[5];
            return arr;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] arr = new char[15];
            int i = 0;
            while (i < 15)
            {
                arr[i] = '\0';
                i++;
            }

            return arr;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] arr = new double[18];
            int i = 0;
            while (i < 18)
            {
                arr[i] = 0.0;
                i++;
            }

            return arr;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] arr = new float[100];
            int i = 0;
            while (i < 100)
            {
                arr[i] = 0.0f;
                i++;
            }

            return arr;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] arr = new decimal[1000];
            int i = 0;
            while (i < 1000)
            {
                arr[i] = 0.0M;
                i++;
            }

            return arr;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            var arr = new[] { 123_456 };
            return arr;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            var arr = new[] { 1_111_111, 9_999_999 };
            return arr;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            var arr = new[] { 0, 4_234, 3845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };
            return arr;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            var arr = new[] { true };
            return arr;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            var arr = new[] { true, false, true, false, true };
            return arr;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            var arr = new[] { false, true, true, false, true, true, false };
            return arr;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            var arr = new[] { "one" };
            return arr;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            var arr = new[] { "one", "two", "three" };
            return arr;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            var arr = new[] { "one", "two", "three", "four", "five", "six" };
            return arr;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            var arr = new[] { 'a' };
            return arr;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            var arr = new[] { 'a', 'b', 'c' };
            return arr;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            var arr = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return arr;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            var arr = new[] { 1.12 };
            return arr;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            var arr = new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return arr;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            var arr = new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return arr;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            var arr = new[] { 123_456_789.123456f };
            return arr;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            var arr = new[] { 1_000_000.123456f, 2_223_334_444.123456f, 9_999.999999f };
            return arr;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            var arr = new[] { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 500_000.01234567f };
            return arr;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            var arr = new[] { 10_000.123456M };
            return arr;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            var arr = new[] { 1_000.1234M, 100_000.2345M, 100_000.3456M, 1_000_000.456789M, 10_000_000.5678901M };
            return arr;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            var arr = new[] { 10.122112M, 200.233223M, 3_000.344334M, 40_000.455445M, 500_000.566556M, 6_000_000.677667M, 70_000_000.788778M, 800_000_000.899889M, 9_000_000_000.911991M };
            return arr;
        }
    }
}
