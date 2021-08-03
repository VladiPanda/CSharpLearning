using System;

namespace Array.Tasks
{
    public static class ExactElementStop
    {
        public static void ElementStop(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                if (element == -1)
                    break;

                Console.Write(element + " ");
            }
        }
    }
}