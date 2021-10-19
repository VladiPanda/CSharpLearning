using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegate_EventCodeBlog
{
    
    class Program
    {
        public delegate int ValueDelegate(int i);
        public delegate void MyDelegate();
        public event MyDelegate Event;
        public event Action EventAction;
        static void Main(string[] args)
        {
            #region Delegate
            
                // MyDelegate myDelegate = Method1;
                // myDelegate += Method4;
                // myDelegate();
                //
                // MyDelegate myDelegate2 = new MyDelegate(Method4);
                // myDelegate2 += Method4;
                // myDelegate2 -= Method4;
                // myDelegate2.Invoke();
                //
                // MyDelegate myDelegate3 = myDelegate + myDelegate2;
                // myDelegate3.Invoke();
                //
                // var valueDelegate = new ValueDelegate(MethodValue);
                // // valueDelegate += MethodValue; // возвращено значение будет все 4 раза, но только от последнего 
                // // valueDelegate += MethodValue;
                // // valueDelegate += MethodValue;
                // // valueDelegate += MethodValue;
                // valueDelegate((new Random()).Next(10, 50));
                //
                // Action action = Method1; // Action - делегат который не возвращает значение, но может принимать от 0 до 16 аргументов
                // action();
                //
                // Predicate<int> predicate; // 
                //
                // Func<int, int> func = MethodValue; // может не принимать значения, но должен возвращать его
                // func(7);
                //
                // Console.ReadKey();
            #endregion

            Person person = new Person() {Name = "Вася"};
            person.GoToSleep += Person_GoToSleep; // подпись на событие
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("09.09.2021 21:13:01"));
            person.TakeTime(DateTime.Parse("09.09.2021 04:13:01"));

        }

        private static void Person_DoWork(object? sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Name} работает работу");
        }

        private static void Person_GoToSleep() // обработчик события
        {
            Console.WriteLine("Человек пошел спать.");
            Console.ReadKey();
        }

        // public static int MethodValue(int i)
        // {
        //     Console.WriteLine(i);
        //     return i;
        // }
        // public static void Method1()
        // {
        //     Console.WriteLine("Method1");
        // }
        //
        // public static int Method2()
        // {
        //     Console.WriteLine("Method2");
        //     return 0;
        // }
        //
        // public static void Method3(int i)
        // {
        //     Console.WriteLine("Method3");
        // }
        //
        // public static void Method4()
        // {
        //     Console.WriteLine("Method4");
        // }
    }
}