﻿namespace RandomKatas
{
    public class EvenOrOdd
    {
        /* Create a function that takes an integer as an argument and returns "Even" for even numbers
           or "Odd" for odd numbers. */
        
        public static string EvOrOd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}