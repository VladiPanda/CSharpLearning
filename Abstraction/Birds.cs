using System;

namespace Abstraction
{
    public class Birds
    {
       public class Bird { public virtual void Fly(string name) => Console.WriteLine($"{name}: Fly"); }
       public class Canary : Bird { }
       public class Ostrich : Bird { public /*new*/ override void Fly(string name) => Console.WriteLine($"{name}: Not fly"); }
    }
}