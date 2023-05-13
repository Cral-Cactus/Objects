using System;
using System.Collections.Generic;

namespace Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Pokemon> pokemon;
        private List<Parent> parents;
        private List<Child> children;

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }
        public Car Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }
        public List<Pokemon> Pokemon
        {
            get
            {
                return this.pokemon;
            }
            set
            {
                this.pokemon = value;
            }
        }
        public List<Parent> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }
        public List<Child> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
            this.Pokemon = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public override string ToString()
        {
            string result = $"Person: {Name}\n";

            result += "Company:\n";

            if (Company != null) result += Company.ToString() + "\n";

            result += "Car:\n";

            if (Car != null) result += Car.ToString() + "\n";

            result += "Pokemon:\n";

            foreach (var pokemon in Pokemon) 
            {
                result += pokemon.ToString() + "\n";
                result += "Parents:\n";
            }

            foreach (var parent in Parents) 
            {
                result += parent.ToString() + "\n";
                result += "Children:\n";
            }

            foreach (var child in Children) {
                result += child.ToString() + "\n";
            }

            return result.Trim();
        }
    }
}