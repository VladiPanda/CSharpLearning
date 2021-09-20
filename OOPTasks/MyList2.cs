namespace OOPTasks
{
    public class MyList2<T>
    {
        private readonly int lenght;
        private readonly T[] arr;
        
        public int Lenght
        {
            get { return lenght; }
        }

        public MyList2(int n)
        {
            arr = new T[n];
            lenght = arr.Length;
        }

        public T this[int i]
        {
            get { return arr[i]; }
        }

        public void Add(int i, T k)
        {
            arr[i] = k;
        }
    }
}