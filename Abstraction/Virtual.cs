using System;

namespace Abstraction
{
    public class Virtual
    {
        // Существуют таксы 3-х разных размеров:
        // 1. кроличья    — высота в холке 10-15 см
        // 2. карликовая  — высота в холке 14-21 см
        // 3. стандартная — высота в холке 20-27 см
        public class Taksa // Такса по-английски - dachshund.
        {
            public void ShowSize() => Console.WriteLine("Taksa 10-27 см");
        }
        public class StandardTaksa : Taksa
        {
            public void ShowSize() => Console.WriteLine("Standard Taksa 20-27 см");
        }
    }
}