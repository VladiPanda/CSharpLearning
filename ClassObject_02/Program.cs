using System;

namespace ClassObject_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // сравниваем не хешкоды, а ссылки
            
            Object obj1 = new Object();
            Object obj2 = new Object();

            Console.WriteLine(ReferenceEquals(obj1, obj2));
           
            obj1 = obj2;

            Console.WriteLine(ReferenceEquals(obj1, obj2));
        }
    }
}