using System;

namespace MyContacts
{
    class Program
    {
        static void Main(string[] args)
        {              
            int option = Menu();

            while(option != 5)
            {
                Console.Clear();

                switch(option)
                {
                    case 1:
                        Insert(); 
                        Console.Clear();                       
                        Select();                        
                        break;
                    case 2:
                        Delete();                    
                        Select();                        
                        break;
                    case 3:
                        Update();                                                  
                        break;
                    case 4:
                        Select();                        
                        break;                    
                }
                option = Menu();
            };
        }       

        static int Menu()
        {
            Console.WriteLine("1 - Insert new contact");
            Console.WriteLine("2 - Delete contact");
            Console.WriteLine("3 - Update contact");
            Console.WriteLine("4 - Display contacts");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose one option: ");
            return Int32.Parse(Console.ReadLine());
        }

        static void Delete()
        {

        }

        static void Insert()
        {
            Console.Clear();
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

            Console.WriteLine("Operation has been completed!");
        }
        
        static void Select()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine(contacts.Select());
        }

        static void SelectById(int id)
        {
            Contacts contact = new Contacts(id);
            Console.WriteLine(contact.SelectById());
        }

        static void Update()
        {      
            Select();      
            Console.Write("Enter the id of the contact: ");
            int contactId = Int32.Parse(Console.ReadLine()); 
            Console.Clear();
            SelectById(contactId);

            Console.Write("\nEnter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the city: ");
            string city = Console.ReadLine();

            Console.Write("Enter the state: ");
            string state = Console.ReadLine();

            Console.Write("Enter the phone number (Just number):");
            string phone_number = Console.ReadLine();
            
            Contacts contact = new Contacts(contactId, name, city, state, phone_number);                                    
            contact.Update();

            Console.WriteLine("Operation has been completed!");
        }
    }
}
