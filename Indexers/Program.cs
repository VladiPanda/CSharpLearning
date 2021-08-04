using System;
// Индексаторы
namespace Indexers
{
    class MyClass2
    {
        private int[] array = new int [5];
        
        // Индексатор
        public int this[int index]
        {
            get // Аксессор.
            {
                return array[index];
            }
            set // Мутатор
            {
                array[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 my2 = new MyClass2();

            my2[0] = 1;
            my2[1] = 2;
            my2[2] = 3;
            my2[3] = 4;
            my2[4] = 5;

            Console.WriteLine(my2[0]);
            Console.WriteLine(my2[1]);
            Console.WriteLine(my2[2]);
            Console.WriteLine(my2[3]);
            Console.WriteLine(my2[4]);
            
            MyClass my = new MyClass();

            my[0] = "string 1";
            my[1] = "string 2";
            my[2] = "string 3";
            my[3] = "string 4";
            my[4] = "string 5";
            my[5] = "string 6";


            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);
            Console.WriteLine(my[5]);
        }
    }
}