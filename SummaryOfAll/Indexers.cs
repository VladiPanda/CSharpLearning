using System;

namespace SummaryOfAll
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";
            key[1] = "ручка"; value[1] = "pen";
            key[2] = "солнце"; value[2] = "sun";
            key[3] = "яблоко"; value[3] = "apple";
            key[4] = "стол"; value[4] = "table";
        }

        public string this[string index] // индексатор
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index] // перегрузка индексатора
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
    public class Indexers
    {
        private string[] array = new string[5];
        
        // индексатор
        // public int this[int index]
        // {
        //     get
        //     {
        //         return array[index];
        //     }
        //     set
        //     {
        //         array[index] = value;
        //     }
        // }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива.";
                
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }

    public class BaseClass
    {
        private string[] baseArray = null;

        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Ноль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }
        
        // Виртуальный индексатор.
        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }

   
}