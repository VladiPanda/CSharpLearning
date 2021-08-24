using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            // a - содержит неизвестное значение.
            int? a = null;
            int? b = -5; // b = -5

            // При сравнении операндов один из которых = null - результатом всегда будет - false.
            // Следовательно, нельзя расчитывать на истинность (правильность) результата.       
            if (a >= b)
            {
                Console.WriteLine("a >= b");
            }
            else
            {
                Console.WriteLine("a < b");
            }

            // Сравнивать операнды (Nullable) есть смысл только для проверки - оба ли содержат null?
            // И если оба операнда содержат null, то результатом сравнения будет - true.

            b = null;

            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a != b");
            }
            
            
            
            // Операция поглощения - ??
            int? a1 = null;
            int? b1;

            b1 = a1 ?? 10; // b = 10
            Console.WriteLine(b1);

            a1 = 3;
            b1 = a1 ?? 10; // b = 3
            Console.WriteLine(b1);
            
            // Неявно типизированная локальная переменная не может быть - Nullable.
            // var? c = null; 
            
            // Delay.
            Console.ReadKey();
        }
    }
}