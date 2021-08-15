using System;
/*
 * Интерфейсы и полмиорфизм
 * Абстрактные и виртуальные классы
 * Вложенные классы и статические классы
 */
namespace ClassesRecup
{
    class Car
    {
        // метод private нельзя сделать virtual в этом нет смысла
        /*private*/ protected virtual void StartEngine() // компонент класса с модификатором private доступен только внутри класса
        {
            // С модификатором protected метод на уровне экземпляра класса доступен не будет, но 
            // наследуемом класса использовать его мы сможем
            Console.WriteLine("Engine Start!");
        }
        public virtual void Drive() // виртуальный метод
        {
            StartEngine();;
            Console.WriteLine("I am a car! Wroom wroom");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
           
            car.Drive();
        }
    }
    // ссылка у которой тип базового класса может хранить объекты классов наследников
    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Ron don don");
        }
        public override void Drive() // переопределенный метод
        {
            //StartEngine(); // в наследниках так же нельзя обращаться при модификаторе private
            StartEngine();
            Console.WriteLine("I'm driving realy fast!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            // Car car = new SportCar(); // наоборот нельзя
            person.Drive(new SportCar()); // Вызов объекта класса Car в момент вызова метода Drive класса Person

            Player player = new Player();
            Gun gun = new Gun();
            Bow bow = new Bow();
            // player.Fire(gun);
            // player.Fire(bow);

            Weapon[] invertory = {new Gun(), new Bow()};

            foreach (var item in invertory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine( );
            }

        }
    }
}