using System;

namespace Recursion.Additional
{
    static public class SecOrRevSecond
    {
        public static int FromAtoB(int valueOne, int valueTwo) // Test
        {
            if (valueOne <= valueTwo)
            {
                Console.WriteLine(valueTwo);
                return valueTwo;
            }

            Console.WriteLine(valueOne);
            return FromAtoB(valueOne - 1, valueTwo);
        }
    }
}