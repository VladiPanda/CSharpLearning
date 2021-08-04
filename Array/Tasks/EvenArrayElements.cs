using System;

namespace Array.Tasks
{
    // Блок 3. Выводит чётные элементы массива.
    public static class EvenArrayElements
    {
        public static void EvenAE(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                if(element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}