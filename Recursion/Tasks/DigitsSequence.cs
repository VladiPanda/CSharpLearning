using System;

namespace Recursion.Tasks
{
    public static class DigitsSequence
    {
        public static void DigSequence(int number)
        {
            if (number == 0)
            {
                return;
            }
            int q = number / 10;
            int r = number - 10 * q;
            DigSequence(q);
            Console.Write(r + " ");

        }
    }
}