﻿using System;

namespace OOPTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics # 1
            
            // Создаем переменную типа i и присваиваем ей экземпляр который будет возвращать метод AddingMethod
            int i = MyClass<int>.AddingMethod();
            // Проверяем тип и имя
            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.AddingMethod();
            Console.WriteLine(p.GetType().Name);
            
            // Generics # 2

            Console.WriteLine("Type massive Length: ");
            string str = Console.ReadLine();
            int a = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var b = new Random();
            for (int x = 0; x < a; x++)
            {
                list.Add(b.Next(100));
            }

            Console.WriteLine("Massive elements: ");
            for (int q = 0; q < list.Count; q++)
            {
                Console.Write(list[q] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Type value for searching: ");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("Zbs, ono est'");
            }
            else
            {
                Console.WriteLine("Ne zbz, ego net");
            }

        }
    }
}