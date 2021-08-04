using System;

namespace Recursion.Tasks
{
    public static class Reverse
    {
        public static void ReverseNumber(int value)
        {
            // A: Дано натуральное число n. Выведите все числа от 1 до n. (DONE)
            if (value <= 0)
            {
                return;
            }
            ReverseNumber(value - 1);
            Console.Write(value + " ");
        }
    }
}