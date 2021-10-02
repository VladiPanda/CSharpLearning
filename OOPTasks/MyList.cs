using System.Text;

namespace OOPTasks
{
    public class MyList<T> : IMyList<T>
    {
        private T[] array; // закрытый массив элементов типа Т

        public MyList()
        {
            array = new T[0]; // в конструкторе создаем массив с 0 элементов
        }
        public void Add(T a) 
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;
            array = tempArray;

        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }
        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((object) array[i] == (object) item)
                {
                    return true;
                }
            }

            return false;

        }

        
        public override string ToString()
        {
           // string text = null;
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                // text += array[i] + " ";
                newString.Append(array[i]); // ?
            }

            return "Размер массива: " + array.Length + "Элементы массива: " + newString;
        }
    }
}