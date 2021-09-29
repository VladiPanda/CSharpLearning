using System;
using System.Collections.Generic;

namespace GenericsCodeBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product<int>("Apple", 100, 100);
            var pp = new Product<decimal>("Banana", 10.1m, 1100);

            var List = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(5, "Five");
        }
    }
}