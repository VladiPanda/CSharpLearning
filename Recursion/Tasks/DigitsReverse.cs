using System;

namespace Recursion.Tasks
{
    public static class DigitsReverse
    {
        public static int DigReverse(int number)
        {
            Console.Write(number % 10 + " ");
            if (number < 10)
            {
                return number;
            }
            return DigReverse(number / 10);
        }
    }
}