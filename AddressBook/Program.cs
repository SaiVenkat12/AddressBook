using System;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            person obj=new person();
            Console.WriteLine("Welcome to Address Book Program ");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Number: \n 1. Create new Contact \n 2. Edit Contact \n 3. Delete Contact \n 4.Add Multiple Contact \n 5.Add AddressBookNames \n 6.Display \n 7.DisplayAddressBook \n 8.Check DuplicateContact \n 9.Search Person by City or State \n 10.View Person byCity or State \n11.Number of Contacts per City or State \n 12.Sort Contacts in the Address Book \n 13.Sort by City Name \n 14.Sort by Zipcode \n 15.Sort by State Name \n 16.Read And Write File");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        person.CreateContacts();
                        break;
                    case 2:
                        person.EditContact();
                        person.Display();
                        break;
                    case 3:
                        person.DeleteContact();
                        break;
                    case 4:
                        person.AddMultipleContacts();
                        break;
                    case 5:
                        obj.AddressBookContacts();
                        break;
                    case 6:
                        person.Display();
                        break;
                    case 7:
                        obj.DisplayAddressBook();
                        break;
                    case 8:
                        obj.DuplicateContact();
                        break;
                    case 9:
                        obj.SearchPersonByCityorState();
                        break;
                    case 10:
                        obj.ViewPersonByCityorState();
                        break;
                    case 11:
                        obj.CountContactsperCityorState();
                        break;
                    case 12:
                        obj.SortContactsByName();
                        break;
                    case 13:
                        obj.SortContactsByCityName();
                        break;
                    case 14:
                        obj.SortContactsByZipCode();
                        break;
                    case 15:
                        obj.SortContactsByState();
                        break;
                    case 16:
                        obj.ReadAndWriteFile();
                        break;
                    default:
                        Console.WriteLine("Enter the Valid Number");
                        flag = false;
                        break;
                }
            }
        }
    }
}