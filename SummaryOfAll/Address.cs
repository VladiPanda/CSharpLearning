using System;
using System.Dynamic;

namespace SummaryOfAll
{
    public class Address
    {
        private int Index { get; set; }
        private string Country { get; set; }
        private string Street { get; set; }
        private int House { get; set; }
        private int Apartment { get; set; }

        public Address(int index, string country, string street, int house, int apartment)
        {
            Index = index;
            Country = country;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Адрес:\nИндекс: {Index}\nСтрана: {Country}\nУлица: {Street}\nДом: {House}\nКвартира: {Apartment}");
        }
    }
}