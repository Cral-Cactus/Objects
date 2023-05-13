using System;

namespace Cars
{
    internal class Car
    {
        private string brand;
        private string model;
        private string color;
        private string carPlate;
        private int productionYear;
        private static int count;

        string eco;

        public string Brand 
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }
        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Color 
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public string CarPlate 
        {
            get
            {
                return this.carPlate;
            }
            set
            {
                this.carPlate = value;
            }
        }
        public int ProductionYear
        {
            get
            {
                return this.productionYear;
            }
            set
            {
                if (value > 2000)
                {
                    eco = "ECO";
                }
                else
                {
                    eco = "I'm NOT Eco CAR";
                }

                this.productionYear = value;
            }
        }
        public static int Count
        {
            get { return count; }
        }

        public Car(string brand, string model, string color, string carPlate, int productionYear)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.CarPlate = carPlate;
            this.ProductionYear = productionYear;
            count++;
        }

        public void Move()
        {
            Console.WriteLine($"{this.Brand} {this.Model}: Brym - brum - brum");
        }

        public void CheckEcological()
        {
            Console.WriteLine(eco);
        }

        public void Present()
        {
            Console.WriteLine($"Brand: {this.Brand} | Model: {this.Model} | Color: {this.Color} | Car Plate: {this.CarPlate} | Production Year: {this.ProductionYear}");
        }
    }
}