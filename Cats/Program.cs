using System;
using System.Collections.Generic;

namespace Cats
{
    internal class Program
    {
        static void Main()
        {
            List<Cat> cats = new List<Cat>();
            bool active = true;

            while (active)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: add cat");
                Console.WriteLine("2: print all cats");
                Console.WriteLine("3: print specific cat");
                Console.WriteLine("4: exit");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddCat(cats);
                        break;

                    case "2":
                        PrintAllCats(cats);
                        break;

                    case "3":
                        PrintSpecificCat(cats);
                        break;

                    case "4":
                        active = false;
                        Console.WriteLine("bye");
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }

        static void AddCat(List<Cat> cats)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("breed (0: Street, 1: Siamese, 2: Persian, 3: MaineCoon): ");
            int breedChoice = int.Parse(Console.ReadLine());
            CatBreed breed = (CatBreed)breedChoice;

            Console.Write("color: ");
            string color = Console.ReadLine();

            Cat newCat = new Cat(name, age, breed, color);
            cats.Add(newCat);

            Console.WriteLine("the cat was added!");
        }

        static void PrintAllCats(List<Cat> cats)
        {
            if (cats.Count > 0)
            {
                Console.WriteLine("all cats:");
                foreach (Cat cat in cats)
                {
                    Console.WriteLine(cat.ToString());
                }
            }
            else
            {
                Console.WriteLine("no cats");
            }
        }

        static void PrintSpecificCat(List<Cat> cats)
        {
            if (cats.Count > 0)
            {
                Console.WriteLine($"cat id (1 to {cats.Count}):");
                int catIndex = int.Parse(Console.ReadLine());

                if (catIndex > 0 && catIndex <= cats.Count)
                {
                    Console.WriteLine(cats[catIndex - 1].ToString());
                }
                else
                {
                    Console.WriteLine("wrong id");
                }
            }
            else
            {
                Console.WriteLine("no cats");
            }
        }
    }
}