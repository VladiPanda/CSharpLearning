using System;

namespace ExplicitImplementationOfInterfaces
{
    /*
     *  Явная реализация интерфейсов
     */
    
    // Может ли класс реализовать два интерфейса, у которых обьявлено два одинаковых метода? (вопрос с собеса)
    interface IFirstInterface
    {
    void Action();
    }

    interface ISecondInterface
    {
        void Action();
    }
    
    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }

    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyOtherClass IFirstInterface.Action...");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("MyOtherClass ISecondInterface.Action...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // MyClass myClass = new MyClass();
            // Foo(myClass);
            // Bar(myClass);

            // Console.WriteLine();

            MyOtherClass myOtherClass = new MyOtherClass();
            // Foo(myOtherClass);
            // Bar(myOtherClass);

            Console.WriteLine();
            // IFirstInterface firstInterface = myOtherClass;
            // firstInterface.Action();
            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterface)myOtherClass).Action();
        }

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}