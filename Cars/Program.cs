using System;
using System.Collections.Generic;

namespace Cars
{
    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            string input;

            Console.WriteLine("Enter car details (brand, model, color, license plate, year) separated by commas:\nend=END\n");

            do
            {
                input = Console.ReadLine();

                if (input != "end")
                {
                    string[] carDetails = input.Split(',');

                    if (carDetails.Length == 5)
                    {
                        string brand = carDetails[0].Trim();
                        string model = carDetails[1].Trim();
                        string color = carDetails[2].Trim();
                        string licensePlate = carDetails[3].Trim();
                        int year;

                        if (int.TryParse(carDetails[4].Trim(), out year))
                        {
                            Car car = new Car(brand, model, color, licensePlate, year);
                            cars.Add(car);

                            Console.WriteLine("Car added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid year. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please provide all car details.");
                    }
                }

            } while (input != "end");

            Console.WriteLine($"Total cars created: {Car.Count} / {cars.Count}");

            foreach (Car car in cars)
            {
                car.Present();
                car.Move();
                car.CheckEcological();
            }
        }
    }
}