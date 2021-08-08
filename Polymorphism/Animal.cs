using System;

namespace Polymorphism
{
    abstract public class Animal
    {
        protected abstract string Name { get; }
        public abstract void MakeSound();

        public void Run(Animal animal) =>
            Console.WriteLine($"The {animal.Name} is running.");
    }

    class Dog : Animal
    {
        protected /*new*/ override string Name => nameof(Dog);

        public /*new*/ override void MakeSound() =>
            Console.WriteLine("Woof-Woof");
    }

    class Cat : Animal
    {
        protected /*new*/ override string Name => nameof(Cat);

        public /*new*/ override void MakeSound() =>
            Console.WriteLine("Meow-Meow");
    }
}

