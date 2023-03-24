using System;
using System.Collections.Generic;

namespace Statisctics
{
    internal class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            if (person.age >= 30)
            {
                members.Add(person);
            }
        }

        public void Print()
        {
            members.Sort((p1, p2) => string.Compare(p1.name, p2.name)); // :)

            foreach (Person member in members)
            {
                Console.WriteLine($"{member.name} {member.age}");
            }
        }
    }
}