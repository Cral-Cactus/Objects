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

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string CarPlate { get; set; }
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