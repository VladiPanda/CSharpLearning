﻿using System.Reflection;

namespace OOPTasks
{    /* Используя Visual Studio, создайте проект по шаблону Console Application. 
        Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность 
        использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5). 
        Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод 
        добавления пар элементов, индексатор для получения значения элемента по указанному индексу и 
        свойство только для чтения для получения общего количества пар элементов.  */
    public class MyDictionary<Tkey, Tvalue>
    {
        private readonly Tkey[] Key;
        private readonly Tvalue[] Value;
        private readonly int lenght;

        public int Lenght
        {
            get { return lenght; }
        }

        public MyDictionary(int n)
        {
            Key = new Tkey[n];
            Value = new Tvalue[n];
            lenght = n;
        }

        public string this[int index]
        {
            get { return Key[index] + " - " + Value[index]; }
        }

        public void Add(int i, Tkey key, Tvalue value)
        {
            Key[i] = key;
            Value[i] = value;
        }
    }
}