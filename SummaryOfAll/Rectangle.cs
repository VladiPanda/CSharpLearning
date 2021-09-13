namespace SummaryOfAll
{
    public class Rectangle
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }

        private double Area
        {
            get { return Side1 * Side2; }
        }

        private double Perimeter
        {
            get { return (Side1 + Side2) * 2; }
        }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double AreaCalculator()
        {
            return Area;
        }

        public double PerimeterCalculator()
        {
            return Perimeter;
        }
    }
}