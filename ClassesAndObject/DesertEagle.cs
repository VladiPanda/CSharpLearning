using System;

namespace ClassesAndObject
{
    public class DesertEagle : Guns
    {
        public DesertEagle(int bullets, string noise)
        {
            BulletsInMagazine = bullets;
            Noise = noise;
            
        }
    }
}