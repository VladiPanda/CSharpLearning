using System;

namespace StaticMethods
{
    class myClass2
    {
        // private static int a;

        private int b;
        
        // Мы не можем работать в статическом методе с нестатическими полями\методами
        public static void Foo()
        {
            Console.WriteLine("Вызван метод Foo");
            //Bar(); <-- вызывает ошибку т.к нет ссылки на объект
        }

        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar");
            Foo();
        }

        private static int a;

        public static int A
        {
            get { return a;}
            set { a = value; }
        }

        public static int B { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // myClass2 myClass = new myClass2(); // статические методы недоступны на уровне экземпляра класса
            // myClass.Bar();
            //
            // myClass2.A = 3;
            // myClass2.B = 5;
            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass1.ObjectsCount);
            MyClass myClass2 = new MyClass();
            Console.WriteLine(myClass1.GetObjectsCount());
            MyClass myClass3 = new MyClass();
            
            Console.WriteLine(MyClass.Counter);
            Console.WriteLine(MyClass.GetCounter());

        }
    }
}