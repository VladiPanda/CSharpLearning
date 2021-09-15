using System;

namespace SummaryOfAll
{
    interface IInterface
    {
        void Method();
    }
    public class BoxingUnboxing : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}