using System;
using static System.Math;


namespace ClassesTasks
{
    public class PlayingWithCubes3
    {
        public class Cube
        {
            private int side;
            public int Side {get { return side;} set { side = Abs(value); } }
            public int Volume { get => (int) Pow(Side, 3); private set{} }
            public int Surface { get => Side * Side * 6; private set{}}
            
            public Cube() { }
            public Cube(int num) { Side = num; }
        }
    }
}
