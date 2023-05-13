using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();

                string model = carData[0];

                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);

                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];

                double tire1Pressure = double.Parse(carData[5]);
                int tire1Age = int.Parse(carData[6]);

                double tire2Pressure = double.Parse(carData[7]);
                int tire2Age = int.Parse(carData[8]);

                double tire3Pressure = double.Parse(carData[9]);
                int tire3Age = int.Parse(carData[10]);

                double tire4Pressure = double.Parse(carData[11]);
                int tire4Age = int.Parse(carData[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flamable")
            {
                foreach (Car car in cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}