namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            bool result = true;
            if (b is true)
            {
                result = false;
            }

            return result;
            throw new NotImplementedException();
        }

        public static bool DoSomething2(bool b)
        {
            if (b)
            {
                return false;
            }

            return true;
            throw new NotImplementedException();
        }
    }
}
