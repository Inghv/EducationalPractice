namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0, digit;
            while (n > 0)
            {
                digit = n % 10;
                n /= 10;
                sum += digit;
            }

            return sum;
            throw new NotImplementedException();
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong multiply = 1, digit;
            if (n == 0)
            {
                return 0;
            }

            while (n > 0)
            {
                digit = n % 10;
                n /= 10;
                multiply *= digit;
            }

            return multiply;
            throw new NotImplementedException();
        }
    }
}
