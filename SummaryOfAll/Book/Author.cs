using System;

namespace SummaryOfAll.Book
{
    public class Author
    {
        public static string _Author { get; set; }
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(_Author);
        }
    }
}