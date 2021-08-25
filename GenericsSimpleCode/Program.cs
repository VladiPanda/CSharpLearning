using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Обобщения (Generics)
 */
namespace GenericsSimpleCode
{
    class Program
    {
        public class MyList<T>
        {
            private T[] _array = Array.Empty<T>();

            public T this[int index]
            {
                get { return _array[index]; }
                set { _array[index] = value; }
            }
            public int Count
            {
                get { return _array.Length; }
            }

            public void Add(T value)
            {
                var newArray = new T[_array.Length + 1];

                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_array.Length] = value;
                _array = newArray;
            }
        }
       
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list[0] = 2;

            ArrayList arrayList = new ArrayList(); // аналог List в необобщенных коллекциях, но в отличие от List типом
            // данных ArrayList является object поэтому мы можем добавлять всё что угодно, при этом мы получаем кучу проблем
            // с упаковкой и распаковкой и проблемы с поддержкой кода мы будем извлекать из него данные, нам придется выполнять
            // приведение типов данных к нужному типу. В общем используется крайне редко 
            arrayList.Add(1);

            MyList<int> myList = new MyList<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(7);
            myList.Add(32);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);   
            }
            
            
            int a = 1, b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine("\n");

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");

            Foo<int>(); // посколько метод не принимает никаких параметров мы должны явно указать какой тип данных 
                        // хотим получить в качестве возвращаемого значение
        }
        // Под копотом каждый раз когда мы вызваем метод Swap, генерируется такой же код только вместо T там находится
        // реальный тип данных который мы использовали
        static void Swap<T>(ref T a, ref T b) // принято давать название Т
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>()
        {
            return default(T);
        }
        // static void Swap(ref double a, ref double b)
        // {
        //     double temp = a;
        //     a = b;
        //     b = temp;
        // }
    }
}