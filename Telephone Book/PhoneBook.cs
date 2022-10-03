using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Book
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if(contact != null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
            }
        }
        public void DisplayAllContacts()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
            }
        }

    } 
}
