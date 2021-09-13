using System;


namespace SummaryOfAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class #1
            Address address = new Address(3223322, "Russia", "Jopkina", 61, 59);
            address.ShowAddress();
            
            // Class #2
            Rectangle calculate = new Rectangle(12, 34);
            Console.WriteLine($"Площадь: {calculate.AreaCalculator()}\nПериметр: {calculate.PerimeterCalculator()}");
            
            // Class #3
            Book.Book Avalon = new Book.Book("Avalon", "John Kus'", "A long time ago hue moe");
            Avalon.ShowInfo();
            
            // indexers #1
            Indexers myIndexer = new Indexers();

            myIndexer[0] = "1";
            myIndexer[1] = "2";
            myIndexer[2] = "3";
            myIndexer[3] = "4";
            myIndexer[4] = "5";

            Console.WriteLine(myIndexer[0]);
            Console.WriteLine(myIndexer[1]);
            Console.WriteLine(myIndexer[2]);
            Console.WriteLine(myIndexer[3]);
            Console.WriteLine(myIndexer[4]);
            
            // indexers #2
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            
            // indexers #3
            IndexersDerived instance = new IndexersDerived();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }
        }
    }
}