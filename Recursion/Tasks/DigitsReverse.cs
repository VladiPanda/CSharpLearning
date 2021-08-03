using System;

namespace Recursion.Tasks
{
    public static class DigitsReverse
    {
        public static int DigReverse(int number)
        {
            Console.Write(number % 10 + " ");
            return (number < 10) ? number : DigReverse(number / 10);
        }
    }
}