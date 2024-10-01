using System;

namespace CarsSeller
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

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
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public int? Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
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

        public Car(string model, Engine engine, int? weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            string weightStr = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string displacementStr = this.Engine.Displacement.HasValue ? this.Engine.Displacement.ToString() : "n/a";
            string colorStr = !string.IsNullOrEmpty(this.Color) ? this.Color : "n/a";

            return $"{this.Model}:\n" +
                $"{this.Engine.Model}:\n" +
                $"Power: {this.Engine.Power}\n" +
                $"Displacement: {displacementStr}\n" +
                $"Efficiency: {this.Engine.Efficiency}\n" +
                $"Weight: {weightStr}\n" +
                $"Color: {colorStr}!";
        }
    }
}