using System;
using static System.Math;


namespace ClassesTasks
{
    public class PlayingWithCubes3
    {
        public class Cube
        {
            private int side;

            public int Side
            {
                get => side;
                set
                {
                    side = Abs(value);
                    Volume = (int) Pow(side, 3);
                    Surface = side * side * 6;
                }
            }

            public int Volume { get; private set; }

            public int Surface { get; private set; }

            public Cube() : this(0) { } 

            public Cube(int num) { Side = num; }
        }
    }
}