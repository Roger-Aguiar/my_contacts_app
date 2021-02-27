using System;

namespace MyContacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTACTS DATABASE\n");
            Console.WriteLine("Enter the following data:\n");

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the city: ");
            string city = Console.ReadLine();

            Console.Write("Enter the state: ");
            string state = Console.ReadLine();

            Console.Write("Enter the phone number (Just number):");
            string phone_number = Console.ReadLine();

            Contacts contact = new Contacts(name, city, state, phone_number);
            contact.Insert();
            Console.WriteLine("\nOperation has been completed!");
        }
    }
}
