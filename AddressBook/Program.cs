using System;
namespace AddressBook
{
    public class Program
    {
        public static List<Contacts> contacts = new List<Contacts>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            Console.WriteLine("New Contact");
            AddContact addContact = new AddContact();
            AddressBook.AddContact.CreateContacts();
        }
    }
}