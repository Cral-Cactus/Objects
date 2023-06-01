using System;

namespace PhoneBook
{
    internal class Book
    {
        private AddressEntry[] entries;

        public Book(int size)
        {
            entries = new AddressEntry[size];
        }

        public void AddEntry(AddressEntry entry)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    entries[i] = entry;

                    Console.WriteLine($"{entry.Name} was successfully aded to the phone book.");

                    return;
                }
            }
            Console.WriteLine("Phone book is full. Entry cannot be added.");
        }

        public void DeleteEntry(int id)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] != null && entries[i].ID == id)
                {
                    entries[i] = null;
                    Console.WriteLine($"{id} person was deleted.");

                    for (int j = i; j < entries.Length - 1; j++)
                    {
                        entries[j] = entries[j + 1];
                    }

                    Array.Resize(ref entries, entries.Length - 1);

                    return;
                }
            }
            Console.WriteLine("Entry with the specified ID not found.");
        }

        public void ExpandLimit(int amount)
        {
            Array.Resize(ref entries, entries.Length + amount);

            Console.WriteLine($"Limit Expanded successfully to {entries.Length}.");
        }

        public void DisplayEntries()
        {
            Console.WriteLine("Phone Book:");
            Console.WriteLine("ID | Name | Address | Phone Number | Rating");

            Array.Sort(entries, (x, y) => x.Rating.CompareTo(y.Rating));

            Array.Reverse(entries);

            foreach (AddressEntry entry in entries)
            {
                if (entry != null)
                {
                    Console.WriteLine($"{entry.ID} | {entry.Name} | {entry.Address} | {entry.PhoneNumber} | {entry.Rating}");
                }
            }
        }

        public void DisplayEntry(AddressEntry entry)
        {
            Console.WriteLine("ID | Name | Address | Phone Number | Rating");

            if (entry != null)
            {
                Console.WriteLine($"{entry.ID} | {entry.Name} | {entry.PhoneNumber} | {entry.Address} | {entry.Rating}");
            }
        }

        public void SearchById(int id)
        {
            foreach (AddressEntry entry in entries)
            {
                if (entry != null && entry.ID == id)
                {
                    DisplayEntry(entry);
                    return;
                }
            }
            Console.WriteLine("Person with the specified ID not found.");
        }

        public void SearchByName(string name)
        {
            foreach (AddressEntry entry in entries)
            {
                if (entry != null && entry.Name.Equals(name))
                {
                    DisplayEntry(entry);
                    return;
                }
            }
            Console.WriteLine("Person with the specified name not found.");
        }
    }
}