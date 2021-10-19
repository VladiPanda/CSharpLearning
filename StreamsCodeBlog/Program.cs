using System;
using System.IO;
using System.Text;

namespace StreamsCodeBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.Write("Hello, world");
                sw.WriteLine("Hello, user");
            }

            using (var sr = new StreamReader("test.txt"))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}