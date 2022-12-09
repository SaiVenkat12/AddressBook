using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddContact
    {
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter first name: ");
            contacts.fname = Console.ReadLine();

            Console.WriteLine("Enter Second name ");
            contacts.lname = Console.ReadLine();

            Console.WriteLine("Address: ");
            contacts.address = Console.ReadLine();

            Console.WriteLine("City: ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("State: ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Zipcode: ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.phonenumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("email: ");
            contacts.Email = Console.ReadLine();

            Program.contacts.Add(contacts);


        }
    }
}

