﻿using System;

// Ковариантность обобщений.

namespace Generics_04
{
    public abstract class Shape { }
    public class Circle : Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            // ковариантность обобщения - это апкаст параметра типа
            IContainer<Shape> container = new Container<Shape>(circle);

            Console.WriteLine(container.Figure.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}