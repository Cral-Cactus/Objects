using System;
using DefiningPersonClass;
using System.Reflection;

namespace OldestFamilyMember
{
    internal class Program
    {
        static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}