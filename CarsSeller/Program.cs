using System;
using System.Collections.Generic;

namespace CarsSeller
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int power = int.Parse(input[1]);
                int? displacement = null;

                if (input.Length >= 3 && int.TryParse(input[2], out int result))
                {
                    displacement = result;
                }
                string efficiency = input.Length >= 4 ? input[3] : "n/a";

                Engine engine = new Engine(model, power, displacement, efficiency);

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                string engineModel = input[1];

                Engine engine = engines.Find(e => e.Model == engineModel);

                int? weight = null;

                if (input.Length >= 3 && int.TryParse(input[2], out int result))
                {
                    weight = result;
                }

                string color = input.Length >= 4 ? input[3] : "";

                Car car = new Car(model, engine, weight, color);

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}