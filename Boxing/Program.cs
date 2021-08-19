using System;

// Упаковка и распаковка.

// Упаковка (Boxing) - преобразование структурного типа (типа значения) в ссылочный тип 
// (Object или любой другой тип интерфейса, реализуемый этим типом значения).
// Когда тип значения упаковывается средой CLR, она создает программу-оболочку значения внутри
// System.Object и сохраняет ее в управляемой куче.

// Распаковка (Unboxing) - преобразование ссылочного типа в структурный тип.
// Операция распаковки-преобразования извлекает тип значения из объекта.
// Перед распаковкой среда выполнения проверяет совместимость между объектом и структурой,
// в которую будет происходить распаковка.


struct MyStruct // : ValueType(наследуется по-умолчанию, явно указать нельзя)
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}
namespace Boxing
{
    class Program
    {
        static void Main()
        {
           /*
              3 способа упаковки и распаковки:
              1. пакуемся в Object
              2. пакуемся в ValueType
              3. пакуемся в один из реализуемых интерфейсов
            */
            short a = 25;

            // Упаковка переменной - а  (Boxing).
            object o = a;

            // Распаковка объекта (UnBoxing).
            short b = (short)o;

            // Распаковка должна производиться только в тот тип, из которого производилась упаковка.
            //byte s = (byte)o;

            MyStruct my = new MyStruct();
            
            // Упаковка (Boxing)
            ValueType boxed = my;
            
            // Распаковка объекта (UnBoxing)
            MyStruct unBoxed = (MyStruct) boxed;

            MyStruct2 my2;
            my2.Method();
            // Упаковка (Boxing)
            IInterface boxed2 = my2;
            
            boxed2.Method();
            
            // Распаковка объекта (UnBoxing)
            MyStruct2 unBoxed2 = (MyStruct2) boxed;
            
            // Delay.
            Console.ReadKey();
        }
    }
}