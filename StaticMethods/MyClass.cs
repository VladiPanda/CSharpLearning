namespace StaticMethods
{
    public class MyClass
    {
        public MyClass()
        {
            counter++;
        }
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }

        }
        public int ObjectsCount
        {
            get { return counter; }
           
        }
        public static int GetCounter()
        {
            return counter;
        }
        public int GetObjectsCount()
        {
            return counter;
        }
    }
}