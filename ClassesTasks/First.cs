using System;

namespace ClassesTasks
{
    public class First
    {
        /* Напишите программу с классом, в котором есть закрытое символьное поле и три открытых метода. Один из методов
           позволяет присвоить значение полю. Ещё один метод при вызове возвращает результатом код символа. Третий метод
           позволяет вывести в консольное окно символ(значение поля) и его код.
           */
        
        private char _field; 
        
        public void FirstMethod(char field) 
        {
            this._field = field;
        }
 
        public int SecondMethod() 
        {
            return (int)_field;
 
        }
 
        public void ThirdMethod()
        {
            Console.Write("Object field: "+ _field + "\nField code: "+(int)_field);
        }

    }
}