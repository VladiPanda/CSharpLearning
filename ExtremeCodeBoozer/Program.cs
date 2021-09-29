using System;

namespace ExtremeCodeBoozer
{
    class Boozer
    {
       
        public int BoozeAmount { get; private set; }

        public event EventHandler OilEnded;

        public Boozer()
        {
            BoozeAmount = 100;
        }

        public void Worker()
        {
            for (int i = BoozeAmount; i >= 0; i--)
            {
                if (BoozeAmount == 0)
                {
                    if (OilEnded != null)
                    {
                        OilEnded(this, new EventArgs());
                    }
                }

                BoozeAmount--;
            }
        }
        public static void OnOilEnded(object sender, EventArgs eventArgs)
        {
            if (sender is Gopnik)
            {
                Console.WriteLine("Сышь, семки есть?");
            }
            else if (sender is Boozer)
            {
                Console.WriteLine("Пора в магаз за добавкой");
            }
        }
    }

    class Gopnik
    {
        
        public int SemkiAmount { get; private set; }

        public event EventHandler OilEnded;

        public Gopnik()
        {
            SemkiAmount = 250;
        }

        public void LetsGoShelkat()
        {
           // Worker();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            var boozer = new Boozer();
            boozer.OilEnded += Boozer.OnOilEnded;

            var gopnik = new Gopnik();
            //gopnik.OilEnded += Gopnik.OnOilEnded;
            
            gopnik.LetsGoShelkat();
            //Boozer.LetsGoDrink();
        }
    }
}