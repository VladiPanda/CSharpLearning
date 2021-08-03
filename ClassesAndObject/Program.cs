using System;
namespace ClassesAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            DesertEagle pistol = new DesertEagle(0, "Pow!");
            pistol.GetAWeapon();
            pistol.Shoot();
            pistol.BurstShooting(7);
            pistol.RemoveWeapon();
        }
    }
}