using System;

namespace Yield_05
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);

            // Delay. 
            Console.ReadKey();
        }
    }
}