using System;
using System.Linq;

namespace MyContacts
{
    class Contacts : ContactsOperations
    {
        DatabaseContacts contact = new DatabaseContacts();
        
        public Contacts(){}

        public Contacts(int contactId) :base(contactId){}
        
        public override void Delete()
        {
            using(contact)
            {   
                var contactId = contact.Contacts.Find(ContactId);
                contact.Contacts.Remove(contactId);                               
                contact.SaveChanges();
            }
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
                    output_contacts += "Id: " + currentContact.ContactId + "\nName: " + currentContact.Name + 
                                       "\nCity: " + currentContact.City + "\nState: " + currentContact.State + 
                                       "\nPhone number: " + currentContact.Phone_number + 
                                       "\n=============================================\n";                
                }
            }
            return output_contacts;
        }

        public override string SelectById()
        {
            string output_contact;

            using(contact)
            {     
                var contactId = contact.Contacts.Find(ContactId);                           
                output_contact = "Name: " + contactId.Name + "\nCity: " + contactId.City +
                                 "\nState: " + contactId.State + "\nPhone number: " + contactId.Phone_number + "\n";
            }
            return output_contact;
        }

        public override void Update()
        {
            using(contact)
            {                                
                var contactId = contact.Contacts.Find(ContactId);
                contactId.Name = Name;
                contactId.City = City;
                contactId.State = State;
                contactId.Phone_number = Phone_number;
               
                contact.SaveChanges();
            }
        }
    }
}