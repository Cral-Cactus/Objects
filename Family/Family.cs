using System;
using System.Collections.Generic;

namespace Family
{
    internal class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void Print()
        {
            //members.Sort((p1, p2) => string.Compare(p1.name, p2.name)); // :)

            foreach (Person member in members)
            {
                Console.WriteLine($"{member.name} {member.age}");
            }
        }
    }
}