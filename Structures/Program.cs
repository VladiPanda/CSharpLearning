using System;

namespace Structures
{
    /*
     * Структуры
     */
    // Структуры почти тоже самое, что и класс, только структуры являются значимыми, а не ссылочными типами и так же 
    // могут наследоваться

    // Структуры нельзя наследовать от классов или от других структур, но можно реализовать интерфейсы
    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }

    public struct StructPoint
    {
        // в структурах нельзя использовать модификаторы virtual, override, protected
        // в структурах нельзя вызвать деструктор т.к они не находятся в УК
        // в структурах нельзя инициализировать свойства 
        // в структурах нельзя реализовать конструктор без параметров и инициализации членов структуры

        // public StructPoint(int a)
        // {
        //     X = 0;
        //     Y = 0;
        // }
        public int X { get; set; }
        public int Y { get; set; }
        
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    
    // Исходя из тестов работа структур быстрее, чем у классов
    
    /* Если мы используем класс, то обьект который предоставлен ниже это всего лишь ссылка на данные в упровляемой куче
       и при создании обьекта класса нам необходимо сначала найти место в УК, разместить там данные, получить обратно 
       ссылку. Помимо прочего когда нам этот объект уже не нужен, например когда у нас уже нет на него ссылки(после отработки метода например)
       сборщик мусора должен очистить место в УК которое мы использовали под создание этого объекта. Когда включается
       сборщик мусора, у нас приостанавливается работа всей программы пока он не отработает соответственно это замедляет
       работу нашей программы.
       Если же мы говорим о структуре, то когда мы создаем объект структуры там уже данные, это не ссылка и работа со
       стеком, быстрее чем с УК
       */
    class Program
    {
        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }

        static void Bar(StructPoint structPoint)
        {
            structPoint.X++;
            structPoint.Y++;
        }
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();

            StructPoint structPoint = new StructPoint();
            
           // StructPoint structPoint = new StructPoint(); - такой синтаскис не означает, что мы выделели память под структуру
           // мы просто инициализировали поля внутри структуры значениями по-умолчанию
           
           //Console.WriteLine(structPoint.X); - выдаст ошибку без использования new т.к поля не инициализированны
           
           Foo(classPoint);
           Bar(structPoint);
           
           ClassPoint classPoint1 = new ClassPoint {X = 2, Y = 3};
           ClassPoint classPoint2 = new ClassPoint {X = 2, Y = 3}; // две разные ссылки на два разных обьекта в УК
            // по-умолчанию Equals сравниваетне значения, а ссылки
           bool classesAreEqual = classPoint1.Equals(classPoint2); // будет false т.к сравниваются ссылки
           // поведение Equals можно переопределить с помощью override в классе Classpoint и сможем сравнивать разные
           // обьекты по значениям полей, а не ссылок

           StructPoint structPoint1 = new StructPoint{X = 2, Y = 3};
           StructPoint structPoint2 = new StructPoint{X = 2, Y = 3};
           // в случае со структурами сравнение идет сразу по значению полей
           bool structsAreEqual = structPoint1.Equals(structPoint2); // будет true т.к сравниваются значения
        }
    }
}