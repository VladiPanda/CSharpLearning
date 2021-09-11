using System;

namespace RandomKatas
{
    /* The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in
       a huge line. Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.
       Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
       Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets 
       strictly in the order people queue?
       Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that 
       moment. Otherwise return NO. */
    public class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        { 
            var bill25 = 0;
            var bill50 = 0;
            var bill100 = 0;

            foreach (var customerMoney in peopleInLine)
            {
                if (customerMoney == 25)
                {
                    bill25++;
                }
                else if (customerMoney == 50)
                {
                    bill50++;
                    bill25--;
                }
                else if (customerMoney == 100)
                {
                    bill100++;
                    bill50--;
                    bill25--;
                }

                if (bill25 < 0 || bill50 < 0 || bill100 < 0)
                    return "NO";
            }

            return "YES";
        }
    }
}