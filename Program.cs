﻿using System;

namespace MyContacts
{
    class Program
    {        
        Contacts contact = new Contacts();
        static void Main(string[] args)
        { 
            Program run = new Program();
            Console.Title = "My Contacts";            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;             
            
            int option = run.Menu();

            while(option != 5)
            {
                Console.Clear();

                switch(option)
                {
                    case 1:
                        run.Insert();                                                                          
                        break;
                    case 2:
                        run.Delete();                                                    
                        break;
                    case 3:
                        run.Update();                                                  
                        break;
                    case 4:
                        run.Select();                        
                        break;                
                }
                option = run.Menu();
            };
        }       

        public int Menu()
        {
            Console.WriteLine("1 - Insert new contact");
            Console.WriteLine("2 - Delete contact");
            Console.WriteLine("3 - Update contact");
            Console.WriteLine("4 - Display contacts");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose one option: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void Delete()
        {
            Select();      
            Console.Write("Enter the id of the contact: ");
                                               
            Contacts deleteContact = new Contacts(Int32.Parse(Console.ReadLine()));                                    
            deleteContact.Delete();
            Console.Clear();
            Console.WriteLine("Operation has been completed!");
        }

        public void Insert()
        {
            Console.Clear();
            Console.WriteLine("CONTACTS DATABASE\n");
            Console.WriteLine("Enter the following data:\n");

            Console.Write("Enter the name: ");
            contact.Name = Console.ReadLine();
           
            Console.Write("Enter the city: ");
            contact.City = Console.ReadLine();
            
            Console.Write("Enter the state: ");
            contact.State = Console.ReadLine();
            
            Console.Write("Enter the phone number (Just number):");
            string phone_number = Console.ReadLine();
            contact.Phone_number = $"{long.Parse(phone_number):(00)0-0000-0000}";
            
            contact.Insert();

            Console.Clear();
            Console.WriteLine("Operation has been completed!");        
        }
        
        public void Select()
        {
            Console.Clear();            
            Console.WriteLine(contact.Select());
        }

        //This method is being refactored.
        public void SelectById(int id)
        {
            Console.Clear();
            Contacts contact = new Contacts(id);
            Console.WriteLine(contact.SelectById());
        }

        public void Update()
        {      
            Select();      
            Console.Write("Enter the id of the contact: ");  
            Contacts updateContact = new Contacts(Int32.Parse(Console.ReadLine()));                     

            Console.Write("\nEnter the name: ");
            updateContact.Name = Console.ReadLine();

            Console.Write("Enter the city: ");
            updateContact.City = Console.ReadLine();

            Console.Write("Enter the state: ");
            updateContact.State = Console.ReadLine();

            Console.Write("Enter the phone number (Just number):");
            string phone_number = Console.ReadLine();
            updateContact.Phone_number = $"{long.Parse(phone_number):(00)0-0000-0000}";
                                                
            updateContact.Update();

            Console.Clear();
            Console.WriteLine("Operation has been completed!");
        }
    }
}