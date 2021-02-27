using System;
using System.Linq;

namespace MyContacts
{
    class Contacts : ContactsOperations
    {
        DatabaseContacts contact = new DatabaseContacts();

        public Contacts()
        {

        }
        
        public Contacts(string name, string city, string state, string phone_number)
        {
            Name = name;
            City = city;
            State = state;
            Phone_number = $"{long.Parse(phone_number):(00)0-0000-0000}";
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
        
        public override void Insert()
        {            
            using(contact)
            {
                contact.Add(new Contact{Name = Name, City = City, State = State, Phone_number = Phone_number});
                contact.SaveChanges();
            }
        }

        public override string Select()
        {
            string output_contacts;

            output_contacts = "My contacts\n";
            
            using(contact)
            {
                var contactList = contact.Contacts.OrderBy(contacts => contacts.Name);
                foreach (var currentContact in contactList)
                {
                    output_contacts += "Name: " + currentContact.Name + "\nCity: " + currentContact.City + 
                                       "\nState: " + currentContact.State + "\nPhone number: " + currentContact.Phone_number +
                                       "\n=============================================\n";                
                }
            }
            return output_contacts;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}