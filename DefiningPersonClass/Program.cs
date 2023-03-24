using System;

namespace DefiningPersonClass
{
    internal class Program
    {
        static void Main()
        {
            Person person1 = new Person
            {

                Name = "Pesho",
                Age = 20
            };

            Person person2 = new Person
            {
                Name = "Gosho",
                Age = 18
            };

            Person person3 = new Person
            {
                Name = "Stamat",
                Age = 43,
            };
            
            Console.WriteLine($"{person1.Name} - {person1.Age}");
            Console.WriteLine($"{person2.Name} = {person2.Age}");
            Console.WriteLine($"{person3.Name} ~ {person3.Age}");
        }
    }
}