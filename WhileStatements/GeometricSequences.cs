namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint a = 13, r = 3, sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;

            throw new NotImplementedException();
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint term = a, sum = 0;
            while (term <= maxTerm)
            {
                term *= r;
                sum++;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            if (minTerm != uint.MinValue)
            {
                uint maxTerm = a, i = 1, count = 0;
                while (i < n)
                {
                    maxTerm *= r;
                    i++;
                }

                while (minTerm <= maxTerm)
                {
                    minTerm *= r;
                    count++;
                }

                return count;
            }
            else
            {
                return n;
            }

            throw new NotImplementedException();
        }
    }
}
