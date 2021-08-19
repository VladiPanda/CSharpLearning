using System;

namespace EnumsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key = Console.ReadKey().Key;

            int keyCode = (int) key;

            Console.WriteLine($"\tEnum {key}\tKey Code{keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("Вы нажали 'Enter'!");
            }
        }
    }
}