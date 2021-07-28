using System;

namespace Array.Tasks
{
    public static class ArrayElementsSequence
    {
        public static void AESequence(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}