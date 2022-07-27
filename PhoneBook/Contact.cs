
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    internal class Contact
    {
        public Contact(string name, string number)
        {
            this.name = name;
            this.number = number;

        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 3)
                    name = value;
            }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length == 9)
                    number = value;
            }
        }
    }
}
