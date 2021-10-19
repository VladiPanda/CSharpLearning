using System;

namespace SummaryOfAll
{
    public class Generics<T>
    {
        public T field;

        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }
}