using System;
using static Abstraction.Birds;
using static Abstraction.Virtual;

namespace Abstraction
{
    abstract class BaseClass
    {
         public abstract void Method(); // => Console.WriteLine("BaseClass.Method");

        public abstract string Property { get; /*{ return "BaseClass.Property"; }*/ }
        
        public abstract string this[int index] { get; /*{ return "BaseClass.Indexer"; }*/ }
    }

    class DerivedClass : BaseClass
    {
        public override void Method() => Console.WriteLine("DerivedClass.Method");

        public override string Property => "DerivedClass.Property";

        public override string this[int index] => "DerivedClass.Indexer";
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedInstance = new DerivedClass();
            derivedInstance.Method();
            Console.WriteLine(derivedInstance.Property);
            Console.WriteLine(derivedInstance[0]);
            
            Type type = Type.GetType("AnimalWorld.Dog");
            Animal animal = Activator.CreateInstance(type) as Animal;
            animal?.Run(new Dog());
            
            MyClass.Instance.MethodFromNestedClass();
            MyClass.StaticNestedClass.MethodFromNestedStaticClass();

            //MyClass instance = new MyClass();
            MyClass.DisplayVariable();
            MyClass.Property = "Привет мир!";
            MyClass.DisplayVariable();
            
            Taksa taxa = new StandardTaksa();
            taxa.ShowSize();

            //Taksa taxa = new Taksa();
            //taxa.ShowSize();
            //taxa = new StandardTaksa();
            //taxa.ShowSize();

            //{
            //    void q(Taksa taksa) => taksa.ShowSize();
            //    Taksa x = new Taksa();
            //    q(x);
            //    StandardTaksa y = new StandardTaksa();
            //    q(y);
            //}
            //Console.WriteLine(new string('-', 15));
            //{
            //    Taksa x = new Taksa();
            //    x.ShowSize();
            //    Taksa y = new StandardTaksa();
            //    y.ShowSize();
            //}

            //Taksa x = new Taksa();
            //x.ShowSize();
            //StandardTaksa y = new StandardTaksa();
            //y.ShowSize();
            
            Bird[] birds = { new Canary(), new Ostrich() };

            for (int i = 0; i < birds.Length; i++)
                birds[i].Fly(birds[i].ToString());

            //Bird bird = new Canary();
            //bird.Fly(nameof(Canary));
            //bird = new Ostrich();
            //bird.Fly(nameof(Ostrich));

            //Canary canary = new();
            //canary.Fly(nameof(Canary));
            //Ostrich ostrich = new();
            //ostrich.Fly(nameof(Ostrich));
        }
    }
}