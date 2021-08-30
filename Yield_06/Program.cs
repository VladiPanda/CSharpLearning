using System;

namespace Yield_06
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