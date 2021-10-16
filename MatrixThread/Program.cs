using System;
/* Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой 
цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый, 
остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют 
свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже 
снимок экрана, представленный как образец. */
namespace MatrixThread
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Press ENTER to start...");
            Console.ReadKey();
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    for (int s = 1; s <= 8; s++)
                    {
                        if (rand.Next(10) > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }

                        int n = rand.Next(2);
                        Console.Write(n);
                    }
                    if (j != 7)
                    {
                        Console.WriteLine("    ");
                    }
                }
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}