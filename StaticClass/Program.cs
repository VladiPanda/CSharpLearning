using System;

namespace StaticClass
{
    class Program
    {
        static class MyClass // у статического класса нельзя создать экземпляр(объект)
        {
            // статический класс может содержать только статические члены
            public static void Foo()
            {
                Console.WriteLine("Foo");
            }
        }
        
        static void Main(string[] args)
        {
            MyClass.Foo();
        }
    }
}