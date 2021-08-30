using System;

namespace Yield_04
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
                Console.Write(element);

            // Delay. 
            Console.ReadKey();
        }
    }
}