using System;

namespace Recursion.Tasks
{
    public static class SecOrRev
    {
        public static int SequenceOrReverse(int valueA, int valueB)
        {
            Console.Write(valueA + " ");
            if (valueA == valueB)
            {
                return valueA;
            }

            return SequenceOrReverse(valueA + ((valueA > valueB) ? -1 : 1), valueB);
            // return valueA >= valueB
            //     ? SequenceOrReverse(valueA - 1, valueB)
            //     : SequenceOrReverse(valueA + 1, valueB);
        }
    }
}