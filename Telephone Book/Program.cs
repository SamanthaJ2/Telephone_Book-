using System.Net.Security;
using Telephone_Book;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from the PhoneBook!");
        Console.WriteLine("Select Operation");
        Console.WriteLine("1 Add Contact");
        Console.WriteLine("2 Display contact by number");
        Console.WriteLine("3 View all contacts");
        Console.WriteLine("4 Search for contacts for given name");
        Console.WriteLine("Press 'Q' to quit");
        var userInput = Console.ReadLine();

        var phoneBook = new PhoneBook();
        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Contact name");
                    var name = Console.ReadLine();
                    Console.WriteLine("Contact number");
                    var number = Console.ReadLine();

                    var newContact = new Contact(name, number);
                    phoneBook.AddContact(newContact);

                    break;
                case "2":
                    Console.WriteLine("Contact number to search");
                    var searchNumber = Console.ReadLine();
                    phoneBook.DisplayContact(searchNumber);


                    break;
                case "3":
                    phoneBook.DisplayAllContacts();
                    break;
                case "4":
                    
                    break;
                case "Q":
                    return;
                default:
                    Console.WriteLine("Select valid choice");
                    break;

            }

            Console.WriteLine("Select valid choice");
            userInput = Console.ReadLine();
        }
    }
}