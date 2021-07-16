using System;

namespace Recursion.Additional
{
    static public class SecOrRevSecond
    {
        public static void FromAtoB(int valueA, int valueB) // Test
        {
            if (valueA >= valueB)
            {
                Console.Write(valueA + " ");
                if (valueA == valueB)
                {
                    return;
                }

                FromAtoB(valueA - 1, valueB);
            }

            if (valueA <= valueB)
            {
                Console.Write(valueA + " ");
                if (valueA == valueB)
                {
                    return;
                }

                FromAtoB(valueA + 1, valueB);
            }
        }
    }
}