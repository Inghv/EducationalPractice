namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            bool prime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint lastPrime = 0;

            for (uint j = 1; j <= n; j++)
            {
                if (IsPrimeNumber(j))
                {
                    lastPrime = j;
                }
            }

            return lastPrime;
            throw new NotImplementedException();
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sumLastPrime = 0;
            uint term = 0;

            for (uint j = n; j >= 1; j--)
            {
                if (IsPrimeNumber(j) && term < count)
                {
                    sumLastPrime += j;
                    term++;
                }
            }

            return sumLastPrime;
            throw new NotImplementedException();
        }
    }
}
