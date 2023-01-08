namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            person obj=new person();
            Console.WriteLine("Welcome to Address Book Program ");
            person.CreateContacts();
            Console.WriteLine("Enter number: \n 1. Create new Contact and Display \n 2. Edit Contact and display  \n 3. Delete Contact \n 4.Add Multiple Contacts and display \n 5.Add AddressBookNames and display \n 6.Display ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    person.CreateContacts();
                    person.Display();
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
                    person.Display();
                    break;
                case 5:
                    obj.AddressBookContacts();
                    obj.DisplayAddressBook();
                    break;
                case 6:
                    person.Display();
                    break;
            }
            obj.DisplayAddressBook();
            obj.DuplicateContact();

        }
    }
}