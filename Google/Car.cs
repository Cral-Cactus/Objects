﻿using System;

namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

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
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }
    }
}