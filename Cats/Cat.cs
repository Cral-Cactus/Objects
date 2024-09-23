using System;

namespace Cats
{
    public class Cat
    {
        private string name;
        private int age;
        private CatBreed breed;
        private string color;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public CatBreed Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Cat(string name, int age, CatBreed breed, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"{this.name} is {this.age} years old {this.color} {this.breed} cat.";
        }
    }

    public enum CatBreed
    {
        Street,
        Siamese,
        Persian,
        MaineCoon
    }
}