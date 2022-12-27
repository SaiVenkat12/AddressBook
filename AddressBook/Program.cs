namespace AddressBook
{
    public class Program
    {
        public static List<Contacts> contacts = new List<Contacts>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            Console.WriteLine("New Contact");
            //AddressBook.person.CreateContacts();
            //AddressBook.person.EditContact();
            //AddressBook.person.DeleteContact();
            AddressBook.person.Display();
            AddressBook.person.AddContact();

        }
    }
}