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
        }
    }
}