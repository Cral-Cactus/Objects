using System;

namespace OverlappingRectangles
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftX;
        private double topLeftY;

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public double TopLeftX
        {
            get
            {
                return this.topLeftX;
            }
            set
            {
                this.topLeftX = value;
            }
        }
        public double TopLeftY
        {
            get
            {
                return this.topLeftY;
            }
            set
            {
                this.topLeftY = value;
            }
        }

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        public bool Intersect(Rectangle other)
        {
            return this.TopLeftX + this.Width >= other.TopLeftX &&
                   this.TopLeftX <= other.TopLeftX + other.Width &&
                   this.TopLeftY >= other.TopLeftY - other.Height &&
                   this.TopLeftY - this.Height <= other.TopLeftY;
        }
    }
}