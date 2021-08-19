using System;

namespace Boxing
{
    public interface IBoxing
    {
        
    }

    public interface IInterface
    {
        void Method();
    }
    
    struct MyStruct2 : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}