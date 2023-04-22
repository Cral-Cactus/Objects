using DefiningPersonClass;
using Family;
using System;
using System.Collections.Generic;

namespace Statisctics
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Familys family = new Familys();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                if(person.Age >= 30) family.AddMember(person);
            }
            Console.Clear();

            List<Person> sortedMembers = family.GetSortedMembers();

            foreach (Person member in sortedMembers)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}