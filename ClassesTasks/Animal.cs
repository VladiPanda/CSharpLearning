namespace ClassesTasks
{
    public class Animal
    {
        public int Age;
        public int Legs;
        public string Name;
        public string Species;
        public string Status;

        public Animal(string name, int age, int legs, string species, string status)
        {
            this.Name = name;
            this.Age = age;
            this.Legs = legs;
            this.Species = species;
            this.Status = status;
        }

        public virtual string Introduce()
        {
            return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
        }

        public class Shark : Animal
        {
            public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
            {
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
            {
            }

            public override string Introduce() => base.Introduce() + "  Meow meow!";
        }

        public class Dog : Animal
        {
            public string _master;

            public Dog(string name, int age, string status, string master) : base(name, age, 4, "dog", status)
            {
                _master = master;
            }

            public string GreetMaster() => $"Hello {_master}";
        }
    }
}