namespace OOPTasks
        {    /* Используя Visual Studio, создайте проект по шаблону Console Application. 
                Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
                Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 
                для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий 
                метод GetArray(). */
    public static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyList2<T> list)
        {
            var temp = new T[list.Lenght];
            for (int i = 0; i < list.Lenght; i++)
            {
                temp[i] = list[i];
            }

            return temp;
        }
    }
}