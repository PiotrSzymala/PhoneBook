using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    internal class PhoneBook
    {
        public List<Contact> ListOfContacts { get; set; } = new List<Contact>();
        public bool IslistEmpty()
        {
            return ListOfContacts.Count == 0;
        }
        public void AddContact(Contact contact)
        {
            ListOfContacts.Add(contact);
        }
        public void SearchContactByNumber(string number)
        {
            var search = ListOfContacts.Where(x => x.Number == number).FirstOrDefault();
            Console.Clear();
            if (search != null)
                Console.WriteLine($"{search.Name} - {search.Number}");
            else
                Console.WriteLine("There is no such a number!");
        }
        public void DisplayAllContacts()
        {
            Console.Clear();
            DisplayLists(ListOfContacts);
        }
        public void SearchContactByPhrase(string searchPhrase)
        {
            var search = ListOfContacts.Where(x => x.Name.Contains(searchPhrase)).ToList();
            Console.Clear();
            DisplayLists(search);
        }
        public void DisplayLists(List<Contact> list)
        {
            foreach (Contact contact in list)
            {
                Console.WriteLine($"{contact.Name} - {contact.Number}");
            }
        }
        public void RemoveContact()
        {
            if (IslistEmpty())
            {
                Console.WriteLine("The phone book is empty!");
            }
            else
            {
                Console.WriteLine("Give contact's name you want to remove:");
                string name = Console.ReadLine();

                foreach (Contact contact in ListOfContacts)
                {
                    if (contact.Name == name)
                    {
                        ListOfContacts.Remove(contact);
                        Console.WriteLine("Contact removed!");
                        break;
                    }
                }
            }
        }
    }
}
