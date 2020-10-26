using System;

namespace Day._06.Addressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //print statements
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine("Add Contact details here");
            //reference to store values in addressbook
            AddressBook addressBook = new AddressBook();
            addressBook.AddressBookMenu();

        }
    }
}
