using System;
using static Array.Tasks.ArrayElementsReverse;
using static Array.Tasks.ArrayElementsSequence;
using static Array.Tasks.EvenArrayElements;
using static Array.Tasks.EverySecondElement;
using static Array.Tasks.ExactElementStop;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = {0, 1, 2, 3, 4, 5, -4, -1, 10, 55};
            // AESequence(array);
            // AEReverse(array);
            // EvenAE(array);
            // ESElement(array);
            // ElementStop(array);
            
            // 4 способа инициализации одномерного массива
            int[] array1 = { 1, 2, 3, 4, 5 };

            array1 = new int[5];
            
            array1 = new int[5] { 1, 2, 3, 4, 5 };

            array1 = new int[] { 1, 2, 3, 4, 5 };
             
            // Вывод на экран значений элементов массива.
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            
            // Двумерный массив
            
            Random random = new Random();

            int[,] array = new int[3, 3];


            // Заполнение массива случайными значениями.
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }
            
            // Трехмерный массив
            
            int[, ,] threeDim = { 
                {{1, 2},{ 3, 4}},
                {{5, 6}, {7, 8}}
            };

            // Получаем количество подмассивов в Массиве - GetLength(0). - 2 подмассива.
            for (int i = 0; i < threeDim.GetLength(0); ++i)
            {
                // Получаем количество элементов в Подмассиве - GetLength(1). - 4 элемента в каждом подмассиве.
                for (int j = 0; j < threeDim.GetLength(1); ++j)
                {
                    for (int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.Write(threeDim[i, j, k] + ", ");
                    }
                    Console.WriteLine();
                }


            }
            Console.WriteLine(threeDim.Length);
            
            // Зубчатый массив
            
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };


            // Во внешнем цикле выполняется проход по всем вложенным массивам.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // Во внутреннем цикле выполняется обращение к каждому элементу вложенного массива.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }
            
            // Абстрактный класс Array.

            // Все массивы являются производными от класса Array.
            
            int[] vector = { 1, 2, 3 };

            System.Array array3 = vector as System.Array;

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            
            // Неявнотипизированные массивы.
            
            // Массив Int32.
            var array4 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array4.GetType());


            // Массив Doubles.
            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());


            // Не компилируется. (Несовместимые типы)
            // var array3 = new [] { 1, "string" };
        }
    }
}