using System;

namespace MyContacts
{
    class Contacts : ContactsOperations
    {
        public Contacts(string name, string city, string state, string phone_number)
        {
            Name = name;
            City = city;
            State = state;
            Phone_number = $"{long.Parse(phone_number):(00)00000-0000}";
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }
        
        public override void Insert()
        {            
            using(DatabaseContacts contact = new DatabaseContacts())
            {
                contact.Add(new Contact{Name = Name, City = City, State = State, Phone_number = Phone_number});
                contact.SaveChanges();
            }
        }

        public override void Select()
        {
            throw new NotImplementedException();
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