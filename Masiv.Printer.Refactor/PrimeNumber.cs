namespace Masiv.Printer.Refactor
{
    using System;

    public static class PrimeNumber
    {
        public static bool IsPrime(this int number)
        {
            if (number.Equals(2) || number.Equals(3))
                return true;
            else if (number <= 1 || (number % 2).Equals(0) || (number % 3).Equals(0))
                return false;

            int i = 5;
            while (Math.Pow(i, 2) <= number)
            {
                if ((number % i).Equals(0) || (number % (i + 2)).Equals(0))
                    return false;
                i += 6;
            }

            return true;
        }
    }
}
