using System;
using System.Net.Sockets;

namespace ClassesTasks
{
    public class God
    {
        public static Human[] Create()
        {
            Man Adam = new Man();
            Woman Eve = new Woman();
            return new Human[] {Adam, Eve};
        }
    }
    public class Human
    {
    }
    class Man : Human
    {
    }
    class Woman : Human
    {
    }
}