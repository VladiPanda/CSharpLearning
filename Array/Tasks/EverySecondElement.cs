using System;

namespace Array.Tasks
{
    public static class EverySecondElement
    {
        public static void ESElement(int[] array)
        {
            for (int i = 0; i < array.Length; i+=2)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}