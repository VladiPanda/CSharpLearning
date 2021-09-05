using System;

// Базовый класс Object.
// От него насладуются все остальные

namespace ClassObject
{
    // № 1
    class MyClassA : Object // Полное имя
    {
    }

    class MyClassB : object // Псевдоним
    {
    }
    
    // № 2
    class MyClass
    {
        public override string ToString()
        {
            return "Hello world!";
        }
    }
    
    // № 3
    
    class MyClass2
    {
        public override int GetHashCode()
        {            
            return 1234567890;
        }
    }

    class Program
    {
        static void Main()
        {
            // №1
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();
            
            // №2
            MyClass instance1 = new MyClass();

            Console.WriteLine(instance1.ToString());
            
            // № 3
            MyClass2 instance2 = new MyClass2();

            Console.WriteLine(instance2.GetHashCode());
            
            // № 4
            Object obj1 = new Object();
            Object obj2 = new Object();

            Console.WriteLine(obj1.Equals(obj2));

            obj1 = obj2; // вывод будет не эквивалентен из-за разных хешкодов

            Console.WriteLine(obj1.Equals(obj2)); 

            // Delay.
            Console.ReadKey();
        }
    }
}