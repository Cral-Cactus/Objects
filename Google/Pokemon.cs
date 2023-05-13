using System;

namespace Google
{
    public class Pokemon
    {
        private string name;
        private string type;

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
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Type}";
        }
    }
}