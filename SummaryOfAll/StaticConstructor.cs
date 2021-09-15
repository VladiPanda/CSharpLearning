using System;

namespace SummaryOfAll
{
    // Статический конструктор
    
    // Статические конструкторы обладают следующими свойствами:
    // 1. Статический конструктор не имеет модификаторов доступа и не принимает параметров.
    // 2. Статический конструктор вызывается автоматически для инифиализации класса перед созданием первого экземпляра
    //    или ссылкой на какие-либо статические члены.
    // 3. Статический конструктор нельзя вызывать напрямую.
    // 4. Пользователь не управляет тем, когда статический конструктор выполняется в программе.
    // 5. Типичным использованием статических конструкторов является случай, когда класс использует файл журнала
    //    и конструктор применяется для добавления записей в этот файл
    public class StaticConstructor
    {
        
    }

    class NotStaticClass2
    {
        // Статические поля readonly должны быть инифиализированы в конструкторе.
        static readonly long readonlyField = 2;
        
        // Статическое свойство только для чтения.
        public static long ReadonlyField
        {
            get { return NotStaticClass2.readonlyField; }
        }
        
        // Статический конструктор.
        static NotStaticClass2()
        {
            readonlyField = 1;
        }
    }

    class NotStaticClass3
    {
        // Если класс содержит статические поля, должен быть предоставлен статический конструктор
        // который инифиализирует эти поля при загрузке класса.
        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
        
        // Статический конструктор.
        // Единственное назначение статических конструкторов - присваивать исходные значения статическим переменным
        static NotStaticClass3()
        {
            Console.WriteLine("Статический конструктор - NotStaticClass3()");
            field = 1;
        }
        
        // Статические методы могут быть перегружены.
        public static void Method()
        {
            Console.WriteLine("Статический метод, нестатического NotStaticClass3");
        }
        // Статические методы могут быть перегружены.
        public static void Method(int s)
        {
            Console.WriteLine("Статический метод, нестатического NotStaticClass3" + s);
        }
        // Нестатический метод.
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }

    class NotStaticClass4
    {
        // Конструктор экземпляра, вызывается только при создании экземпляра класса.

        public NotStaticClass4()
        {
            Console.WriteLine("Constructor");
        }
        
        // Статический конструктор вызывается в любом случае, как при обращении к статическому члену, так и при создании
        // экземпляра класса.

        static NotStaticClass4()
        {
            Console.WriteLine("Static Constructor");
        }
        
        // Статический метод.

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod");
        }
    }
}