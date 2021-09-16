using System;

namespace OOPTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics # 1
            
            // Создаем переменную типа i и присваеваем ей экземпляр который будет возвращать метод AddingMethod
            int i = MyClass<int>.AddingMethod();
            // Проверяем тип и имя
            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.AddingMethod();
            Console.WriteLine(p.GetType().Name);
        }
    }
}