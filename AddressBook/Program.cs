namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            person obj=new person();
            Console.WriteLine("Welcome to Address Book Program ");
            //person.CreateContacts();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter number: \n 1. Create new Contact \n 2. Edit Contact \n 3. Delete Contact \n 4.Add Multiple Contact \n 5.Add AddressBookNames \n 6.Display \n 7.DisplayAddressBook \n 8.Check DuplicateContact \n 9.SearchPersonByCityorState ");
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
                    default:
                        Console.WriteLine("Enter the Valid Number");
                        flag = false;
                        break;
                }
            }
        }
    }
}