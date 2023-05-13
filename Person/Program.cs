using System;
using System.Reflection;

namespace Person
{
    internal class Program
    {
        static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine(fields.Length);

            Person p1 = new Person { Name = "Pesho", Age = 20 };
            Person p2 = new Person { Name = "Gosho", Age = 18 };
            Person p3 = new Person { Name = "Stamat", Age = 43 };

            foreach (Person person in new Person[] { p1, p2, p3 })
            {
                Console.WriteLine($"{person.Name} ~ {person.Age}");
            }
        }
    }
}