using System;
using System.Collections.Generic;

namespace Google
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();

                string name = tokens[0];

                if (!people.ContainsKey(name))
                {
                    people[name] = new Person(name);
                }

                string command = tokens[1];

                switch (command)
                {
                    case "company":
                        string companyName = tokens[2];
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);

                        Company company = new Company
                        {
                            Name = companyName,
                            Department = department,
                            Salary = salary
                        };

                        people[name].Company = company;

                        break;
                    case "car":
                        string model = tokens[2];
                        int speed = int.Parse(tokens[3]);

                        Car car = new Car
                        {
                            Model = model,
                            Speed = speed
                        };

                        people[name].Car = car;

                        break;
                    case "pokemon":
                        string pokemonName = tokens[2];
                        string type = tokens[3];

                        Pokemon pokemon = new Pokemon
                        {
                            Name = pokemonName,
                            Type = type
                        };

                        people[name].Pokemon.Add(pokemon);

                        break;
                    case "parents":
                        string parentName = tokens[2];
                        string parentBirthday = tokens[3];

                        Parent parent = new Parent
                        {
                            Name = parentName,
                            Birthday = parentBirthday
                        };

                        people[name].Parents.Add(parent);

                        break;
                    case "children":
                        string childName = tokens[2];
                        string childBirthday = tokens[3];

                        Child child = new Child
                        {
                            Name = childName,
                            Birthday = childBirthday
                        };

                        people[name].Children.Add(child);

                        break;
                }

                input = Console.ReadLine();
            }

            string personName = Console.ReadLine();

            Console.WriteLine(people[personName]);
        }
    }
}