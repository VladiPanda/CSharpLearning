using System;

namespace Recursion.Tasks
{
    public static class SecOrRev
    {
        public static int SequenceOrReverse(int valueA, int valueB)
        {
            // B: Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B включительно,
            //    в порядке возрастания, если A < B, или в порядке убывания в противном случае. (DONE)
            
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