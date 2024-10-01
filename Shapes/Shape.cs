using System;

namespace Shapes
{
    public abstract class Shape : IPrint
    {
        public abstract double CalculateArea();

        public abstract void Print();
    }
}