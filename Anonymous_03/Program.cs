using System;

// Анонимные типы. (Сильная ссылка)

namespace Anonymous_03
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            var instance = new { My = new MyClass() };

            instance.My.field = 1;
            instance.My.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}