namespace ICloneable
{
    // Глубокое копиирование (Deep copy)

    public class Point : System.ICloneable
    {
        public int x, y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Реализация метода интерфейса ICloneable.
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }
    }
}