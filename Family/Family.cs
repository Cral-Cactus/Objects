using DefiningPersonClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Family
{
    public class Familys
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
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }

        public List<Person> GetSortedMembers()
        {
            return members.OrderBy(m => m.Name).ToList();
        }
    }
}