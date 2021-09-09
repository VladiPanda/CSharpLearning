// Пространства имен.

// Директива using - импортирует пространство имен, избавляя от необходимости полной квалификации имен стереотипов.

using System;
using NamespaceA;

// Закомментировать.

namespace Namespaces_01
{
    class Program
    {
        static void Main()
        {
            // 1
            Console.WriteLine("Hello world");
            // 2
            MyClass my = new MyClass();
            // Полная квалификация имени класса, включает имя пространства имен, в котором находится класс.
            NamespaceA.MyClass my2 = new NamespaceA.MyClass();
        }
    }
}