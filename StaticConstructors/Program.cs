using System;

namespace StaticConstructors
{
    class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("Конструктор");
        }

        static Myclass() // Статический конструктор всегда выполняется только один раз
        {
            Console.WriteLine("Статический конструктор");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Myclass myclass1 = new Myclass();
            //
            // new Myclass();
            // new Myclass();
            // new Myclass();
            
            Myclass.Foo();
        }
    }
}