using System;

// События.

namespace Events_01
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass(); 

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2; // предположение делегата для событийной модели

            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}