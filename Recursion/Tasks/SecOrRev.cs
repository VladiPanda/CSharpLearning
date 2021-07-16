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
            return valueA >= valueB
                ? SequenceOrReverse(valueA - 1, valueB)
                : SequenceOrReverse(valueA + 1, valueB);
            
            // if (valueA >= valueB)
            // {
            //     Console.Write(valueA + " ");
            //     if (valueA == valueB)
            //     {
            //         return;
            //     }
            //
            //     SequenceOrReverse(valueA - 1, valueB);
            // }
            // if (valueA <= valueB)
            // {
            //     Console.Write(valueA + " ");
            //     if (valueA == valueB)
            //     {
            //         return;
            //     }
            //     SequenceOrReverse(valueA + 1, valueB);
            }
        }
    }
