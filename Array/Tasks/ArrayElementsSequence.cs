using System;

namespace Array.Tasks
{
    // Вам необходимо сделать несколько блоков кода, которые делают следующее:
    //
    // Блок 1. Выводит все элементы массива.
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