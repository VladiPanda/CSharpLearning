using System;

namespace SummaryOfAll.Book
{
    public class Book
    { 
        public Book(string title, string author, string content)
        {
            Title._Title = title;
            Author._Author = author;
            Content._Content = content;
        }

        public void ShowInfo()
        {
            Title.Show();
            Author.Show();
            Content.Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}