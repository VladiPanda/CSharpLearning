using System;

/*
 * Наследование интерфейсов
 */
namespace Interfaces
{
    interface IWeapon
    {
        void Fire();
    }

    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    //interface IInterface : IWeapon { void Foo(); }
    // interface IMyInterface : IWeapon, IInterface { }
    class Gun : IWeapon // < - не наследование интерфейса, это реализация
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пыщ!");
        }
    }

    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пиу!");
        }
    }

    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Ших!");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Вшух!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IWeapon[] invertory = {new Gun(), new LaserGun(), new Knife()};

            foreach (var item in invertory)
            {
                player.Fire(item);
                Console.WriteLine();
            }
            
            player.Throw(new Knife());
        }
    }
}