using System;

namespace PhoneBook
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            Book book = new Book(size);

            while (true)
            {
                Console.WriteLine("Select Option:");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Delete Person");
                Console.WriteLine("3. Expand Limit");
                Console.WriteLine("4. Print All");
                Console.WriteLine("5. Search Person");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter rating: ");
                        int rating = int.Parse(Console.ReadLine());

                        AddressEntry entry = new AddressEntry(name, address, rating);
                        book.AddEntry(entry);

                        break;
                    case 2:
                        Console.Write("Input person ID which you want to delete: ");

                        int deleteId = int.Parse(Console.ReadLine());
                        book.DeleteEntry(deleteId);

                        break;
                    case 3:
                        Console.Write("Input amount to expand limit with: ");
                        int expandNum = int.Parse(Console.ReadLine());

                        book.ExpandLimit(expandNum);

                        break;
                    case 4:
                        book.DisplayEntries();

                        break;
                    case 5:
                        Console.WriteLine("Search Menu:");
                        Console.WriteLine("1. Search By ID");
                        Console.WriteLine("2. Search By Name");

                        int searchOption = int.Parse(Console.ReadLine());

                        switch (searchOption)
                        {
                            case 1:
                                Console.Write("Input person ID which you want to search: ");
                                int searchId = int.Parse(Console.ReadLine());
                                book.SearchById(searchId);
                                break;
                            case 2:
                                Console.Write("Input person name which you want to search: ");
                                string searchName = Console.ReadLine();
                                book.SearchByName(searchName);
                                break;
                            default:
                                Console.WriteLine("Invalid Option!");
                                break;
                        }

                        break;
                    case 6:
                        Console.WriteLine("Cya!");

                        return;
                    default:
                        Console.WriteLine("Invalid Option!");

                        break;
                }
                Console.WriteLine();
            }
        }
    }
}