using System;
namespace ClassesAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            DesertEagle pistol = new DesertEagle(3, "Pow!", 7);
            pistol.BurstShooting(20);
        }
    }
}