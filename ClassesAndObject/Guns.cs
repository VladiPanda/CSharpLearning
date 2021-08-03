using System;

namespace ClassesAndObject
{
    public class Guns
    {
        
        public int BulletsInMagazine { get; set; }
        
        private bool _isLoaded;
        public string Noise { get; set; }
        
        public void GetAWeapon()
        {
            Console.WriteLine("Weapon taken from the holster");
        }

        public void RemoveWeapon()
        {
            Console.WriteLine("Weapon removed to the holster");
        }

        private void Reload()
        {
            if (BulletsInMagazine == 0)
            {
                Console.WriteLine("Loading...");
                _isLoaded = true;
                Console.WriteLine("Magazine is loaded!");
            }
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Magazine is empty!");
                Reload();
            }
            Console.WriteLine(Noise);
            BulletsInMagazine -= 1;
            
        }

        public void BurstShooting(int bullets)
        {
            BulletsInMagazine = bullets;
            
            for (int i = 0; BulletsInMagazine > 0 ; BulletsInMagazine--)
            {
                Console.WriteLine(Noise);
                if (!_isLoaded)
                {
                    Console.WriteLine("Magazine is empty!");
                    Reload();
                }
                
                if (BulletsInMagazine == 0)
                {
                    _isLoaded = false;
                }
            }
        }
    }
}