using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPr
{
    public class AddressBookkk
    {
        List<Contact> address = new List<Contact>();

        public void AddContact()
        {
            Contact contact = new Contact();// creating object inside method for every number
            contact.firstName = Console.ReadLine();
            contact.lastName = Console.ReadLine();
            contact.city = Console.ReadLine();
            address.Add(contact);
        }
        public void EditContact(string editname)
        {
            foreach(var contact in address)
            {
                if(contact.firstName.Equals(editname) || contact.lastName.Equals(editname))
                {
                    Console.WriteLine("Enter option what u want to edit");
                    Console.WriteLine("1.firstName 2.lastName 3.city");
                    int select=Convert.ToInt32(Console.ReadLine());
                    switch(select)
                    {
                        case 1:
                            Console.WriteLine("enter the new firstname");
                            contact.firstName = Console.ReadLine();
                            break;
                            case 2:
                            Console.WriteLine("enter the new last name");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the new city");
                            contact.city = Console.ReadLine();
                            break;
                    }
                }
            }

        }
        public void DeleteContact(string deleteContact)
        {
            try
            {
                foreach (var contact in address.ToList())//to collect list
                {
                    if (contact.firstName.Equals(deleteContact) || contact.lastName.Equals(deleteContact))
                    {
                        address.Remove(contact);// without using new delet variable

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Display()
        {
            foreach (var contact in address)
            {
                Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.firstName + "\n" + "LastName: " + contact.lastName + "\n" + "City: " + contact.city);
            }
        }
    }
}
