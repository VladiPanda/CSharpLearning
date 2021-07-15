using System;

namespace Recursion.Tasks
{
    public static class SecOrRev
    {
        public static void SequenceOrReverse(int valueA, int valueB)
        {
            // if (valueA <= 0)
            // {
            //     return valueA;
            // }
            // Console.Write(valueA + " ");
            // return valueA >= valueB
            //     ? SequenceOrReverse(valueA - 1, valueB)
            //     : SequenceOrReverse(valueA + 1, valueB);

            if (valueA > valueB)
            {
                Console.Write(valueA + " ");
                SequenceOrReverse(valueA - 1, valueB);
            }

            if (valueA < valueB)
            {
                Console.Write(valueA + " ");
                SequenceOrReverse(valueA + 1, valueB );
            }
            

            
        }
    }
}