using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class person
    {
        public static List<Contacts> Person = new List<Contacts>();
        Dictionary<string, List<Contacts>> addressbook = new Dictionary<string, List<Contacts>>();
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter First Name: ");
            contacts.fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contacts.lname = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contacts.address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter Zipcode: ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter E-mail: ");
            contacts.Email = Console.ReadLine();
            Person.Add(contacts);
        }
        public static void EditContact()
        {
            Console.WriteLine("Enter the First Name to check if the name exists or not: ");
            string cname = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.fname == cname)
                    {
                        Console.WriteLine("To Edit Contacts Enter:\n 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.ZipCode\n 7.PhoneNumber\n 8.EMail\n 9.NoChange");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string FName = Console.ReadLine();
                                data.fname = FName;
                                break;

                            case 2:
                                string LName = Console.ReadLine();
                                data.lname = LName;
                                break;

                            case 3:
                                string Address = Console.ReadLine();
                                data.address = Address;
                                break;

                            case 4:
                                string City = Console.ReadLine();
                                data.city = City;
                                break;

                            case 5:
                                string State = Console.ReadLine();
                                data.state = State;
                                break;

                            case 6:
                                int ZipCode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = ZipCode;
                                break;

                            case 7:
                                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.phonenumber = PhoneNumber;
                                break;

                            case 8:
                                string EMail = Console.ReadLine();
                                data.Email = EMail;
                                break;

                            case 9:
                                Console.WriteLine("No Changes Made.");
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesn't match or exists in Address Book");
                    }
                }
            }
        }
        public static void DeleteContact()
        {
            Contacts contact = new Contacts();

            Console.WriteLine("Enter the First Name of the person to be delete the Contact: ");
            string dname = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.fname == dname)
                    {
                        Console.WriteLine();
                        Person.Remove(contact);
                        Console.WriteLine("Contact is deleted");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Name doesn't match or exists in Address Book");
                    }
                }
            }
        }
        public static void Display()
        {
            foreach (var data in Person)
            {
                Console.WriteLine("Contact Details");
                Console.WriteLine("1.Name: " + data.fname + " " + data.lname + "\n 2.Address: " + data.address + "\n 3.City: " + data.city + "\n 4.State: " + data.state + "\n 5.Zipcode: " + data.zipcode + " 6.EMAIL:  " + data.Email + "\n 7.PhoneNumber: " + data.phonenumber);
            }
        }
        public static void AddMultipleContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Number of contacts to create:");
            int Count = Convert.ToInt32(Console.ReadLine());
            while (Count > 0)
            {
                CreateContacts();
                Console.WriteLine("Contact Created");
                Count--;
            }
        }
        public void AddressBookContacts()
        {
            Console.WriteLine("Enter the Address Book Name: ");
            string AddressBookName = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int A = int.Parse(Console.ReadLine());
            while (A > 0)
            {
                A--;
                CreateContacts();
                Console.WriteLine("New Contact Created");
            }
            addressbook.Add(AddressBookName, Person.ToList());
        }
        public void DisplayAddressBook()
        {
            foreach (var pair in addressbook.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contacts AdBook in addressbook[pair])
                {
                    Console.WriteLine("First Name: " + AdBook.fname);
                    Console.WriteLine("Last Name: " + AdBook.lname);
                    Console.WriteLine("Phone Number: " + AdBook.phonenumber);
                    Console.WriteLine("City : " + AdBook.city);
                    Console.WriteLine("Zip Code : " + AdBook.zipcode);
                    Console.WriteLine("Email: " + AdBook.Email);
                }
            }
        }
        public void DuplicateContact()
        {
            Console.WriteLine("enter the First Name to check for Duplicate Contact: ");
            string Name = Console.ReadLine();
            bool check = Person.Any(check => check.fname == Name);
            if (check)
            {
                Console.WriteLine("contact Exists");
            }
            else
            {
                Console.WriteLine("New Contact Created");
                AddressBookContacts();
            }
        }
        public void SearchPersonByCityorState()
        {
            Console.WriteLine("enter the city to search: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("enter the State to search: ");
            string City = Console.ReadLine();
            Console.WriteLine("The Contacts in the State {0} or City {1} are ", Fname, City);
            foreach (var pair in addressbook.Keys)
            {
                Console.WriteLine("Address Book Name: " + pair);
                foreach (var data in Person.FindAll(search => search.city == City && search.fname == Fname))
                {
                    Console.WriteLine("Name " + data.fname + " " + data.lname + "  Phone Number" + data.phonenumber);
                }
            }
        }
        public void ViewPersonByCityorState()
        {
            Console.WriteLine("enter the city to search: ");
            string City = Console.ReadLine();
            Console.WriteLine("enter the State to search: ");
            string State = Console.ReadLine();
            Console.WriteLine("The Contacts in the State {0} or City {1} are ", State, City);
            foreach (var pair in addressbook.Keys)
            {
                Console.WriteLine("Address Book Name: " + pair);
                foreach (var data in Person.FindAll(search => search.city == City || search.state == State))
                {
                    Console.WriteLine("Name " + data.fname + " " + data.lname + "  Phone Number" + data.phonenumber);
                }
            }
        }
    }
}