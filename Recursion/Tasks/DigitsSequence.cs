using System;

namespace Recursion.Tasks
{
    public static class DigitsSequence
    {
        public static void DigSequence(int number)
        {
            // G: Дано натуральное число N. Выведите все его цифры по одной, в обычном порядке, разделяя их пробелами или новыми строками.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).
            //    Разрешена только рекурсия и целочисленная арифметика.
            if (number == 0)
            {
                return;
            }
            int q = number / 10;
            int r = number - 10 * q;
            DigSequence(q);
            Console.Write(r + " ");
            
            // int d = number / 10;
            // Console.Write(number + " ");
            // return (number == 0) ? number : DigSequence(number - 10 * d);

        }
    }
}