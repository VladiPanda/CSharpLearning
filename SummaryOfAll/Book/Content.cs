using System;

namespace SummaryOfAll.Book
{
    public class Content
    {
        public static string _Content { get; set; }
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_Content);
        }
    }
}