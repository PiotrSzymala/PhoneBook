using System;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            Console.WriteLine("--- Phone Book ---");
            Console.WriteLine("Welcome to your PB");

            Console.WriteLine();

            string userInput;
            string name;
            string number;

            do
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add contact.");
                Console.WriteLine("2. Search contact by its number.");
                Console.WriteLine("3. Display all contacts.");
                Console.WriteLine("4. Search contact by phrase.");
                Console.WriteLine("5. Remove contact.");
                Console.WriteLine("x. Exit phone book.");

                Console.WriteLine();

                userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("Give contact name:");
                        name = Console.ReadLine();
                        
                        do
                        {
                            if (name.Length == 0)
                            {
                                Console.WriteLine("The name cannot be empty!");
                                name = Console.ReadLine();

                            }
                        } while (name.Length == 0);


                        Console.WriteLine("Give contact number:");
                        number = Console.ReadLine();
                        do
                        {
                            if (number.Length != 9)
                            {
                                Console.WriteLine("The length of the number is inappropriate!");
                                number = Console.ReadLine();

                            }
                        } while (number.Length != 9);


                        Contact contact = new Contact(name, number);

                        phoneBook.AddContact(contact);
                        Console.WriteLine("New contact added to your phone book!");

                        break;

                    case "2":

                        if (phoneBook.IslistEmpty())
                            Console.WriteLine("The phone book is empty!");
                        else
                        {
                            Console.WriteLine("Give number of contact's you want to find:");
                            phoneBook.SearchContactByNumber(Console.ReadLine());
                        }
                        break;

                    case "3":

                        if (phoneBook.IslistEmpty())
                            Console.WriteLine("The phone book is empty!");
                        else
                            phoneBook.DisplayAllContacts();
                        break;

                    case "4":

                        if (phoneBook.IslistEmpty())
                            Console.WriteLine("The phone book is empty!");
                        else
                        {
                            Console.WriteLine("Give phrase you want to search contact by:");
                            phoneBook.SearchContactByPhrase(Console.ReadLine());
                        }
                        break;

                    case "5":

                        if (phoneBook.IslistEmpty())
                            Console.WriteLine("The phone book is empty!");
                        else
                            phoneBook.RemoveContact();
                        break;

                    case "x":

                        Console.WriteLine("Goodbye!");

                        break;

                    default:

                        Console.WriteLine("Invalid choice!");

                        break;
                }
                Console.ReadKey();

                Console.Clear();

            } while (userInput != "x");
        }
    }
}
