using System;

namespace Triangle
{
    public class Triangle
    {
        private double a;
        private double h;

        public double A
        {
            get 
            { 
                return a; 
            }
            set 
            { 
                a = value; 
            }
        }

        public double H
        {
            get 
            { 
                return h; 
            }
            set 
            { 
                h = value; 
            }
        }

        public Triangle(double a, double h)
        {
            this.A = a;
            this.H = h;
        }

        public double GetArea()
        {
            //return 0.5 * a * h;
            return a * h / 2;
        }

        public void PrintTriangleInfo()
        {
            Console.WriteLine($"SIDE = {this.A} and HEIGHT to IT = {this.H} with FACE = {GetArea()}");
        }
    }
}