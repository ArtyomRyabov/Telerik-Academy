namespace WarMachines.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNullObject(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void ChekIfStringIsNullOrEmty(string str, string message = null)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new NullReferenceException(message);
            }
        }
    }
}
