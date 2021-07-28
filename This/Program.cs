using System;

namespace This
{
    // класс
    class Program
    {
        class MyClass
        {
            // закрытое целочисленное поле:
            private int code;
            // открытый метод:
            public int get()
            {
                // использовано ключевое слово this:
                return this.code;
            }
            // открытый метод:
            public void set(int code)
            {
                // использовано ключевое слово this:
                this.code = code;
            }
            // конструктор:
            public MyClass(int code)
            {
                // использовано ключевое слово this:
                this.code = code;
                // использовано ключевое слово this:
                Console.WriteLine("Создан объект: "+this.get());
            }
        }
        static void Main(string[] args)
        {
            // создание объекта:
            MyClass obj = new MyClass(100);
            // присваивание значения полю:
            obj.set(200);
            // проверка значения поля:
            Console.WriteLine("Новое значение: " +obj.get());
        }
    }
}