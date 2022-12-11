﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class person
    {
        public static List<Contacts> Person = new List<Contacts>();
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
                                string  EMail= Console.ReadLine();
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
                        Console.WriteLine("Name doesnot match or exists in Address Book");
                    }
                }
            }
        }
    }
}