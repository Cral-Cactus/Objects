using System;

namespace CarsTravel
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private int distanceTraveled;

        public string Model {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public double FuelAmount {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }
        public double FuelConsumptionPerKm {
            get
            {
                return this.fuelConsumptionPerKm;
            }
            set
            {
                this.fuelConsumptionPerKm = value;
            }
        }
        public int DistanceTraveled {
            get
            {
                return this.distanceTraveled;
            }
            set
            {
                this.distanceTraveled = value;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.DistanceTraveled = 0;
        }

        public bool CanMove(int distance)
        {
            double fuelNeeded = distance * FuelConsumptionPerKm;

            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                DistanceTraveled += distance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
        }
    }
}