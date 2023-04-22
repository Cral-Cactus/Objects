using DefiningPersonClass;
using System;

namespace Family
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
                family.AddMember(person);
            }
            Console.Clear();
            
            family.Print();
        }
    }
}