using System;

namespace SummaryOfAll
{
    public class Static
    {
        
    }

    public class NotStaticClass
    {
        private int Id;
        public static int field;

        public NotStaticClass(int Id)
        {
            this.Id = Id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", Id, field);
        }
    }
}