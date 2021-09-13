using System;
using System.Drawing;

namespace SummaryOfAll.Book
{
    public class Title
    {
        public static string _Title { get; set; }

        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(_Title);
        }
    }
}