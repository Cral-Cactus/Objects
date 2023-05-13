using System;

namespace OverlappingRectangles
{
    internal class Program
    {
        static void Main()
        {
            string[] nm = Console.ReadLine().Split();

            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            Rectangle[] rectangles = new Rectangle[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string id = input[0];

                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);

                double topLeftX = double.Parse(input[3]);
                double topLeftY = double.Parse(input[4]);

                rectangles[i] = new Rectangle(id, width, height, topLeftX, topLeftY);
            }

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                string id1 = input[0];
                string id2 = input[1];

                Rectangle first = null;
                Rectangle second = null;

                foreach (Rectangle rectangle in rectangles)
                {
                    if (rectangle.Id == id1)
                    {
                        first = rectangle;
                    }

                    if (rectangle.Id == id2)
                    {
                        second = rectangle;
                    }

                    if (first != null && second != null)
                    {
                        break;
                    }
                }

                Console.WriteLine(first.Intersect(second).ToString().ToLower());
            }
        }
    }
}