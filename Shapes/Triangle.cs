using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public double BaseLength
        {
            get { return baseLength; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("base length must be > than 0");
                }
                baseLength = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height must be > than 0");
                }
                height = value;
            }
        }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override void Print()
        {
            Console.WriteLine($"triangle base length: {BaseLength:F2}, height: {Height:F2}");
            Console.WriteLine($"area: {CalculateArea():F2}");
        }
    }
}
