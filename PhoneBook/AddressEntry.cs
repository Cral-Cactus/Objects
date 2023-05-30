using System;

namespace PhoneBook
{
    internal class AddressEntry
    {
        private static int nextId = 1;
        private static Random random = new Random();
        private string name;
        private string address;
        private string phoneNumber;
        private int rating;

        public int ID { get; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public int Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                this.rating = value;
            }
        }

        public AddressEntry(string name, string address, int rating)
        {
            ID = nextId++;
            this.Name = name;
            this.Address = address;
            this.Rating = rating;
            this.PhoneNumber = GeneratePhoneNumber();
        }

        private string GeneratePhoneNumber()
        {
            long number = random.Next(860000000, 900000000);
            return "0" + number.ToString();
        }
    }
}