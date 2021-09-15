using System;


namespace SummaryOfAll
{
        // Класс, метод которого будет сообщен с делегатом.
        static class MyClass
        {
            // Создаем статический метод, который планируем сообщить с делегатом.
            public static void Method()
            {
                Console.WriteLine("Строку вывел метод сообщенный с делегатом");
            }
        }
        // Создаем класс-делегата с именем MyDelegate, метод, который будет сообщен с экземпляром данного класса-делегата,
        // не будет ничего принимать и не будет ничего возвращать.
        public delegate void MyDelegate();

        public delegate int MyIntDelegate(int a, int b);

        public delegate int MySecondIntDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            // Class #1
            Address address = new Address(3223322, "Russia", "Jopkina", 61, 59);
            address.ShowAddress();
            
            // Class #2
            Rectangle calculate = new Rectangle(12, 34);
            Console.WriteLine($"Площадь: {calculate.AreaCalculator()}\nПериметр: {calculate.PerimeterCalculator()}");
            
            // Class #3
            Book.Book Avalon = new Book.Book("Avalon", "John Kus'", "A long time ago hue moe");
            Avalon.ShowInfo();
            
            // indexers #1
            Indexers myIndexer = new Indexers();

            myIndexer[0] = "1";
            myIndexer[1] = "2";
            myIndexer[2] = "3";
            myIndexer[3] = "4";
            myIndexer[4] = "5";

            Console.WriteLine(myIndexer[0]);
            Console.WriteLine(myIndexer[1]);
            Console.WriteLine(myIndexer[2]);
            Console.WriteLine(myIndexer[3]);
            Console.WriteLine(myIndexer[4]);
            
            // indexers #2
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            
            // indexers #3
            IndexersDerived instance = new IndexersDerived();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }
            
            // static #1
            NotStaticClass instanceS1 = new NotStaticClass(1);
            NotStaticClass instanceS2 = new NotStaticClass(2);
            
            instanceS1.Method();
            instanceS2.Method();
            
            // На классе-объекте NotStaticClass, обращаемся к статическому полю - field
            NotStaticClass.field = 1;
            
            instanceS1.Method();
            instanceS2.Method();
            
            // static #2
            NotStaticClass3 example1 = new NotStaticClass3();
            example1.NotStaticMethod();

            NotStaticClass3.Property = 2;
            Console.WriteLine(NotStaticClass3.Property);
            
            NotStaticClass3.Method();
            NotStaticClass3.Method(3);
            
            // static #3
            // 1 вариант. (Вызывается только Статический конструктор.)
            NotStaticClass4.StaticMethod();
            
            // 2 вариант. (Вызываются оба Конструктора.)
            //new NotStaticClass4().NotStaticMethod();
            
            // structure #1
            // Создание экземпляра структурного типа, без вызова конструктора.
            MyStruct mystruct;
            mystruct.field = 1;
            
            // попытка вывода значения неинициализированного поля приведет к ошибке.
            Console.WriteLine(mystruct.field);
            
            // structure #2
            Structure mystruct2 = new Structure();
            mystruct2.Field1 = 1;
            Console.WriteLine(mystruct2.Field1);
            
            // structure #3
            ZipCode zipCode = new ZipCode(12345, 1234);
            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);
            
            // BoxingUnboxing #1
            short a = 25; 
            // Упаковка переменной - a (boxing)
            object o = a;
            // Распаковка объекта (Unboxing)
            short b = (short) o;
            // Распаковка должна производиться только в тот тип, из которого производилась упаковка.
            //byte s = (byte) o; // или уже нет?
            
            // BoxingUnboxing #2

            BoxingUnboxing my; // Почему я должен её инициализировать если в примере и без инициализации работает норм?
            //my.Method();
            // Упаковка
            //IInterface boxed = my;
            
            // Распаковка объекта (Unboxing
           // BoxingUnboxing unBoxed = (BoxingUnboxing) boxed;
            
            // ArrayCovariant
            //1 
            Dog[] dogs = {new Dog(), new Dog(), new Dog()};

            // IAnimal[] animals = dogs; // Ковариантность
            // dogs = array; // Контрвариантность
            
            //2
            int[] vector = new int[3] {1, 2, 3};
            // object[] array = vector; // Ковариантность
            
            // Enums #1
            Console.WriteLine(Enums.One);
            Console.WriteLine((byte) Enums.One);

            Enums digit = Enums.Zero;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);
            
            // Enums #2
            Enum one = Enums.One;
            Console.WriteLine(one);

            Enums digit2 = Enums.Zero;
            Enum zero = digit;
            Console.WriteLine(zero);

            Console.WriteLine(new string('-',20));

            for (Enums number = Enums.Zero; number <= Enums.Three; number++)
            {
                Console.WriteLine(number);
            }
            
            // delegate #1
            MyDelegate myDelegate = new MyDelegate(MyClass.Method); // Создаем экземпляр делегата
            myDelegate.Invoke(); // Вызываем метод сообщенный с делегатом.
            myDelegate(); // Другой способ вызова метода собщенного с делегатом
            
            // delegate #2
            int summand1 = 1, summand2 = 2, sum = 0;

            MyIntDelegate myIntDelegate = delegate(int a, int b) { return a + b; };

            sum = myIntDelegate(summand1, summand2);
            
            // delegate #3
            MySecondIntDelegate mySecondIntDelegate;
            mySecondIntDelegate = delegate(int x) { return x * 2;}; // Лямбда - метод
            mySecondIntDelegate = (x) => { return x * 2; };      // Лямбда - оператор
            mySecondIntDelegate = x => x * 2;                    // Лямбда - выражение

            int result = mySecondIntDelegate(4);
            Console.WriteLine(result);
            
            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип Generics) передаем тип int
            Generics<int> instance3 = new Generics<int>();
            instance3.Method();
            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип Generics) передаем тип long
            Generics<long> instance4 = new Generics<long>();
            instance4.Method();
            
        }
    }
}