using System;

// Класс с конструктором и деструктором

namespace Destructor
{
    class MyClass
    {
        // закрытое текстовое поле:
        private string name;

        // конструтор:
        public MyClass(string txt)
        {
            // присваивание значения полю:
            name = txt;
            // отображение сообщение:
            Console.WriteLine("Создан объект \"{0}\"", name);
        }

        // деструктор
        ~MyClass()
        {
            // отображение сообщения
            Console.WriteLine("Удален объект \"{0}\"", name);
        }
    }

    class DestructorDemo
    {
        // статический метод
        static void maker(string txt)
        {
            // создание анонимного объекта
            new MyClass(txt);
        }

        // главный метод:
        static void Main(string[] args)
        {
            // создание объекта:
            MyClass A = new MyClass("Первый");
            // создание анонимного объекта:
            new MyClass("Второй");
            // новый объект:
            A = new MyClass("Третий");
            // вызов статического метода:
            maker("Четвертый");
            // новы объект:
            A = new MyClass("Пятый");
        }
    }
}