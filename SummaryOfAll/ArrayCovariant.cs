using System;

namespace SummaryOfAll
{
    public class ArrayCovariant
    {
        
    }

    public interface IAnimal
    {
        void Voice();
    }
    
    public struct Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Gav - gav");
        }
    }
}