using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace AddressBookPr
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            AddressBookkk book = new AddressBookkk();
            bool flag = true;
            while (flag)
            { 
                Console.WriteLine("select from the option what u want to do");
                Console.WriteLine("1.to create contact 2. to edit contact 3. delete contact 4.exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter number of contacts u want to add");
                        int total = Convert.ToInt32(Console.ReadLine());
                        while (total > 0)
                        {
                            book.AddContact();
                            total--;
                            book.Display();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name whose contact details u want to edit ");
                        string editName = Console.ReadLine();
                        book.EditContact(editName);
                        book.Display();
                        break;
                    case 3:
                        Console.WriteLine("enter the name whose details u want to delete");
                        string deleteContact=Console.ReadLine();
                        book.DeleteContact(deleteContact);
                        book.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }    
}

