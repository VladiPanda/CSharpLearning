using System;

namespace PreprocessorDirectives_01
{
    class Program
    {
        static void Main()
        {
            #region MyRegion

            Console.WriteLine("Hello...");

            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}