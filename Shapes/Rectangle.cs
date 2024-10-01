using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("length must be > than 0");
                }
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width must be > than 0");
                }
                width = value;
            }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Print()
        {
            Console.WriteLine($"rectangle length: {Length:F2}, width: {Width:F2}");
            Console.WriteLine($"area: {CalculateArea():F2}");
        }
    }
}
