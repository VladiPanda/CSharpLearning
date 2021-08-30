using System;
using System.Collections;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();
            
            // Используем foreach, для обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            
            // myCollection.Reset(); // Убрать комментарий для проверки.
            
            Console.Write(new string('-', 29) + "\n");
            
            // Используем foreach, для повторного обращения к каждому объекту Element внутри массива myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            
            // ---------------------------------------------------------------------------------------------------------
            // Так работает foreach.

            UserCollection myElementsCollection = new UserCollection();
            
            // foreach - приводит коллекцию к интерфейсному типу IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;
            
            // foreach - приводит коллекцию к интерфейсному типу вызывая метод - GetEnumerator()
            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед (с -1 на 0) и т.д.
            {
                Element element = enumerator.Current as Element;
                
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            
            enumerator.Reset();

            Console.ReadKey();
        }
    }
}