using System;
using System.Collections.Generic;

namespace Shapes
{
    internal class Program
    {
        static void Main()
        {
            bool active = true;
            List<Shape> shapes = new List<Shape>();

            while (active)
            {
                Console.WriteLine("choose option: ");
                Console.WriteLine("1: create circle");
                Console.WriteLine("2: create rectangle");
                Console.WriteLine("3: create triangle");
                Console.WriteLine("4: print all");
                Console.WriteLine("5: exit");

                string input = Console.ReadLine();

                /*switch (input)
                {
                    case "1":
                        Console.WriteLine("circle radius:");
                        double radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(radius);
                        shapes.Add(circle);

                        break;

                    case "2":
                        Console.WriteLine("rectangle length:");
                        double length = double.Parse(Console.ReadLine());

                        Console.WriteLine("rectangle width:");
                        double width = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(length, width);
                        shapes.Add(rectangle);

                        break;

                    case "3":
                        Console.WriteLine("triangle base length:");
                        double triangleBase = double.Parse(Console.ReadLine());

                        Console.WriteLine("triangle height:");
                        double height = double.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle(triangleBase, height);
                        shapes.Add(triangle);

                        break;

                    case "4":
                        Console.WriteLine("shapes:");
                        foreach (Shape shape in shapes)
                        {
                            shape.Print();
                            Console.WriteLine();
                        }

                        break;

                    case "5":
                        active = false;

                        break;

                    default:
                        Console.WriteLine("invalid");

                        break;
                }*/

                active = input switch
                {
                    "1" => CreateCircle(shapes),
                    "2" => CreateRectangle(shapes),
                    "3" => CreateTriangle(shapes),
                    "4" => PrintAllShapes(shapes),
                    "5" => false,
                    _ => InvalidInput()
                };
            }
        }

        static bool CreateCircle(List<Shape> shapes)
        {
            Console.WriteLine("circle radius:");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            shapes.Add(circle);

            return true;
        }

        static bool CreateRectangle(List<Shape> shapes)
        {
            Console.WriteLine("rectangle length:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("rectangle width:");
            double width = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            shapes.Add(rectangle);

            return true;
        }

        static bool CreateTriangle(List<Shape> shapes)
        {
            Console.WriteLine("triangle base length:");
            double triangleBase = double.Parse(Console.ReadLine());

            Console.WriteLine("triangle height:");
            double height = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(triangleBase, height);
            shapes.Add(triangle);

            return true;
        }

        static bool PrintAllShapes(List<Shape> shapes)
        {
            Console.WriteLine("shapes:");
            foreach (Shape shape in shapes)
            {
                shape.Print();
                Console.WriteLine();
            }

            return true;
        }

        static bool InvalidInput()
        {
            Console.WriteLine("invalid");

            return true;
        }
    }
}
