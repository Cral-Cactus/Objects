using System;

namespace Triangle
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] parts = input.Split(' ');
            double a, h;

            if (!double.TryParse(parts[0], out a))
            {
                Console.WriteLine("Invalid input for a. Please enter a valid number.");
                return;
            }

            if (!double.TryParse(parts[1], out h))
            {
                Console.WriteLine("Invalid input for h. Please enter a valid number.");
                return;
            }

            Triangle t = new Triangle(a, h);

            Console.WriteLine($"Triangle with side {t.A} and height to it {t.H}");
            Console.WriteLine($"Triangle face: {t.GetArea()}");

            t.PrintTriangleInfo();
        }
    }
}