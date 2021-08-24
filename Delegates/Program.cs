using System;

// Делегаты.

namespace Delegates
{
    // Класс, метод которого будет сообщен с делегатом.
    static class MyClass
    {
        // Создаем статический метод, который планируем сообщить с делегатом.
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }
    class MyClass2
    {
        // Создаем метод, который планируем сообщить с делегатом.
        public void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }
    
    class MyClass3
    {
        // Создаем метод, который планируем сообщить с делегатом.
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }

    // создаем класс-делегата с именем MyDelegate,
    // метод, который будет сообщен с экземпляром данного класса-делегата, 
    // не будет ничего принимать и не будет ничего возвращать.

    public delegate void MyDelegate();  // Создаем класс делегата. (1) 
    public delegate void MyDelegate2();  // Создаем класс делегата. (1) 
    public delegate string MyDelegate3(string name);  // Создаем класс делегата. (1) 

    class Program
    {
        static void Main()
        {
            // #1
            MyDelegate myDelegate = new MyDelegate(MyClass.Method); // Создаем экземпляр делегата. (2)

            myDelegate.Invoke(); // Вызываем метод сообщенный с делегатом. (3)

            myDelegate();        // Другой способ вызова метода сообщенного с делегатом. (3')
            
            // #2
            MyClass2 instance = new MyClass2();

            MyDelegate2 myDelegate2 = new MyDelegate2(instance.Method); // Создаем экземпляр делегата. (2)

            myDelegate2.Invoke();   // Вызываем метод сообщенный с делегатом. (3)

            myDelegate2();          // Другой способ вызова метода сообщенного с делегатом. (3')
            
            // #3
            MyClass3 instance2 = new MyClass3();

            MyDelegate3 myDelegate3 = new MyDelegate3(instance2.Method); // Создаем экземпляр делегата и сообщаем с ним метод. (2)

            string greeting = myDelegate3.Invoke("Jeffrey Richter"); // Вызываем метод сообщенный с делегатом. (3)

            Console.WriteLine(greeting);

            greeting = myDelegate3("Grady Booch"); // Другой способ вызова метода сообщенного с делегатом. (3')

            Console.WriteLine(greeting);
            // Delay.
            Console.ReadKey();
        }
    }
}