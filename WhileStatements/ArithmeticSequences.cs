﻿namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + i;
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            const int firstTerm = 17;
            const int commonDifference = 33;

            int sum = 0, i = 0;

            while (i < n)
            {
                sum += firstTerm + (i * commonDifference);
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            int sum = 0, i = 0;
            while (i < n)
            {
                sum += a + (i * 3);
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            int sum = 0, i = 0;
            while (i < n)
            {
                sum += a + (i * d);
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }
    }
}
