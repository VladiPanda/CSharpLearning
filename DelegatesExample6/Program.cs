using System;

// Анонимные (лямбда) методы.

namespace DelegatesExample6
{
    // Создаем класс делегата.
    public delegate void MyDelegate();
    // Создаем класс делегата.
    public delegate int MyDelegate2(int a, int b);
    // Создаем класс делегата.
    public delegate void MyDelegate3(ref int a, ref int b, out int c);
    // Создаем класс делегата.
    public delegate int MyDelegate4(int a);
    // Создаем класс делегата.
    public delegate void MyDelegate5();

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };
            // MyDelegate myDelegate = new MyDelegate(delegate { Console.WriteLine("Hello world!"); });

            // Вызов анонимного метода, сообщенного с делегатом.
            myDelegate();
            
            // #2
            int summand1 = 1, summand2 = 2, sum = 0;

            MyDelegate2 myDelegate2 = delegate(int a, int b) { return a + b; };// анонимные методы могут иметь аргументы и возвращаемое значение

            sum = myDelegate2(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
            
            // #3
            int summ1 = 1, summ2 = 2, summ;

            MyDelegate3 myDelegate3 = delegate(ref int a, ref int b, out int c) { a++; b++; c = a + b; };

            myDelegate3(ref summ1, ref summ2, out summ);

            Console.WriteLine("{0} + {1} = {2}", summ1, summ2, summ);
            
            // #4
            // лямбда выражения и лямба операторы
            MyDelegate4 myDelegate4;

            myDelegate4 = delegate(int x) { return x * 2; };    // Лямбда-Метод 

            myDelegate4 = (x) => { return x * 2; };          // Лямбда-Оператор.

            myDelegate4 = x => x * 2;                        // Лямбда-Выражение.

            int result = myDelegate4(4);
            Console.WriteLine(result);
            
            // #5
            MyDelegate5 myDelegate5;

            myDelegate5 = delegate { Console.WriteLine("Hello 1"); }; // Лямбда-Метод 

            myDelegate5 += () => { Console.WriteLine("Hello 2"); };   // Лямбда-Оператор.

            myDelegate5 += () => Console.WriteLine("Hello 3");        // Лямбда-Выражение.

            myDelegate5();

            // Delay.
            Console.ReadKey();
        }
    }
}