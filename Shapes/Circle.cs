using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("radius must be > 0");
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Print()
        {
            Console.WriteLine($"circle radius: {Radius:F2}");
            Console.WriteLine($"area: {CalculateArea():F2}");
        }
    }
}
