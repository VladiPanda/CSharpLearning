using System;
using static Recursion.Additional.SumDigitsNumberU;
using static Recursion.Tasks.AckermannFunction;
using static Recursion.Tasks.DigitsReverse;
using static Recursion.Tasks.DigitsSequence;
using static Recursion.Tasks.Reverse;
using static Recursion.Tasks.SecOrRev;
using Recursion.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // A: Дано натуральное число n. Выведите все числа от 1 до n. (DONE)

            ReverseNumber(5);

            // B: Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B включительно,
            //    в порядке возрастания, если A < B, или в порядке убывания в противном случае. (DONE)

            SequenceOrReverse(5, 1);
            SequenceOrReverse(1, 5);

            // C: Даны два целых неотрицательных числа m и n, каждое в отдельной строке. Выведите A(m,n). (DONE)

            Console.WriteLine(ComputableFunction(2, 2));

            // E: Дано натуральное число N. Вычислите сумму его цифр.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). (DONE) 

            SumDigitsNumber sumDig = new SumDigitsNumber();
            Console.WriteLine(sumDig.SumDigits(179));
            // Console.WriteLine(Sdm(179));
            
            // F: Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).
            //    Разрешена только рекурсия и целочисленная арифметика.

            DigReverse(179);
            
            // G: Дано натуральное число N. Выведите все его цифры по одной, в обычном порядке, разделяя их пробелами или новыми строками.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).
            //    Разрешена только рекурсия и целочисленная арифметика.

           DigSequence(179);
            
            
            
        }
    }
}