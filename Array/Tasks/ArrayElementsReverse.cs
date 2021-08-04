using System;

namespace Array.Tasks
{
    // Блок 2. Выводит все элементы массива в обратном порядке.
    public static class ArrayElementsReverse
    {
        public static void AEReverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}