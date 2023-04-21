using DefiningPersonClass;
using System;
using System.Collections.Generic;

namespace Family
{
    public class Family
    {
        public List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void Print()
        {
            foreach (Person member in members)
            {
                Console.WriteLine($"{member.Name} {member.Age}");
            }
        }
    }
}