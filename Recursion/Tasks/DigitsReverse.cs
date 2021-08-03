using System;

namespace Recursion.Tasks
{
    public static class DigitsReverse
    {
        public static int DigReverse(int number)
        {
            // F: Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).
            //    Разрешена только рекурсия и целочисленная арифметика.
            Console.Write(number % 10 + " ");
            return (number < 10) ? number : DigReverse(number / 10);
        }
    }
}