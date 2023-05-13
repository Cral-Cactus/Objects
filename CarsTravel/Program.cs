using System;
using System.Collections.Generic;

namespace CarsTravel
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();

                string model = commandArgs[1];
                int distance = int.Parse(commandArgs[2]);

                Car car = cars.Find(c => c.Model == model);

                if (car == null)
                {
                    continue;
                }

                if (car.CanMove(distance) == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}