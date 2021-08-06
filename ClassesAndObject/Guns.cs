using System;

namespace ClassesAndObject
{
    public class Guns
    {
        public int MagazineSize { get; set; }
        public int CurrentBulletsCount { get; set; }
        public string Noise { get; set; }

        public Guns(int currentBullets, string noise, int magazineSize)
        {
            CurrentBulletsCount = currentBullets;
            MagazineSize = magazineSize;
            Noise = noise;
        }
        
        private bool IsLoaded()
        {
            return CurrentBulletsCount > 0;
        }
        
        
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
            if (CurrentBulletsCount == 0)
            {
                Console.WriteLine("Loading...");
                CurrentBulletsCount = MagazineSize;
                Console.WriteLine("Magazine is loaded!");
            }
        }

        public void Shoot()
        {
            if (!IsLoaded())
            {
                Console.WriteLine("Magazine is empty!");
                Reload();
            }
            Console.WriteLine(Noise);
            CurrentBulletsCount -= 1;
            
        }

        public void BurstShooting(int bullets)
        {
            
            for (int i = 0; i <= bullets ; i++)
            {
                Shoot();
            }
        }
    }
}