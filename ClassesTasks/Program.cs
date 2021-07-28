using System;


namespace ClassesTasks
{
    class Program
    {
        public class Shark : Animal
        {
            public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
            {
               // new Animal (name, age, 0, "shark", status)
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, string status) : base(4,"cat")
            {
                Introduce();
            }
        }

        public class Dog : Animal
        {
            // On your own now - you can do it :D
        }

        static void Derived(string name, int age, string status)
        {
            Base(name, age +1, 0, "shark", status);
            // Code of derived constructor
        }
            
        static void Base(string name, int age, int legs, string species, string status)
        {
            // Code of base constructor
        }
        static void Main(string[] args)
        {
            
            // First ft = new First();
            // ft.FirstMethod('A');
            // Console.WriteLine(ft.SecondMethod());
            // ft.ThirdMethod();
            
            
        }
    }
}